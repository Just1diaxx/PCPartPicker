<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.webView = New Microsoft.Web.WebView2.WinForms.WebView2()
        CType(Me.webView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Save a configuration"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(343, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Load a configuration"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(170, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Delete a configuration"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'webView
        '
        Me.webView.AllowExternalDrop = True
        Me.webView.CreationProperties = Nothing
        Me.webView.DefaultBackgroundColor = System.Drawing.Color.White
        Me.webView.Location = New System.Drawing.Point(0, 61)
        Me.webView.Name = "webView"
        Me.webView.Size = New System.Drawing.Size(1920, 976)
        Me.webView.Source = New System.Uri("https://pcpartpicker.com/list", System.UriKind.Absolute)
        Me.webView.TabIndex = 5
        Me.webView.ZoomFactor = 1.0R
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1041)
        Me.Controls.Add(Me.webView)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "PCPartPicker"
        CType(Me.webView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents webView As Microsoft.Web.WebView2.WinForms.WebView2
End Class
