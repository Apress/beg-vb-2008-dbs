<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employees
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnEmployees = New System.Windows.Forms.Button
        Me.lstEmployees = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'btnEmployees
        '
        Me.btnEmployees.Location = New System.Drawing.Point(79, 26)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(112, 23)
        Me.btnEmployees.TabIndex = 0
        Me.btnEmployees.Text = "Get Employees"
        Me.btnEmployees.UseVisualStyleBackColor = True
        '
        'lstEmployees
        '
        Me.lstEmployees.FormattingEnabled = True
        Me.lstEmployees.Location = New System.Drawing.Point(39, 67)
        Me.lstEmployees.Name = "lstEmployees"
        Me.lstEmployees.Size = New System.Drawing.Size(196, 186)
        Me.lstEmployees.TabIndex = 1
        '
        'Employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 266)
        Me.Controls.Add(Me.lstEmployees)
        Me.Controls.Add(Me.btnEmployees)
        Me.Name = "Employees"
        Me.Text = "Employees Detail"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEmployees As System.Windows.Forms.Button
    Friend WithEvents lstEmployees As System.Windows.Forms.ListBox

End Class
