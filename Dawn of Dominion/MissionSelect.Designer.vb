<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MissionSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MissionSelect))
        Me.lblDispTitle = New System.Windows.Forms.Label()
        Me.btnReturnMenu = New System.Windows.Forms.Button()
        Me.pnlMissions = New System.Windows.Forms.Panel()
        Me.lblMissionInfo = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnAdvancedAI = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDispTitle
        '
        Me.lblDispTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDispTitle.AutoSize = True
        Me.lblDispTitle.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblDispTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDispTitle.Location = New System.Drawing.Point(441, 26)
        Me.lblDispTitle.Name = "lblDispTitle"
        Me.lblDispTitle.Size = New System.Drawing.Size(393, 47)
        Me.lblDispTitle.TabIndex = 0
        Me.lblDispTitle.Text = "Select Your Mission"
        '
        'btnReturnMenu
        '
        Me.btnReturnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnMenu.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnMenu.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReturnMenu.Location = New System.Drawing.Point(12, 12)
        Me.btnReturnMenu.Name = "btnReturnMenu"
        Me.btnReturnMenu.Size = New System.Drawing.Size(93, 33)
        Me.btnReturnMenu.TabIndex = 26
        Me.btnReturnMenu.TabStop = False
        Me.btnReturnMenu.Text = "Exit"
        Me.btnReturnMenu.UseVisualStyleBackColor = True
        '
        'pnlMissions
        '
        Me.pnlMissions.BackColor = System.Drawing.Color.Transparent
        Me.pnlMissions.Location = New System.Drawing.Point(287, 167)
        Me.pnlMissions.Name = "pnlMissions"
        Me.pnlMissions.Size = New System.Drawing.Size(675, 274)
        Me.pnlMissions.TabIndex = 27
        '
        'lblMissionInfo
        '
        Me.lblMissionInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblMissionInfo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMissionInfo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMissionInfo.Location = New System.Drawing.Point(231, 478)
        Me.lblMissionInfo.Name = "lblMissionInfo"
        Me.lblMissionInfo.Padding = New System.Windows.Forms.Padding(20)
        Me.lblMissionInfo.Size = New System.Drawing.Size(759, 183)
        Me.lblMissionInfo.TabIndex = 28
        Me.lblMissionInfo.Text = "Click on a mission for more information!"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnStart.Enabled = False
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnStart.Location = New System.Drawing.Point(809, 578)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(167, 73)
        Me.btnStart.TabIndex = 29
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnAdvancedAI
        '
        Me.btnAdvancedAI.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnAdvancedAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdvancedAI.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdvancedAI.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAdvancedAI.Location = New System.Drawing.Point(1005, 258)
        Me.btnAdvancedAI.Name = "btnAdvancedAI"
        Me.btnAdvancedAI.Size = New System.Drawing.Size(167, 73)
        Me.btnAdvancedAI.TabIndex = 30
        Me.btnAdvancedAI.Text = "Secret: Advanced AI "
        Me.btnAdvancedAI.UseVisualStyleBackColor = False
        Me.btnAdvancedAI.Visible = False
        '
        'MissionSelect
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BackgroundImage = Global.Dawn_of_Dominion.My.Resources.Resources.Graphic_WarScape1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1276, 720)
        Me.Controls.Add(Me.btnAdvancedAI)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblMissionInfo)
        Me.Controls.Add(Me.pnlMissions)
        Me.Controls.Add(Me.btnReturnMenu)
        Me.Controls.Add(Me.lblDispTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MissionSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MissionSelect"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDispTitle As System.Windows.Forms.Label
    Friend WithEvents btnReturnMenu As System.Windows.Forms.Button
    Friend WithEvents pnlMissions As System.Windows.Forms.Panel
    Friend WithEvents lblMissionInfo As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnAdvancedAI As System.Windows.Forms.Button
End Class
