Imports System
Imports System.Data
Imports System.Data.SqlClient

Module OrdinalIndexer
    Sub Main()

        Dim connstring As String = _
        ("Data Source=.\sqlexpress;" & _
         "Integrated Security=True;" & _
         "database=northwind")

        'create command (with both text and connection)
        Dim sql As String = "select companyname,contactname " & _
        "from customers " & _
        "where contactname like 'M%'"

        'create connection
        Dim conn As SqlConnection = New SqlConnection(connstring)

        Try
            'Open connection
            conn.Open()

            Dim cmd As SqlCommand = New SqlCommand(sql, conn)

            'create data reader
            Dim rdr As SqlDataReader = cmd.ExecuteReader

            'print headings
            Console.WriteLine("{0}   {1}", _
               "Company Name".PadRight(25), _
               "Contact Name".PadRight(20))

            Console.WriteLine("{0}   {1}", _
               "============".PadRight(25), _
               "============".PadRight(20))

            'loop through result set
            While (rdr.Read)
                Console.WriteLine(" {0} | {1}", _
                rdr(0).ToString().PadLeft(25), _
                rdr(1).ToString().PadLeft(20))
            End While

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
