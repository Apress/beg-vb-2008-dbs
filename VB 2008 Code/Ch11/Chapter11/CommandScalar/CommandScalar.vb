Imports System
Imports System.Data
Imports System.Data.SqlClient

Module CommandScalar
    Sub Main()

        'create connection
        Dim conn As SqlConnection = New SqlConnection _
        ("Data Source=.\sqlexpress;" & _
         "Integrated Security=True;" & _
         "database=northwind")

        'create command (with both text and connection)
        Dim sql As String = "select count(*) from employees"


        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        Console.WriteLine("Command created and connected.")

        Try
            'Open connection
            conn.Open()
            Dim count As Integer = cmd.ExecuteScalar()
            Console.WriteLine("Number of Employees is: {0}", count)

            'execute query
            ' Console.WriteLine("Number of Employees is {0}", _
            'cmd.ExecuteScalar())

        Catch ex As SqlException
            Console.WriteLine(ex)

        Finally
            ' Close connection
            conn.Close()
            Console.WriteLine("Connection closed.")
        End Try
    End Sub
End Module

