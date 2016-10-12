Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO

Namespace DisplayImage
    Public Class Images
        Private imageFilename As String = Nothing
        Private imageBytes() As Byte = Nothing

        Private imageConnection As SqlConnection = Nothing
        Private imageCommand As SqlCommand = Nothing
        Private imageReader As SqlDataReader = Nothing

        ' Constructor
        Public Sub New()
            imageConnection = New SqlConnection("Server=.\sqlexpress;" & _
            "Integrated Security=True;Database=tempdb")
            imageCommand = New SqlCommand("" & ControlChars.CrLf & _
            "select" & ControlChars.CrLf & "imagefile," & _
            ControlChars.CrLf & "imagedata" & ControlChars.CrLf & _
            "from" & ControlChars.CrLf & "imagetable" & _
            ControlChars.CrLf & "", imageConnection)

            ' Open connection and create data reader
            imageConnection.Open()
            imageReader = imageCommand.ExecuteReader()
        End Sub

        Public Function GetImage() As Bitmap
            Dim ms As New MemoryStream(imageBytes)
            Dim bmap As New Bitmap(ms)

            Return bmap
        End Function

        Public Function GetFilename() As String
            Return imageFilename
        End Function

        Public Function GetRow() As Boolean
            If imageReader.Read() Then
                imageFilename = CStr(imageReader.GetValue(0))
                imageBytes = CType(imageReader.GetValue(1), Byte())

                Return True
            Else
                Return False
            End If
        End Function

        Public Sub EndImages()
            ' Close the reader and the connection.
            imageReader.Close()
            imageConnection.Close()
        End Sub
    End Class
End Namespace