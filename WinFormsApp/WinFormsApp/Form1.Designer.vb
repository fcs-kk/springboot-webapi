<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnGet = New System.Windows.Forms.Button()
        Me.btnPost = New System.Windows.Forms.Button()
        Me.btnPut = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtResp = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGet
        '
        Me.btnGet.Location = New System.Drawing.Point(70, 87)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(69, 23)
        Me.btnGet.TabIndex = 0
        Me.btnGet.Text = "GET"
        Me.btnGet.UseVisualStyleBackColor = True
        '
        'btnPost
        '
        Me.btnPost.Location = New System.Drawing.Point(145, 87)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(69, 24)
        Me.btnPost.TabIndex = 1
        Me.btnPost.Text = "POST"
        Me.btnPost.UseVisualStyleBackColor = True
        '
        'btnPut
        '
        Me.btnPut.Location = New System.Drawing.Point(220, 87)
        Me.btnPut.Name = "btnPut"
        Me.btnPut.Size = New System.Drawing.Size(69, 23)
        Me.btnPut.TabIndex = 2
        Me.btnPut.Text = "PUT"
        Me.btnPut.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(295, 87)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(69, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtUrl
        '
        Me.txtUrl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUrl.Location = New System.Drawing.Point(70, 6)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(294, 23)
        Me.txtUrl.TabIndex = 4
        Me.txtUrl.Text = "http://localhost:8080/api/resource/1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "URL:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Resp:"
        '
        'txtResp
        '
        Me.txtResp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResp.Location = New System.Drawing.Point(70, 117)
        Me.txtResp.Multiline = True
        Me.txtResp.Name = "txtResp"
        Me.txtResp.ReadOnly = True
        Me.txtResp.Size = New System.Drawing.Size(294, 45)
        Me.txtResp.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(70, 168)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(69, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtData
        '
        Me.txtData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtData.Location = New System.Drawing.Point(70, 35)
        Me.txtData.Multiline = True
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(294, 46)
        Me.txtData.TabIndex = 9
        Me.txtData.Text = "{""name"":""岩国次郎"",""note"":""広島県人？"",""age"":26,""registerDate"":""1940-04-01T00:00:00""}"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Data:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 199)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtResp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPut)
        Me.Controls.Add(Me.btnPost)
        Me.Controls.Add(Me.btnGet)
        Me.Controls.Add(Me.txtData)
        Me.MinimumSize = New System.Drawing.Size(396, 170)
        Me.Name = "frmMain"
        Me.Text = "WebAPI Caller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGet As Button
    Friend WithEvents btnPost As Button
    Friend WithEvents btnPut As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtUrl As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtResp As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents txtData As TextBox
    Friend WithEvents Label3 As Label
End Class
