Imports System
Imports System.Data
Imports System.Data.SqlClient

Module PersistChanges
    Sub Main()
        Dim connstring As String = _
        ("Data Source=.\sqlexpress;" & _
         "Integrated Security=True;" & _
         "database=northwind")

        'query
        Dim qry As String = "select * from employees " & _
        "where country = 'UK'"

        'SQL to update employees
        Dim upd As String = "update employees " & _
        "set city = @city " & _
        "where employeeid = @employeeid"

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

            ' modify city in first row
            dt.Rows(0)("city") = "Wilmington"

            ' display rows
            Dim row As DataRow
            For Each row In dt.Rows
                Console.WriteLine("{0} {1} {2}", _
                row("firstname").ToString().PadRight(15), _
                row("lastname").ToString().PadLeft(25), row("city"))
            Next row

            ' update Employees
            '
            ' create command
            Dim cmd As New SqlCommand(upd, conn)
            '
            ' map parameters
            '
            ' City
            cmd.Parameters.Add("@city", SqlDbType.NVarChar, 15, "city")
            '
            ' EmployeeID
            Dim parm As SqlParameter = cmd.Parameters.Add _
            ("@employeeid", SqlDbType.Int, 4, "employeeid")
            parm.SourceVersion = DataRowVersion.Original
            '
            ' Update database
            da.UpdateCommand = cmd
            da.Update(ds, "employees")
        Catch e As Exception
            Console.WriteLine(("Error: " + e.ToString))
        Finally
            ' close connection
            conn.Close()
        End Try
    End Sub
End Module

