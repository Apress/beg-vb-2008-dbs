﻿Imports System
Imports System.Data
Imports System.Data.SqlClient

Namespace Chapter6
    Class CallSp2
        Shared Sub Main()

            ' create connection 
            Dim conn As New SqlConnection
            conn.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=Northwind;Integrated Security=True"

            Try
                ' open connection
                conn.Open()

                ' create command
                Dim cmd As SqlCommand = conn.CreateCommand()

                ' specify stored procedure to execute
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "sp_orders_by_employeeid2"

                ' create input parameter
                Dim inparm As SqlParameter = cmd.Parameters.Add( _
                "@employeeid", SqlDbType.Int)
                inparm.Direction = ParameterDirection.Input
                inparm.Value = 2

                ' create output parameter
                Dim ouparm As SqlParameter = cmd.Parameters.Add( _
                "@ordercount", SqlDbType.Int)
                ouparm.Direction = ParameterDirection.Output

                ' create return value parameter
                Dim retval As SqlParameter = cmd.Parameters.Add( _
                "return_value", SqlDbType.Int)
                retval.Direction = ParameterDirection.ReturnValue

                ' execute command
                Dim rdr As SqlDataReader = cmd.ExecuteReader()

                ' Process the result set
                While rdr.Read()
                    Console.WriteLine("{0} {1}", rdr(0).ToString().PadRight(5), rdr(1).ToString())
                End While
                rdr.Close()

                ' display output parameter value
                Console.WriteLine("The output parameter value is {0}" _
             , cmd.Parameters("@ordercount").Value)

                ' display return value
                Console.WriteLine( _
                 "The return value is {0}" _
               , cmd.Parameters("return_value").Value)
            Catch ex As SqlException
                Console.WriteLine(ex.ToString())
            Finally
                conn.Close()
            End Try
        End Sub
    End Class
End Namespace

