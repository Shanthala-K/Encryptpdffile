<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmencrypt
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtBxTotalMin = New System.Windows.Forms.TextBox()
        Me.txtBxTotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(68, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "EncryptPDF"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(187, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 31)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtBxTotalMin
        '
        Me.txtBxTotalMin.Location = New System.Drawing.Point(80, 189)
        Me.txtBxTotalMin.Name = "txtBxTotalMin"
        Me.txtBxTotalMin.Size = New System.Drawing.Size(154, 20)
        Me.txtBxTotalMin.TabIndex = 2
        '
        'txtBxTotal
        '
        Me.txtBxTotal.Location = New System.Drawing.Point(80, 229)
        Me.txtBxTotal.Name = "txtBxTotal"
        Me.txtBxTotal.Size = New System.Drawing.Size(154, 20)
        Me.txtBxTotal.TabIndex = 3
        '
        'frmencrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1510, 505)
        Me.Controls.Add(Me.txtBxTotal)
        Me.Controls.Add(Me.txtBxTotalMin)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmencrypt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encryptpdffile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtBxTotalMin As TextBox
    Friend WithEvents txtBxTotal As TextBox
End Class
