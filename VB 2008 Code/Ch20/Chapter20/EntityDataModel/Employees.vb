Imports System.Data.EntityClient
Public Class Employees

    Private Sub btnEmployees_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnEmployees.Click
        Dim connection As EntityConnection = New EntityConnection _
        ("name=NorthwindEntitiesConnectionString")
        connection.Open()
        Dim command As EntityCommand = connection.CreateCommand()
        command.CommandText = "select E.FirstName,E.LastName " & _
        "from NorthwindEntitiesConnectionString.Employees as E"
        Dim reader As EntityDataReader = _
        command.ExecuteReader(CommandBehavior.SequentialAccess)
        lstEmployees.Items.Clear()
        While reader.Read()
            lstEmployees.Items.Add(reader("FirstName") + _
            " " + reader("LastName"))
        End While
    End Sub
End Class
