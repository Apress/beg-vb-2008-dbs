Imports System
Imports System.Data
Imports System.Data.SqlClient

Module ConnectionSQL
    Sub Main()

        'create connection
        Dim conn As SqlConnection = New SqlConnection _
        ("Data Source=.\sqlexpress;" & _
         "Integrated Security=True;" & _
         "database=northwind")

        'create command
        Dim cmd As SqlCommand = New SqlCommand
        Console.WriteLine("Command created.")

        Try
            'Open connection
            conn.Open()

            'connect command to connection
            cmd.Connection = conn
            Console.WriteLine("Connnected command to this connection.")

            ' associate SQL with command
            cmd.CommandText = "select count(*)from employees"

            Console.WriteLine("Ready to execute SQL:" & _
            cmd.CommandText)


        Catch ex As SqlException
            Console.WriteLine(ex)

        Finally
            ' Close connection
            conn.Close()
            Console.WriteLine("Connection closed.")
        End Try
    End Sub
End Module
