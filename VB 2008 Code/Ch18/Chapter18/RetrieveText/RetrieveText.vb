Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Data.SqlClient

Namespace RetrieveText
    Public Class RetrieveText
        Private textFile As String = Nothing
        Private textChars() As Char = Nothing
        Private conn As SqlConnection = Nothing
        Private cmd As SqlCommand = Nothing
        Private dr As SqlDataReader = Nothing

        Public Sub New()
            ' Create connection
            conn = New SqlConnection("Server=.\sqlexpress;" & _
                   "Integrated Security=True;Database=tempdb")

            ' Create command
            cmd = New SqlCommand("" & ControlChars.CrLf & _
            "select" & ControlChars.CrLf & "textfile," & _
            ControlChars.CrLf & "textdata" & _
            ControlChars.CrLf & "from" & _
            ControlChars.CrLf & "texttable" & _
            ControlChars.CrLf & "", conn)

            ' Open connection
            conn.Open()

            ' Create data reader
            dr = cmd.ExecuteReader()
        End Sub
        Public Function GetRow() As Boolean
            Dim textSize As Long
            Dim bufferSize As Integer = 100
            Dim charsRead As Long
            textChars = New Char(bufferSize - 1) {}

            If dr.Read() Then
                ' Get file name
                textFile = dr.GetString(0)
                Console.WriteLine("------ start of file:")
                Console.WriteLine(textFile)
                textSize = dr.GetChars(1, 0, Nothing, 0, 0)
                Console.WriteLine("--- size of text: {0} characters -----", textSize)
                Console.WriteLine("--- first 100 characters in text -----")
                charsRead = dr.GetChars(1, 0, textChars, 0, 100)
                Console.WriteLine(New String(textChars))
                Console.WriteLine("--- last 100 characters in text -----")
                charsRead = dr.GetChars(1, textSize - 100, textChars, 0, 100)
                Console.WriteLine(New String(textChars))

                Return True
            Else
                Return False
            End If
        End Function

        Public Sub endRetrieval()
            ' Close the reader and the connection. 
            dr.Close()
            conn.Close()
            Console.WriteLine("Press Any Key to Continue...........")
            Console.ReadLine()

        End Sub
        Shared Sub Main()
            Dim rt As RetrieveText = Nothing
            Try
                rt = New RetrieveText()

                Do While rt.GetRow() = True
                    Console.WriteLine("----- end of file:")
                    Console.WriteLine(rt.textFile)
                    Console.WriteLine("==========================")
                Loop
            Catch ex As SqlException
                Console.WriteLine(ex.ToString())
            Finally
                rt.endRetrieval()
            End Try
        End Sub
    End Class
End Namespace