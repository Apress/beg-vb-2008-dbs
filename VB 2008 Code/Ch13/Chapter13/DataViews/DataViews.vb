﻿Imports System
Imports System.Data
Imports System.Data.SqlClient

Module DataViews
    Sub Main()

        Dim connstring As String = _
        ("Data Source=.\sqlexpress;" & _
         "Integrated Security=True;" & _
         "database=northwind")

        'query 
        Dim sql As String = "select contactname,country from customers"

        'create connection
        Dim conn As SqlConnection = New SqlConnection(connstring)

        Try
            'create data adapter
            Dim da As SqlDataAdapter = New SqlDataAdapter
            da.SelectCommand = New SqlCommand(sql, conn)

            'create and fill dataset
            Dim ds As DataSet = New DataSet
            da.Fill(ds, "customers")

            ' get data table reference
            Dim dt As DataTable = ds.Tables("customers")

            ' create data view
            Dim dv As New DataView(dt, "country = 'Germany'", "country", _
                                   DataViewRowState.CurrentRows)

            ' display data from data view
            Dim drv As DataRowView
            For Each drv In dv
                Dim i As Integer
                For i = 0 To dv.Table.Columns.Count - 1
                    Console.Write((drv(i) + ControlChars.Tab))
                Next i
                Console.WriteLine()
            Next drv

        Catch e As Exception
            Console.WriteLine("Error Occured:" & e.ToString)

        Finally
            ' Close connection
            conn.Close()
        End Try
    End Sub
End Module



