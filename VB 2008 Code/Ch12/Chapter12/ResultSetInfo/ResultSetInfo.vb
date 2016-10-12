Imports System
Imports System.Data
Imports System.Data.SqlClient

Module ResultSetInfo
    Sub Main()

        Dim connstring As String = _
        ("Data Source=.\sqlexpress;" & _
         "Integrated Security=True;" & _
         "database=northwind")

        'create command (with both text and connection)
        Dim sql As String = "select contactname,contacttitle " & _
        "from customers where " & _
        "contactname like 'M%'"

        'create connection
        Dim conn As SqlConnection = New SqlConnection(connstring)

        Try
            'Open connection
            conn.Open()

            'create command
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)

            'create data reader
            Dim rdr As SqlDataReader = cmd.ExecuteReader

            'get column names
            Console.WriteLine("Column Name:{0} {1}", _
            rdr.GetName(0).PadRight(20), _
            rdr.GetName(1))

            'get column data types
            Console.WriteLine("Data Type:{0} {1}", _
            rdr.GetDataTypeName(0).PadRight(20), _
            rdr.GetDataTypeName(1))

            Console.WriteLine()

            'loop through result set
            While (rdr.Read)
                'get column values for all rows
                Console.WriteLine("{0} {1}", _
                rdr.GetString(0).ToString().PadRight(25), _
                rdr.GetString(1))
            End While

            'get number of columns
            Console.WriteLine()
            Console.WriteLine("Number of columns in a row: {0}", _
            rdr.FieldCount)

            'get info about each column 
            Console.WriteLine("'{0}' is at index {1} " & _
            "and its type is: {2}", _
              rdr.GetName(0), _
              rdr.GetOrdinal("contactname"), _
              rdr.GetFieldType(0))

            Console.WriteLine("'{0}' is at index {1} " & _
            "and its type is: {2}", _
               rdr.GetName(1), _
               rdr.GetOrdinal("contacttitle"), _
               rdr.GetFieldType(1))

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

