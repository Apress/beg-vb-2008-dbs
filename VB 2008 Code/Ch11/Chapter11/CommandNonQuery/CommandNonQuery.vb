﻿Imports System
Imports System.Data
Imports System.Data.SqlClient

Module CommandNonQuery
    Sub Main()

        'create connection
        Dim conn As SqlConnection = New SqlConnection _
        ("Data Source=.\sqlexpress;" & _
         "Integrated Security=True;" & _
         "database=northwind")

        'define scalar query
        Dim sqlqry As String = "select count(*)from employees"

        'define insert statement
        Dim sqlins As String = "insert into employees " & _
        "(firstname,lastname)values('Zachariah', 'Zinn')"

        'define delete statement
        Dim sqldel As String = "delete from employees " & _
        "where firstname = 'Zachariah'" & _
        "and lastname = 'Zinn'"

        'create commands 
        Dim cmdqry As SqlCommand = New SqlCommand(sqlqry, conn)
        Dim cmdnon As SqlCommand = New SqlCommand(sqlins, conn)
        Console.WriteLine("Command created and connected.")

        Try
            'Open connection
            conn.Open()

            'execute query to get number of employees
            Console.WriteLine("Before INSERT: Number of employees {0}" _
            , cmdqry.ExecuteScalar())

            'execute nonquery to insert an employee
            Console.WriteLine("Executing statement {0}" _
            , cmdnon.CommandText)

            cmdnon.ExecuteNonQuery()

            Console.WriteLine("After INSERT: Number of employees {0}" _
           , cmdqry.ExecuteScalar())

            'execute nonquery to delete an employee
            cmdnon.CommandText = sqldel
            Console.WriteLine("Executing statement {0}" _
             , cmdnon.CommandText)
            cmdnon.ExecuteNonQuery()
            Console.WriteLine("After DELETE: Number of employees {0}" _
            , cmdqry.ExecuteScalar())

        Catch ex As SqlException
            Console.WriteLine(ex)

        Finally
            ' Close connection
            conn.Close()
            Console.WriteLine("Connection closed.")
        End Try
    End Sub
End Module
