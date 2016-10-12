Public Class AddNames

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        lstName.Items.Add(txtName.Text)
        txtName.Clear()
    End Sub

    Private Sub AddName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class