Imports System
Imports System.Data
Imports System.Data.SqlClient
Module PersistAdds
    Sub Main()
        Dim connstring As String = _
           ("Data Source=.\sqlexpress;" & _
            "Integrated Security=True;" & _
            "database=northwind")

        'query
        Dim qry As String = "select * from employees " & _
        "where country = 'UK'"

        'SQL to insert employees
        Dim ins As String = "insert into employees " & _
        "(firstname,lastname,titleofcourtesy,city,country)" & _
        "values(@firstname,@lastname,@titleofcourtesy,@city,@country)"

        'create connection
        Dim conn As SqlConnection = New SqlConnection(connstring)
        Try
            ' create data adapter
            Dim da As New SqlDataAdapter()
            da.SelectCommand = New SqlCommand(qry, conn)

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
            '
            ' create command
            Dim cmd As New SqlCommand(ins, conn)
            '
            ' map parameters
            cmd.Parameters.Add("@firstname", _
            SqlDbType.NVarChar, 10, "firstname")
            cmd.Parameters.Add("@lastname", _
            SqlDbType.NVarChar, 20, "lastname")
            cmd.Parameters.Add("@titleofcourtesy", _
            SqlDbType.NVarChar, 25, "titleofcourtesy")
            cmd.Parameters.Add("@city", _
            SqlDbType.NVarChar, 15, "city")
            cmd.Parameters.Add("@country", _
            SqlDbType.NVarChar, 15, "country")
            '
            ' insert employees
            da.InsertCommand = cmd
            da.Update(ds, "employees")
        Catch e As Exception
            Console.WriteLine(("Error: " + e.ToString))
        Finally
            ' close connection
            conn.Close()
        End Try
    End Sub
End Module
