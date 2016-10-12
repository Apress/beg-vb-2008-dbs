Imports System
Imports System.Data
Imports System.Data.SqlClient

Module WriteXML
    Sub Main()

        Dim connstring As String = _
        ("Data Source=.\sqlexpress;" & _
         "Integrated Security=True;" & _
         "database=northwind")

        'create command (with both text and connection)
        Dim sql As String = "Select productname,unitprice " & _
        "from products"

        'create connection
        Dim conn As SqlConnection = New SqlConnection(connstring)

        Try

            'create data adapter
            Dim da As SqlDataAdapter = New SqlDataAdapter
            da.SelectCommand = New SqlCommand(sql, conn)

            'Open connection
            conn.Open()

            'create and fill dataset
            Dim ds As DataSet = New DataSet
            da.Fill(ds, "products")

            'extract dataset to XML file
            ds.WriteXml("C:\Documents and Settings\Toshiba User\" & _
            "My Documents\Visual Studio 2008\Projects\Chapter13\productstable.xml")
            Console.WriteLine("The XML file is Created")

        Catch e As Exception
            Console.WriteLine("Error Occured:" & e.ToString)

        Finally
            ' Close connection
            conn.Close()
        End Try
    End Sub
End Module

