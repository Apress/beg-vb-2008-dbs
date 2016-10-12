Imports System.Drawing

Public Class DisplayImages
    Dim images As DisplayImage.Images
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        images = New DisplayImage.Images()

        If images.GetRow() Then
            Me.TextBox1.Text = images.GetFilename()
            Me.PictureBox1.Image = CType(images.GetImage(), Image)
        Else
            Me.TextBox1.Text = "DONE"
            Me.PictureBox1.Image = Nothing
        End If
    End Sub

End Class