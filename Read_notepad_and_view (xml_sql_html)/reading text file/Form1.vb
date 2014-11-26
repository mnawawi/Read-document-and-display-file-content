

Public Class Form1

  Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    RichTextBox1.Clear()
    TextBox1.Text = ""
  End Sub



  Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


    If (TextBox1.Text = "") Then
      OpenFileDialog1.ShowDialog()
      RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)

    ElseIf System.IO.File.Exists(TextBox1.Text) = True Then

      Dim objreader As New System.IO.StreamReader(TextBox1.Text)
      RichTextBox1.Text = objreader.ReadToEnd
      objreader.Close()

    Else
      MessageBox.Show("File not exist")
    End If
  End Sub

  Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

  End Sub
End Class

