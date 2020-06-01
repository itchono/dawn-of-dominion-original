<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.btn2Player = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.tmrFadeIn = New System.Windows.Forms.Timer(Me.components)
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnSinglePlayer = New System.Windows.Forms.Button()
        Me.btnGuide = New System.Windows.Forms.Button()
        Me.btnStatAch = New System.Windows.Forms.Button()
        Me.pbxTitle = New System.Windows.Forms.PictureBox()
        Me.pbxMenuAnimation = New System.Windows.Forms.PictureBox()
        CType(Me.pbxTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMenuAnimation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn2Player
        '
        Me.btn2Player.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn2Player.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2Player.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2Player.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn2Player.Location = New System.Drawing.Point(1024, 365)
        Me.btn2Player.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn2Player.Name = "btn2Player"
        Me.btn2Player.Size = New System.Drawing.Size(178, 53)
        Me.btn2Player.TabIndex = 2
        Me.btn2Player.TabStop = False
        Me.btn2Player.Text = "2 - Player"
        Me.btn2Player.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnQuit.Location = New System.Drawing.Point(1022, 634)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(178, 53)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.TabStop = False
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'tmrFadeIn
        '
        Me.tmrFadeIn.Interval = 1
        '
        'btnOptions
        '
        Me.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOptions.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOptions.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnOptions.Location = New System.Drawing.Point(1022, 550)
        Me.btnOptions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(177, 53)
        Me.btnOptions.TabIndex = 5
        Me.btnOptions.TabStop = False
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'btnSinglePlayer
        '
        Me.btnSinglePlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSinglePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSinglePlayer.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSinglePlayer.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSinglePlayer.Location = New System.Drawing.Point(1023, 304)
        Me.btnSinglePlayer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSinglePlayer.Name = "btnSinglePlayer"
        Me.btnSinglePlayer.Size = New System.Drawing.Size(179, 53)
        Me.btnSinglePlayer.TabIndex = 6
        Me.btnSinglePlayer.TabStop = False
        Me.btnSinglePlayer.Text = "Singleplayer"
        Me.btnSinglePlayer.UseVisualStyleBackColor = True
        '
        'btnGuide
        '
        Me.btnGuide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuide.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuide.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuide.Location = New System.Drawing.Point(1022, 225)
        Me.btnGuide.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGuide.Name = "btnGuide"
        Me.btnGuide.Size = New System.Drawing.Size(179, 53)
        Me.btnGuide.TabIndex = 7
        Me.btnGuide.TabStop = False
        Me.btnGuide.Text = "How to Play"
        Me.btnGuide.UseVisualStyleBackColor = True
        '
        'btnStatAch
        '
        Me.btnStatAch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnStatAch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatAch.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatAch.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnStatAch.Location = New System.Drawing.Point(1023, 452)
        Me.btnStatAch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnStatAch.Name = "btnStatAch"
        Me.btnStatAch.Size = New System.Drawing.Size(177, 90)
        Me.btnStatAch.TabIndex = 8
        Me.btnStatAch.TabStop = False
        Me.btnStatAch.Text = "Stats and Achievements"
        Me.btnStatAch.UseVisualStyleBackColor = True
        '
        'pbxTitle
        '
        Me.pbxTitle.Image = Global.Dawn_of_Dominion.My.Resources.Resources.Graphic_Title
        Me.pbxTitle.Location = New System.Drawing.Point(991, 33)
        Me.pbxTitle.Name = "pbxTitle"
        Me.pbxTitle.Size = New System.Drawing.Size(250, 141)
        Me.pbxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxTitle.TabIndex = 9
        Me.pbxTitle.TabStop = False
        '
        'pbxMenuAnimation
        '
        Me.pbxMenuAnimation.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.pbxMenuAnimation.Image = Global.Dawn_of_Dominion.My.Resources.Resources.Graphic_StaticGlieseNow
        Me.pbxMenuAnimation.Location = New System.Drawing.Point(0, 0)
        Me.pbxMenuAnimation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pbxMenuAnimation.Name = "pbxMenuAnimation"
        Me.pbxMenuAnimation.Size = New System.Drawing.Size(950, 720)
        Me.pbxMenuAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxMenuAnimation.TabIndex = 0
        Me.pbxMenuAnimation.TabStop = False
        '
        'MainMenu
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.pbxTitle)
        Me.Controls.Add(Me.btnStatAch)
        Me.Controls.Add(Me.btnGuide)
        Me.Controls.Add(Me.btnSinglePlayer)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btn2Player)
        Me.Controls.Add(Me.pbxMenuAnimation)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainMenu"
        Me.Opacity = 0.0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dawn of Dominion"
        CType(Me.pbxTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMenuAnimation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbxMenuAnimation As System.Windows.Forms.PictureBox
    Friend WithEvents btn2Player As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents tmrFadeIn As System.Windows.Forms.Timer
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents btnSinglePlayer As System.Windows.Forms.Button
    Friend WithEvents btnGuide As System.Windows.Forms.Button
    Friend WithEvents btnStatAch As System.Windows.Forms.Button
    Friend WithEvents pbxTitle As System.Windows.Forms.PictureBox

End Class
