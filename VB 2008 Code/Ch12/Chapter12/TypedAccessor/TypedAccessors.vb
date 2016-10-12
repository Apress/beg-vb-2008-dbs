Imports System
Imports System.Data
Imports System.Data.SqlClient

Module TypedAccessors
    Sub Main()

        Dim connstring As String = _
        ("Data Source=.\sqlexpress;" & _
         "Integrated Security=True;" & _
         "database=northwind")

        'create command (with both text and connection)
        Dim sql As String = "select productname, " & _
        "unitprice,unitsinstock,discontinued " & _
        "from products"

        'create connection
        Dim conn As SqlConnection = New SqlConnection(connstring)

        Try
            'Open connection
            conn.Open()

            'create command
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)

            'create data reader
            Dim rdr As SqlDataReader = cmd.ExecuteReader

            'loop through result set
            While (rdr.Read)
                Console.WriteLine("{0} {1} {2} {3}", _
                rdr.GetString(0).PadRight(35), _
                rdr.GetDecimal(1), _
                rdr.GetInt16(2), _
                rdr.GetBoolean(3))
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
