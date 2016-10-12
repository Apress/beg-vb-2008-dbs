Imports System
Imports System.Data
Imports System.Data.SqlClient

Module CommandReader
    Sub Main()

        'create connection
        Dim conn As SqlConnection = New SqlConnection _
        ("Data Source=.\sqlexpress;" & _
         "Integrated Security=True;" & _
         "database=northwind")

        'create command (with both text and connection)
        Dim sql As String = "select firstname,lastname from employees"


        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        Console.WriteLine("Command created and connected.")

        Try
            'Open connection
            conn.Open()

            'execute query
            Dim rdr As SqlDataReader = cmd.ExecuteReader

            While (rdr.Read)
                Console.WriteLine("Employee name: {0} {1}", _
                rdr.GetValue(0), rdr.GetValue(1))
            End While

        Catch ex As SqlException
            Console.WriteLine(ex)

        Finally
            ' Close connection
            conn.Close()
            Console.WriteLine("Connection closed.")
        End Try
    End Sub
End Module


