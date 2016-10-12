Imports System
Imports System.Linq
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Data.Linq.DataContext

Namespace Chapter19
    Class LinqToSql
        <Table(Name:="Customers")> _
        Public Class Customer
            <Column()> _
            Public customerId As String
            <Column()> _
            Public companyName As String
            <Column()> _
            Public city As String
            <Column()> _
            Public counTry As String
        End Class

        Shared Sub Main(ByVal args() As String)
            ' connection string
            Dim connString As String = "server = .\sqlexpress;" & _
            "Integrated security = True;database = northwind"

            ' create data context 
            Dim db As DataContext = New DataContext(connString)

            ' create typed table 
            Dim Customers As Table(Of Customer) = db.GetTable(Of Customer)()

            ' query database
            Dim custs = From c In Customers _
                        Select c

            ' display customers
            For Each c In custs
                Console.WriteLine("{0}, {1}, {2}, {3}", _
                c.customerId, c.companyName, c.city, c.counTry)
            Next
        End Sub
    End Class
End Namespace
