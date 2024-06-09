Public Class foundedBuilds2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim buildC = InputBox("Enter the build code of the build you want to delete")
        My.Computer.FileSystem.DeleteFile("C:\pcpartpicker\" + buildC + ".txt")
    End Sub
End Class