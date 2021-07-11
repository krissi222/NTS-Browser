Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.Navigate(Ustawienia.TextBox1.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click
        Form3.Show()
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ProgressBar1_Click_1(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub WebBrowser1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        Try
            ProgressBar1.Value = Convert.ToInt32(e.CurrentProgress)
            ProgressBar1.Maximum = Convert.ToInt32(e.MaximumProgress)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button5.PerformClick()
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Ustawienia.Show()
    End Sub

End Class