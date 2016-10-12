Imports System
Imports System.Data
Imports System.Data.SqlClient

Module DataLooper
    Sub Main()

        Dim connstring As String = _
        ("Data Source=.\sqlexpress;" & _
         "Integrated Security=True;" & _
         "database=northwind")

        'create command (with both text and connection)
        Dim sql As String = "select contactname from customers"

        'create connection
        Dim conn As SqlConnection = New SqlConnection(connstring)

        Try
            'Open connection
            conn.Open()

            Dim cmd As SqlCommand = New SqlCommand(sql, conn)

            'create data reader
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            'loop through result set
            While (rdr.Read)
                'print one row at a time
                Console.WriteLine("{0}", _
                rdr.GetValue(0))
            End While
            'close data reader
            rdr.Close()
        Catch e As Exception
            Console.WriteLine("Error Occured:" & e.ToString)

        Finally
            ' Close connection
            conn.Close()
        End Try
    End Sub
End Module

