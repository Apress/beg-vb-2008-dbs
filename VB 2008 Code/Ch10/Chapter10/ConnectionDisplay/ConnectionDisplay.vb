Imports System
Imports System.Data
Imports System.Data.SqlClient

Module ConnectionDisplay
    Sub Main()

        'Set up connection string
        Dim connstring As String
        connstring = "data source = .\sqlexpress;" & _
        "Integrated Security=True"

        'Create connection
        Dim conn As SqlConnection = New SqlConnection(connstring)

        Try
            ' Open connection
            conn.Open()
            Console.WriteLine("Connection opened")

            'Display connection properties
            Console.WriteLine("Connection Properties:")
            Console.WriteLine("Connection String: {0}", conn.ConnectionString)
            Console.WriteLine("Database: {0}", conn.Database)
            Console.WriteLine("DataSource: {0}", conn.DataSource)
            Console.WriteLine("ServerVersion: {0}", conn.ServerVersion)
            Console.WriteLine("State: {0}", conn.State)
            Console.WriteLine("WorkstationId: {0}", conn.WorkstationId)

        Catch e As SqlException
            Console.WriteLine("Error:" & e.ToString)

        Finally
            ' Close connection
            conn.Close()
            Console.WriteLine("Connection closed.")
        End Try
    End Sub
End Module
