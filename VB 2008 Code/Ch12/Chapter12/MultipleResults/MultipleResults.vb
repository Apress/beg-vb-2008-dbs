﻿Imports System
Imports System.Data
Imports System.Data.SqlClient

Module MultipleResults
    Sub Main()

        Dim connstring As String = _
        ("Data Source=.\sqlexpress;" & _
         "Integrated Security=True;" & _
         "database=northwind")

        'query1
        Dim sql1 As String = "select companyname,contactname " & _
        "from customers where " & _
        "companyname like 'A%'"

        'query2
        Dim sql2 As String = "select firstname," & _
        "lastname from employees"

        'combine queries
        Dim sql As String = sql1 + sql2

        'create connection
        Dim conn As SqlConnection = New SqlConnection(connstring)

        Try
            'Open connection
            conn.Open()

            'create command
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)

            'create data reader
            Dim rdr As SqlDataReader = cmd.ExecuteReader

            Do
                While rdr.Read()
                    ' Print one row at a time
                    Console.WriteLine("{0} : {1}", rdr(0), rdr(1))
                End While
                Console.WriteLine("".PadLeft(60, "=".ToString))
            Loop While rdr.NextResult()

        Catch e As Exception
            Console.WriteLine("Error Occured:" & e.ToString)

        Finally
            ' Close connection
            conn.Close()
        End Try
    End Sub
End Module


