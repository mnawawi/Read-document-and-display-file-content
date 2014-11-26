Public Class Form1


  Private Sub BrowseBtn_Click(sender As Object, e As EventArgs) Handles BrowseBtn.Click

    OpenFileDialog.ShowDialog()

    FilePathLabel.Text = OpenFileDialog.FileName

    ExcelBtn.Enabled = True
    NotepadBtn.Enabled = True
    NotepadplusplusBtn.Enabled = True
    WordBtn.Enabled = True

  End Sub

  Private Sub ExcelBtn_Click(sender As Object, e As EventArgs) Handles ExcelBtn.Click

    Process.Start("Excel", FilePathLabel.Text)
  End Sub

  Private Sub NotepadBtn_Click(sender As Object, e As EventArgs) Handles NotepadBtn.Click
    Process.Start("notepad", FilePathLabel.Text)
  End Sub

  Private Sub NotepadplusplusBtn_Click(sender As Object, e As EventArgs) Handles NotepadplusplusBtn.Click
    Process.Start("notepad++", FilePathLabel.Text)
  End Sub

  Private Sub WordBtn_Click(sender As Object, e As EventArgs) Handles WordBtn.Click
    Process.Start("winword", FilePathLabel.Text)
  End Sub

  Private Sub FilePathLabel_Click(sender As Object, e As EventArgs) Handles FilePathLabel.Click

  End Sub

  Private Sub FilePathLabel_TextChanged(sender As Object, e As EventArgs) Handles FilePathLabel.TextChanged

  End Sub

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ExcelBtn.Enabled = False
    NotepadBtn.Enabled = False
    NotepadplusplusBtn.Enabled = False
    WordBtn.Enabled = False
  End Sub
End Class
