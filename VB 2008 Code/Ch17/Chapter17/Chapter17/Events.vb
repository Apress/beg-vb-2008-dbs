Public Class Events

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    

    Private Sub Button1_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("I have been clicked")
    End Sub

    Private Sub TextBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.MouseEnter
        Label1.Text = "Mouse Enters into the TextBox"
    End Sub

    Private Sub TextBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.MouseLeave
        Label1.Text = "Mouse Leaves the TextBox"
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.Alt = True Then
            Label1.Text = "The Alt key has been pressed"
        Else
            If e.Control = True Then
                Label1.Text = "The Ctrl key has been pressed"
            Else
                If e.Shift = True Then
                    Label1.Text = "The Shift key has been pressed"
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        If e.Alt = False Or e.Control = False Or e.Shift = False Then
            Label1.Text = "The Key has been released"
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) = True Then
            Label1.Text = "You have pressed a Numeric key"
        Else
            If Char.IsLetter(e.KeyChar) = True Then
                Label1.Text = "You have pressed a Letter key"
            End If
        End If
    End Sub
End Class
