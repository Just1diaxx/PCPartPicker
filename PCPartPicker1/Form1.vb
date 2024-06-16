Imports System.IO
Imports System.Text
Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView
Imports DiscordRPC
Imports Microsoft.Web.WebView2.Core
Imports Microsoft.Web.WebView2.WinForms


Public Class Form1

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim build = InputBox("Enter the code of your build (the numbers and letters after https://pcpartpicker.com/list/)")
        Dim name = InputBox("Choose a name for your build")
        Dim path As String = "C:\pcpartpicker\" + build + ".txt"

        ' Create or overwrite the file.
        Dim fs As FileStream = File.Create(path)

        ' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("Build code: " + build + " - " + name)
        fs.Write(info, 0, info.Length)
        fs.Close()

    End Sub

    Private Sub MyForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        webView.Size = Me.Size
    End Sub

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim client As New DiscordRpcClient("1249059443061166101") 'API KEY
        client.Initialize()
        Dim unixtime As ULong = (Date.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
        Dim rpctimestamps As New Timestamps
        rpctimestamps.StartUnixMilliseconds = unixtime

        'Assets
        Dim rpcassets As New Assets
        rpcassets.LargeImageKey = "pcpartpicker"
        rpcassets.SmallImageKey = "pclist"
        rpcassets.LargeImageText = "PCPartPicker"
        rpcassets.SmallImageText = "Choosing parts for a new PC!"

        'Final RPC
        Dim rpc As New RichPresence
        rpc.Details = "https://pcpartpicker.com/list"
        rpc.State = "Build your new PC now with PCPartPicker!"
        rpc.Assets = rpcassets
        rpc.Timestamps = rpctimestamps

        client.SetPresence(rpc)


        If My.Computer.FileSystem.DirectoryExists("C:\pcpartpicker") Then

        Else
            My.Computer.FileSystem.CreateDirectory("C:\pcpartpicker")
        End If





    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each foundFile As String In My.Computer.FileSystem.GetFiles("C:\pcpartpicker")


            Dim fileReader = My.Computer.FileSystem.ReadAllText(foundFile)

            foundedBuilds.ListBox1.Items.Add(fileReader)


        Next
        foundedBuilds.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each foundFile As String In My.Computer.FileSystem.GetFiles("C:\pcpartpicker")


            Dim fileReader = My.Computer.FileSystem.ReadAllText(foundFile)

            foundedBuilds2.ListBox1.Items.Add(fileReader)


        Next
        foundedBuilds2.Show()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Me.BackColor = Color.White Then
            Me.BackColor = Color.Black
            Label1.ForeColor = Color.White
        Else
            Me.BackColor = Color.White
            Label1.ForeColor = Color.Black
        End If

    End Sub
End Class
