Public Class ParentForm

    Private Sub WinAppToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WinAppToolStripMenuItem.Click
        Dim wa As WinApp = New WinApp
        wa.MdiParent = Me
        wa.Show()
    End Sub

    Private Sub AddNamesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNamesToolStripMenuItem.Click
        Dim an As AddNames = New AddNames
        an.MdiParent = Me
        an.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class