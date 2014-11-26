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
    Me.BrowseBtn = New System.Windows.Forms.Button()
    Me.ExcelBtn = New System.Windows.Forms.Button()
    Me.NotepadBtn = New System.Windows.Forms.Button()
    Me.NotepadplusplusBtn = New System.Windows.Forms.Button()
    Me.WordBtn = New System.Windows.Forms.Button()
    Me.FilePathLabel = New System.Windows.Forms.Label()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'BrowseBtn
    '
    Me.BrowseBtn.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me.BrowseBtn.Location = New System.Drawing.Point(30, 74)
    Me.BrowseBtn.Name = "BrowseBtn"
    Me.BrowseBtn.Size = New System.Drawing.Size(75, 40)
    Me.BrowseBtn.TabIndex = 0
    Me.BrowseBtn.Text = "Browse"
    Me.BrowseBtn.UseVisualStyleBackColor = True
    '
    'ExcelBtn
    '
    Me.ExcelBtn.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me.ExcelBtn.Location = New System.Drawing.Point(30, 156)
    Me.ExcelBtn.Name = "ExcelBtn"
    Me.ExcelBtn.Size = New System.Drawing.Size(98, 78)
    Me.ExcelBtn.TabIndex = 1
    Me.ExcelBtn.Text = "Excel"
    Me.ExcelBtn.UseVisualStyleBackColor = True
    '
    'NotepadBtn
    '
    Me.NotepadBtn.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me.NotepadBtn.Location = New System.Drawing.Point(134, 156)
    Me.NotepadBtn.Name = "NotepadBtn"
    Me.NotepadBtn.Size = New System.Drawing.Size(98, 78)
    Me.NotepadBtn.TabIndex = 2
    Me.NotepadBtn.Text = "Notepad"
    Me.NotepadBtn.UseVisualStyleBackColor = True
    '
    'NotepadplusplusBtn
    '
    Me.NotepadplusplusBtn.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me.NotepadplusplusBtn.Location = New System.Drawing.Point(236, 156)
    Me.NotepadplusplusBtn.Name = "NotepadplusplusBtn"
    Me.NotepadplusplusBtn.Size = New System.Drawing.Size(98, 78)
    Me.NotepadplusplusBtn.TabIndex = 3
    Me.NotepadplusplusBtn.Text = "Notepad ++"
    Me.NotepadplusplusBtn.UseVisualStyleBackColor = True
    '
    'WordBtn
    '
    Me.WordBtn.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me.WordBtn.Location = New System.Drawing.Point(340, 156)
    Me.WordBtn.Name = "WordBtn"
    Me.WordBtn.Size = New System.Drawing.Size(98, 78)
    Me.WordBtn.TabIndex = 4
    Me.WordBtn.Text = "Word"
    Me.WordBtn.UseVisualStyleBackColor = True
    '
    'FilePathLabel
    '
    Me.FilePathLabel.AutoSize = True
    Me.FilePathLabel.Location = New System.Drawing.Point(21, 25)
    Me.FilePathLabel.Name = "FilePathLabel"
    Me.FilePathLabel.Size = New System.Drawing.Size(292, 20)
    Me.FilePathLabel.TabIndex = 6
    Me.FilePathLabel.Text = "Click the browse button to locate a file"
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.FilePathLabel)
    Me.GroupBox1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(453, 56)
    Me.GroupBox1.TabIndex = 7
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Local Disk Path"
    '
    'OpenFileDialog
    '
    Me.OpenFileDialog.FileName = "OpenFileDialog"
    '
    'GroupBox2
    '
    Me.GroupBox2.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me.GroupBox2.Location = New System.Drawing.Point(10, 128)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(453, 127)
    Me.GroupBox2.TabIndex = 8
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Open With"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(477, 262)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.WordBtn)
    Me.Controls.Add(Me.NotepadplusplusBtn)
    Me.Controls.Add(Me.NotepadBtn)
    Me.Controls.Add(Me.ExcelBtn)
    Me.Controls.Add(Me.BrowseBtn)
    Me.Controls.Add(Me.GroupBox2)
    Me.Name = "Form1"
    Me.Text = "Open File With"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents BrowseBtn As System.Windows.Forms.Button
  Friend WithEvents ExcelBtn As System.Windows.Forms.Button
  Friend WithEvents NotepadBtn As System.Windows.Forms.Button
  Friend WithEvents NotepadplusplusBtn As System.Windows.Forms.Button
  Friend WithEvents WordBtn As System.Windows.Forms.Button
  Friend WithEvents FilePathLabel As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
