Imports System
Imports System.Data
Imports System.Data.SqlClient

Module SchemaTable
    Sub Main()

        Dim connstring As String = _
        ("Data Source=.\sqlexpress;" & _
         "Integrated Security=True;" & _
         "database=northwind")

        'create command (with both text and connection)
        Dim sql As String = "select * from employees"

        'create connection
        Dim conn As SqlConnection = New SqlConnection(connstring)

        Try
            'Open connection
            conn.Open()

            'create command
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)

            'create data reader
            Dim rdr As SqlDataReader = cmd.ExecuteReader

            'store Employees schema in a data table
            Dim schema As DataTable = rdr.GetSchemaTable

            Dim row As DataRow
            For Each row In schema.Rows
                Dim col As DataColumn
                For Each col In schema.Columns
                    Console.WriteLine _
                    ((col.ColumnName + " = " + row(col).ToString))
                Next col
                Console.WriteLine("----------------")
            Next row

            'close data reader
            rdr.Close()
        Catch e As Exception
            Console.WriteLine("Error Occured:" & e.ToString)

        Finally
            ' Close connection
            conn.Close()
        End Try
    End Sub
End Module


