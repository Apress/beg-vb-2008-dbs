Imports System
Imports System.Data
Imports System.Data.SqlClient

Namespace Chapter6
    Class CallSp1
        Shared Sub Main()
            ' create connection 
            Dim conn As New SqlConnection
            conn.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=Northwind;Integrated Security=True"

            ' open connection 
            conn.Open()

            ' create command 
            Dim cmd As SqlCommand = conn.CreateCommand()

            ' specify stored procedure to execute 
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_select_employees_details"

            ' execute command 
            Dim rdr As SqlDataReader = cmd.ExecuteReader()

            ' Process the result set 
            While rdr.Read()

                Console.WriteLine("{0} {1} {2}", rdr(0).ToString().PadRight(5), rdr(1).ToString(), rdr(2).ToString())
            End While
            'Console.ReadLine()
            rdr.Close()
            conn.Close()
        End Sub
    End Class
End Namespace