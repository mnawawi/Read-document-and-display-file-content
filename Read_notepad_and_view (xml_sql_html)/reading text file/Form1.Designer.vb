<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.TextBox1 = New System.Windows.Forms.TextBox()
    Me.Button2 = New System.Windows.Forms.Button()
    Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
    Me.Button3 = New System.Windows.Forms.Button()
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(30, 19)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(48, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "File Path"
    '
    'TextBox1
    '
    Me.TextBox1.Location = New System.Drawing.Point(84, 12)
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.Size = New System.Drawing.Size(389, 20)
    Me.TextBox1.TabIndex = 1
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(398, 38)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(75, 23)
    Me.Button2.TabIndex = 4
    Me.Button2.Text = "Clear"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'RichTextBox1
    '
    Me.RichTextBox1.Location = New System.Drawing.Point(12, 67)
    Me.RichTextBox1.Name = "RichTextBox1"
    Me.RichTextBox1.Size = New System.Drawing.Size(461, 333)
    Me.RichTextBox1.TabIndex = 5
    Me.RichTextBox1.Text = ""
    '
    'Button3
    '
    Me.Button3.Location = New System.Drawing.Point(317, 38)
    Me.Button3.Name = "Button3"
    Me.Button3.Size = New System.Drawing.Size(75, 23)
    Me.Button3.TabIndex = 6
    Me.Button3.Text = "Open"
    Me.Button3.UseVisualStyleBackColor = True
    '
    'OpenFileDialog1
    '
    Me.OpenFileDialog1.FileName = "OpenFileDialog1"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(485, 412)
    Me.Controls.Add(Me.Button3)
    Me.Controls.Add(Me.RichTextBox1)
    Me.Controls.Add(Me.Button2)
    Me.Controls.Add(Me.TextBox1)
    Me.Controls.Add(Me.Label1)
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
  Friend WithEvents Button2 As System.Windows.Forms.Button
  Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
  Friend WithEvents Button3 As System.Windows.Forms.Button
  Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
