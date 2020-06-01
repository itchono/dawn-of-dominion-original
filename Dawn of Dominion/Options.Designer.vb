<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.cbxSound = New System.Windows.Forms.CheckBox()
        Me.cbxDevCheat = New System.Windows.Forms.CheckBox()
        Me.ttpDescription = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnResetSave = New System.Windows.Forms.Button()
        Me.cbxAnimations = New System.Windows.Forms.CheckBox()
        Me.btnResetStats = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblCredits = New System.Windows.Forms.Label()
        Me.tmrFade = New System.Windows.Forms.Timer(Me.components)
        Me.pnlTransparency = New System.Windows.Forms.Panel()
        Me.lblFadeSpdDisp = New System.Windows.Forms.Label()
        Me.nudFadeSpeed = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudFadeSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxSound
        '
        Me.cbxSound.AutoSize = True
        Me.cbxSound.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSound.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cbxSound.Location = New System.Drawing.Point(34, 29)
        Me.cbxSound.Name = "cbxSound"
        Me.cbxSound.Size = New System.Drawing.Size(91, 25)
        Me.cbxSound.TabIndex = 0
        Me.cbxSound.Text = "Sound"
        Me.ttpDescription.SetToolTip(Me.cbxSound, "Enable or Disable Sound.")
        Me.cbxSound.UseVisualStyleBackColor = True
        '
        'cbxDevCheat
        '
        Me.cbxDevCheat.AutoSize = True
        Me.cbxDevCheat.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDevCheat.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cbxDevCheat.Location = New System.Drawing.Point(34, 142)
        Me.cbxDevCheat.Name = "cbxDevCheat"
        Me.cbxDevCheat.Size = New System.Drawing.Size(195, 25)
        Me.cbxDevCheat.TabIndex = 1
        Me.cbxDevCheat.Text = "Dev Testing Mode"
        Me.ttpDescription.SetToolTip(Me.cbxDevCheat, "Enables the devcheat option.")
        Me.cbxDevCheat.UseVisualStyleBackColor = True
        '
        'ttpDescription
        '
        Me.ttpDescription.ToolTipTitle = "Option"
        '
        'btnResetSave
        '
        Me.btnResetSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetSave.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetSave.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnResetSave.Location = New System.Drawing.Point(34, 189)
        Me.btnResetSave.Name = "btnResetSave"
        Me.btnResetSave.Size = New System.Drawing.Size(129, 37)
        Me.btnResetSave.TabIndex = 2
        Me.btnResetSave.Text = "Reset Save"
        Me.ttpDescription.SetToolTip(Me.btnResetSave, "Resets your singleplayer progress.")
        Me.btnResetSave.UseVisualStyleBackColor = True
        '
        'cbxAnimations
        '
        Me.cbxAnimations.AutoSize = True
        Me.cbxAnimations.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAnimations.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cbxAnimations.Location = New System.Drawing.Point(34, 58)
        Me.cbxAnimations.Name = "cbxAnimations"
        Me.cbxAnimations.Size = New System.Drawing.Size(134, 25)
        Me.cbxAnimations.TabIndex = 6
        Me.cbxAnimations.Text = "Animations"
        Me.ttpDescription.SetToolTip(Me.cbxAnimations, "Enable or Disable animations in the game. Disabling will improve performance on s" & _
        "low systems.")
        Me.cbxAnimations.UseVisualStyleBackColor = True
        '
        'btnResetStats
        '
        Me.btnResetStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetStats.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetStats.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnResetStats.Location = New System.Drawing.Point(180, 189)
        Me.btnResetStats.Name = "btnResetStats"
        Me.btnResetStats.Size = New System.Drawing.Size(129, 37)
        Me.btnResetStats.TabIndex = 16
        Me.btnResetStats.Text = "Reset Stats"
        Me.ttpDescription.SetToolTip(Me.btnResetStats, "Resets your singleplayer progress.")
        Me.btnResetStats.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnClose.Location = New System.Drawing.Point(207, 15)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(111, 37)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblCredits
        '
        Me.lblCredits.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredits.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblCredits.Location = New System.Drawing.Point(30, 246)
        Me.lblCredits.Name = "lblCredits"
        Me.lblCredits.Size = New System.Drawing.Size(288, 452)
        Me.lblCredits.TabIndex = 3
        Me.lblCredits.Text = resources.GetString("lblCredits.Text")
        '
        'tmrFade
        '
        Me.tmrFade.Interval = 1
        '
        'pnlTransparency
        '
        Me.pnlTransparency.BackColor = System.Drawing.Color.Red
        Me.pnlTransparency.Location = New System.Drawing.Point(330, 0)
        Me.pnlTransparency.Name = "pnlTransparency"
        Me.pnlTransparency.Size = New System.Drawing.Size(330, 720)
        Me.pnlTransparency.TabIndex = 5
        '
        'lblFadeSpdDisp
        '
        Me.lblFadeSpdDisp.AutoSize = True
        Me.lblFadeSpdDisp.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFadeSpdDisp.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblFadeSpdDisp.Location = New System.Drawing.Point(30, 105)
        Me.lblFadeSpdDisp.Name = "lblFadeSpdDisp"
        Me.lblFadeSpdDisp.Size = New System.Drawing.Size(148, 21)
        Me.lblFadeSpdDisp.TabIndex = 15
        Me.lblFadeSpdDisp.Text = "Fade Speed (%)"
        '
        'nudFadeSpeed
        '
        Me.nudFadeSpeed.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudFadeSpeed.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudFadeSpeed.Location = New System.Drawing.Point(159, 103)
        Me.nudFadeSpeed.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
        Me.nudFadeSpeed.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudFadeSpeed.Name = "nudFadeSpeed"
        Me.nudFadeSpeed.Size = New System.Drawing.Size(74, 30)
        Me.nudFadeSpeed.TabIndex = 14
        Me.nudFadeSpeed.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Options
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(330, 720)
        Me.Controls.Add(Me.pnlTransparency)
        Me.Controls.Add(Me.btnResetStats)
        Me.Controls.Add(Me.lblFadeSpdDisp)
        Me.Controls.Add(Me.nudFadeSpeed)
        Me.Controls.Add(Me.cbxAnimations)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblCredits)
        Me.Controls.Add(Me.btnResetSave)
        Me.Controls.Add(Me.cbxDevCheat)
        Me.Controls.Add(Me.cbxSound)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.TransparencyKey = System.Drawing.Color.Red
        CType(Me.nudFadeSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxSound As System.Windows.Forms.CheckBox
    Friend WithEvents cbxDevCheat As System.Windows.Forms.CheckBox
    Friend WithEvents ttpDescription As System.Windows.Forms.ToolTip
    Friend WithEvents btnResetSave As System.Windows.Forms.Button
    Friend WithEvents lblCredits As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents tmrFade As System.Windows.Forms.Timer
    Friend WithEvents pnlTransparency As System.Windows.Forms.Panel
    Friend WithEvents cbxAnimations As System.Windows.Forms.CheckBox
    Friend WithEvents lblFadeSpdDisp As System.Windows.Forms.Label
    Friend WithEvents nudFadeSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnResetStats As System.Windows.Forms.Button
End Class
