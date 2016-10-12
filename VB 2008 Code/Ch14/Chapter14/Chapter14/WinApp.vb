Public Class WinApp

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        MessageBox.Show("Hello" & " " & txtFname.Text & " " & txtLname.Text & " " & _
       "Welcome to the Windows Application", "Welcome")
    End Sub
End Class
