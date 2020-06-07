<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IntroSplash
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IntroSplash))
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblCourseCode = New System.Windows.Forms.Label()
        Me.lblBldVersion = New System.Windows.Forms.Label()
        Me.tmrFade = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.BackColor = System.Drawing.Color.Transparent
        Me.lblAuthor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblAuthor.Location = New System.Drawing.Point(12, 105)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(233, 23)
        Me.lblAuthor.TabIndex = 0
        Me.lblAuthor.Text = "A game by Mingde Yin"
        '
        'lblCourseCode
        '
        Me.lblCourseCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourseCode.AutoSize = True
        Me.lblCourseCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCourseCode.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseCode.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblCourseCode.Location = New System.Drawing.Point(12, 268)
        Me.lblCourseCode.Name = "lblCourseCode"
        Me.lblCourseCode.Size = New System.Drawing.Size(177, 23)
        Me.lblCourseCode.TabIndex = 1
        Me.lblCourseCode.Text = "ICS2O-02 2016-17"
        '
        'lblBldVersion
        '
        Me.lblBldVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBldVersion.AutoSize = True
        Me.lblBldVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblBldVersion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBldVersion.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBldVersion.Location = New System.Drawing.Point(12, 141)
        Me.lblBldVersion.Name = "lblBldVersion"
        Me.lblBldVersion.Size = New System.Drawing.Size(179, 115)
        Me.lblBldVersion.TabIndex = 2
        Me.lblBldVersion.Text = "2020/06/07" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Public Re-release" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tmrFade
        '
        Me.tmrFade.Interval = 1
        '
        'IntroSplash
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BackgroundImage = Global.Dawn_of_Dominion.My.Resources.Resources.Graphic_StaticGlieseNow
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(400, 300)
        Me.Controls.Add(Me.lblBldVersion)
        Me.Controls.Add(Me.lblCourseCode)
        Me.Controls.Add(Me.lblAuthor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IntroSplash"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IntroSplash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents lblCourseCode As System.Windows.Forms.Label
    Friend WithEvents lblBldVersion As System.Windows.Forms.Label
    Friend WithEvents tmrFade As System.Windows.Forms.Timer
End Class
