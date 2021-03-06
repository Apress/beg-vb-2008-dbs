﻿Imports System
Imports System.Data
Imports System.Data.SqlClient

Module PopDataTable
    Sub Main()

        Dim connstring As String = _
        ("Data Source=.\sqlexpress;" & _
         "Integrated Security=True;" & _
         "database=northwind")

        'create command (with both text and connection)
        Dim sql As String = "select productname,unitprice " & _
        "from products where unitprice < 20"

        'create connection
        Dim conn As SqlConnection = New SqlConnection(connstring)

        Try
            'Open connection
            conn.Open()

            'create data adapter
            Dim da As SqlDataAdapter = New SqlDataAdapter(sql, conn)

            'create data table
            Dim dt As DataTable = New DataTable

            'fill data table
            da.Fill(dt)

            'display data
            Dim row As DataRow
            For Each row In dt.Rows
                Dim col As DataColumn
                For Each col In dt.Columns
                    Console.WriteLine(row(col))
                Next col
                Console.WriteLine("".PadLeft(20, "="c))
            Next row

        Catch e As Exception
            Console.WriteLine("Error Occured:" & e.ToString)

        Finally
            ' Close connection
            conn.Close()
        End Try
    End Sub
End Module

