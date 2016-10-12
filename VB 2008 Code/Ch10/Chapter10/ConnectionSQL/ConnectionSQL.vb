Imports System
Imports System.Data
Imports System.Data.SqlClient

Module ConnectionSQL
    Sub Main()

        'Set up connection string
        Dim connstring As String
        connstring = "server=.\sqlexpress;Integrated Security=True"
        'Create connection
        Dim conn As SqlConnection = New SqlConnection(connstring)
        
        Try
            ' Open connection
            conn.Open()
            Console.WriteLine("Connection opened")

        Catch e As SqlException
            Console.WriteLine("Error:" & e.ToString)

        Finally
            ' Close connection
            conn.Close()
            Console.WriteLine("Connection closed.")
        End Try
    End Sub
End Module

