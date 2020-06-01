<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tutorial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tutorial))
        Me.lblDispTitle = New System.Windows.Forms.Label()
        Me.lblTutorialText = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblTutorialTitle = New System.Windows.Forms.Label()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.pbxTutorialImage = New System.Windows.Forms.PictureBox()
        CType(Me.pbxTutorialImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDispTitle
        '
        Me.lblDispTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDispTitle.AutoSize = True
        Me.lblDispTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDispTitle.Font = New System.Drawing.Font("Century Gothic", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDispTitle.Location = New System.Drawing.Point(360, 12)
        Me.lblDispTitle.Name = "lblDispTitle"
        Me.lblDispTitle.Padding = New System.Windows.Forms.Padding(10)
        Me.lblDispTitle.Size = New System.Drawing.Size(602, 71)
        Me.lblDispTitle.TabIndex = 3
        Me.lblDispTitle.Text = "Dawn of Dominion - Guide"
        Me.lblDispTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTutorialText
        '
        Me.lblTutorialText.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTutorialText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTutorialText.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTutorialText.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTutorialText.Location = New System.Drawing.Point(40, 222)
        Me.lblTutorialText.Name = "lblTutorialText"
        Me.lblTutorialText.Padding = New System.Windows.Forms.Padding(20)
        Me.lblTutorialText.Size = New System.Drawing.Size(744, 450)
        Me.lblTutorialText.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnClose.Location = New System.Drawing.Point(12, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(93, 33)
        Me.btnClose.TabIndex = 27
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnNext.Location = New System.Drawing.Point(1061, 638)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(90, 34)
        Me.btnNext.TabIndex = 26
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lblTutorialTitle
        '
        Me.lblTutorialTitle.AutoSize = True
        Me.lblTutorialTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTutorialTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTutorialTitle.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTutorialTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTutorialTitle.Location = New System.Drawing.Point(242, 122)
        Me.lblTutorialTitle.Name = "lblTutorialTitle"
        Me.lblTutorialTitle.Padding = New System.Windows.Forms.Padding(20)
        Me.lblTutorialTitle.Size = New System.Drawing.Size(42, 76)
        Me.lblTutorialTitle.TabIndex = 28
        Me.lblTutorialTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPrev.Location = New System.Drawing.Point(955, 638)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(90, 34)
        Me.btnPrev.TabIndex = 29
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'pbxTutorialImage
        '
        Me.pbxTutorialImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.pbxTutorialImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxTutorialImage.Location = New System.Drawing.Point(790, 222)
        Me.pbxTutorialImage.Name = "pbxTutorialImage"
        Me.pbxTutorialImage.Size = New System.Drawing.Size(461, 316)
        Me.pbxTutorialImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxTutorialImage.TabIndex = 30
        Me.pbxTutorialImage.TabStop = False
        '
        'Tutorial
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BackgroundImage = Global.Dawn_of_Dominion.My.Resources.Resources.Graphic_StaticGlieseNow
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.pbxTutorialImage)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.lblTutorialTitle)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblTutorialText)
        Me.Controls.Add(Me.lblDispTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tutorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tutorial"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.pbxTutorialImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDispTitle As System.Windows.Forms.Label
    Friend WithEvents lblTutorialText As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblTutorialTitle As System.Windows.Forms.Label
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents pbxTutorialImage As System.Windows.Forms.PictureBox
End Class
