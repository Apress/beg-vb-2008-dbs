﻿Imports System
Imports System.Data
Imports System.Data.SqlClient

Module FilterSort
    Sub Main()

        Dim connstring As String = _
        ("Data Source=.\sqlexpress;" & _
         "Integrated Security=True;" & _
         "database=northwind")

        'query 1
        Dim sql1 As String = "select * from customers"

        'query 2
        Dim sql2 As String = " select * from products " & _
                             "where unitprice < 10"

        'combine queries
        Dim sql As String = sql1 + sql2

        'create connection
        Dim conn As SqlConnection = New SqlConnection(connstring)

        Try
            'Open connection
            conn.Open()

            'create data adapter
            Dim da As SqlDataAdapter = New SqlDataAdapter
            da.SelectCommand = New SqlCommand(sql, conn)

            'create and fill dataset
            Dim ds As DataSet = New DataSet
            da.Fill(ds, "customers")

            ' get the data tables collection
            Dim dtc As DataTableCollection = ds.Tables

            ' display data from first data table
            '
            ' display output header
            Console.WriteLine("Results from Customers table:")
            Console.WriteLine(("CompanyName".PadRight(20) + "ContactName".PadLeft(23) + ControlChars.Lf))

            ' set display filter
            Dim fl As String = "country = 'Germany'"

            ' set sort
            Dim srt As String = "companyname asc"

            ' display filtered and sorted data
            Dim row As DataRow
            For Each row In dtc("customers").Select(fl, srt)
                Console.WriteLine("{0}" + ControlChars.Tab + "{1}", row("CompanyName").ToString().PadRight(25), row("ContactName"))
            Next row

            ' display data from second data table
            '
            ' display output header
            Console.WriteLine(ControlChars.Lf + "----------------------------")
            Console.WriteLine("Results from Products table:")
            Console.WriteLine(("ProductName".PadRight(20) + "UnitPrice".PadLeft(21) + ControlChars.Lf))

            ' display data
            'Dim row As DataRow
            For Each row In dtc(1).Rows
                Console.WriteLine("{0}" + ControlChars.Tab + "{1}", row("productname").ToString().PadRight(25), row("unitprice"))
            Next row

        Catch e As Exception
            Console.WriteLine("Error Occured:" & e.ToString)

        Finally
            ' Close connection
            conn.Close()
        End Try
    End Sub
End Module



