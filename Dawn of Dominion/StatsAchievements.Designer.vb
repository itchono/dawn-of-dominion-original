<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatsAchievements
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StatsAchievements))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tclStatsAch = New System.Windows.Forms.TabControl()
        Me.tpgStats = New System.Windows.Forms.TabPage()
        Me.lblStats = New System.Windows.Forms.Label()
        Me.tpgAchievements = New System.Windows.Forms.TabPage()
        Me.lblAchievementsDispTitle = New System.Windows.Forms.Label()
        Me.lblDispTitle = New System.Windows.Forms.Label()
        Me.tclStatsAch.SuspendLayout()
        Me.tpgStats.SuspendLayout()
        Me.tpgAchievements.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnClose.Location = New System.Drawing.Point(12, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(93, 33)
        Me.btnClose.TabIndex = 28
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'tclStatsAch
        '
        Me.tclStatsAch.Controls.Add(Me.tpgStats)
        Me.tclStatsAch.Controls.Add(Me.tpgAchievements)
        Me.tclStatsAch.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tclStatsAch.Location = New System.Drawing.Point(182, 113)
        Me.tclStatsAch.Name = "tclStatsAch"
        Me.tclStatsAch.SelectedIndex = 0
        Me.tclStatsAch.Size = New System.Drawing.Size(895, 531)
        Me.tclStatsAch.TabIndex = 29
        '
        'tpgStats
        '
        Me.tpgStats.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.tpgStats.Controls.Add(Me.lblStats)
        Me.tpgStats.Location = New System.Drawing.Point(4, 30)
        Me.tpgStats.Name = "tpgStats"
        Me.tpgStats.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgStats.Size = New System.Drawing.Size(887, 497)
        Me.tpgStats.TabIndex = 0
        Me.tpgStats.Text = "Stats"
        '
        'lblStats
        '
        Me.lblStats.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStats.AutoSize = True
        Me.lblStats.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStats.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblStats.Location = New System.Drawing.Point(16, 17)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(73, 28)
        Me.lblStats.TabIndex = 31
        Me.lblStats.Text = "Stats:"
        '
        'tpgAchievements
        '
        Me.tpgAchievements.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.tpgAchievements.Controls.Add(Me.lblAchievementsDispTitle)
        Me.tpgAchievements.Location = New System.Drawing.Point(4, 30)
        Me.tpgAchievements.Name = "tpgAchievements"
        Me.tpgAchievements.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgAchievements.Size = New System.Drawing.Size(887, 497)
        Me.tpgAchievements.TabIndex = 1
        Me.tpgAchievements.Text = "Achievements"
        '
        'lblAchievementsDispTitle
        '
        Me.lblAchievementsDispTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAchievementsDispTitle.AutoSize = True
        Me.lblAchievementsDispTitle.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAchievementsDispTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblAchievementsDispTitle.Location = New System.Drawing.Point(15, 14)
        Me.lblAchievementsDispTitle.Name = "lblAchievementsDispTitle"
        Me.lblAchievementsDispTitle.Size = New System.Drawing.Size(192, 28)
        Me.lblAchievementsDispTitle.TabIndex = 32
        Me.lblAchievementsDispTitle.Text = "Achievements:"
        '
        'lblDispTitle
        '
        Me.lblDispTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDispTitle.AutoSize = True
        Me.lblDispTitle.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDispTitle.Location = New System.Drawing.Point(394, 29)
        Me.lblDispTitle.Name = "lblDispTitle"
        Me.lblDispTitle.Size = New System.Drawing.Size(489, 47)
        Me.lblDispTitle.TabIndex = 30
        Me.lblDispTitle.Text = "Stats and Achievements"
        '
        'StatsAchievements
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BackgroundImage = Global.Dawn_of_Dominion.My.Resources.Resources.Graphic_StaticGlieseNow
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.lblDispTitle)
        Me.Controls.Add(Me.tclStatsAch)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StatsAchievements"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StatsAchievements"
        Me.tclStatsAch.ResumeLayout(False)
        Me.tpgStats.ResumeLayout(False)
        Me.tpgStats.PerformLayout()
        Me.tpgAchievements.ResumeLayout(False)
        Me.tpgAchievements.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents tclStatsAch As System.Windows.Forms.TabControl
    Friend WithEvents tpgStats As System.Windows.Forms.TabPage
    Friend WithEvents tpgAchievements As System.Windows.Forms.TabPage
    Friend WithEvents lblDispTitle As System.Windows.Forms.Label
    Friend WithEvents lblStats As System.Windows.Forms.Label
    Friend WithEvents lblAchievementsDispTitle As System.Windows.Forms.Label
End Class
