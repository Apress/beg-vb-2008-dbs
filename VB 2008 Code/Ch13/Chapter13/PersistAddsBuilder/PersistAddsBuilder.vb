Imports System
Imports System.Data
Imports System.Data.SqlClient
Module PersistAddsBuilder
    Sub Main()
        Dim connstring As String = _
           ("Data Source=.\sqlexpress;" & _
            "Integrated Security=True;" & _
            "database=northwind")

        'query
        Dim qry As String = "select * from employees " & _
        "where country = 'UK'"

        'create connection
        Dim conn As SqlConnection = New SqlConnection(connstring)
        Try
            ' create data adapter
            Dim da As New SqlDataAdapter()
            da.SelectCommand = New SqlCommand(qry, conn)

            'create command builder
            Dim cb As SqlCommandBuilder = New SqlCommandBuilder(da)

            ' create and fill dataset
            Dim ds As New DataSet()
            da.Fill(ds, "employees")

            ' get data table reference
            Dim dt As DataTable = ds.Tables("employees")

            ' add a row
            Dim newRow As DataRow = dt.NewRow()
            newRow("firstname") = "Roy"
            newRow("lastname") = "Beatty"
            newRow("titleofcourtesy") = "Sir"
            newRow("city") = "Birmingham"
            newRow("country") = "UK"
            dt.Rows.Add(newRow)

            ' display rows
            Dim row As DataRow
            For Each row In dt.Rows
                Console.WriteLine("{0} {1} {2}", _
                row("firstname").ToString().PadRight(15), _
                row("lastname").ToString().PadLeft(25), row("city"))
            Next row

            ' insert employees
            da.Update(ds, "employees")

        Catch e As Exception
            Console.WriteLine(("Error: " + e.ToString))
        Finally
            ' close connection
            conn.Close()
        End Try
    End Sub
End Module

