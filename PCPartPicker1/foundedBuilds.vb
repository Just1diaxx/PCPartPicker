Public Class foundedBuilds
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bCode = InputBox("Enter the build code")
        Form1.webView.CoreWebView2.Navigate("https://pcpartpicker.com/list/" + bCode)
    End Sub
End Class