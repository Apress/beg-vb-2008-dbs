Imports System
Imports System.Data
Imports System.Data.OleDb

Module ConnectionOleDb
    Sub Main()

        'Set up connection string
        Dim connstring As String
        connstring = "data source = .\sqlexpress;" & _
        "provider = sqloledb;integrated security = sspi"

        'Create connection
        Dim conn As OleDbConnection = New OleDbConnection(connstring)

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


        Catch e As OleDbException
            Console.WriteLine("Error:" & e.ToString)

        Finally
            ' Close connection
            conn.Close()
            Console.WriteLine("Connection closed.")
        End Try
    End Sub
End Module

