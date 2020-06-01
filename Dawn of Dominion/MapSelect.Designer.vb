<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MapSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MapSelect))
        Me.lblDispTitle = New System.Windows.Forms.Label()
        Me.lblAskName = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.pnlMapPreview = New System.Windows.Forms.Panel()
        Me.btnMapBack = New System.Windows.Forms.Button()
        Me.btnMapFwd = New System.Windows.Forms.Button()
        Me.lblDispRaceTitle = New System.Windows.Forms.Label()
        Me.lblDispMapTitle = New System.Windows.Forms.Label()
        Me.ttpDescription = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlRacePreview = New System.Windows.Forms.Panel()
        Me.lblRaceDesc = New System.Windows.Forms.Label()
        Me.pbxRacePassive = New System.Windows.Forms.PictureBox()
        Me.btnRaceBack = New System.Windows.Forms.Button()
        Me.btnRaceFwd = New System.Windows.Forms.Button()
        Me.btnReturnMenu = New System.Windows.Forms.Button()
        Me.lblMapName = New System.Windows.Forms.Label()
        Me.lblRaceName = New System.Windows.Forms.Label()
        Me.iglRace = New System.Windows.Forms.ImageList(Me.components)
        Me.lblNameQuery = New System.Windows.Forms.Label()
        Me.txtNameInput = New System.Windows.Forms.TextBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.gbx2PlrAdvanced = New System.Windows.Forms.GroupBox()
        Me.lblStartingMoney = New System.Windows.Forms.Label()
        Me.nudStartCash = New System.Windows.Forms.NumericUpDown()
        Me.cbxQuests = New System.Windows.Forms.CheckBox()
        Me.pnlMapPreview.SuspendLayout()
        Me.pnlRacePreview.SuspendLayout()
        CType(Me.pbxRacePassive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx2PlrAdvanced.SuspendLayout()
        CType(Me.nudStartCash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDispTitle
        '
        Me.lblDispTitle.AutoSize = True
        Me.lblDispTitle.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDispTitle.Location = New System.Drawing.Point(289, 31)
        Me.lblDispTitle.Name = "lblDispTitle"
        Me.lblDispTitle.Size = New System.Drawing.Size(898, 56)
        Me.lblDispTitle.TabIndex = 0
        Me.lblDispTitle.Text = "Choose your race and battlegrounds!"
        '
        'lblAskName
        '
        Me.lblAskName.AutoSize = True
        Me.lblAskName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAskName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblAskName.Location = New System.Drawing.Point(512, 103)
        Me.lblAskName.Name = "lblAskName"
        Me.lblAskName.Size = New System.Drawing.Size(401, 30)
        Me.lblAskName.TabIndex = 1
        Me.lblAskName.Text = "Player 2, it is your turn to choose!"
        '
        'btnSubmit
        '
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSubmit.Location = New System.Drawing.Point(617, 609)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(119, 65)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'pnlMapPreview
        '
        Me.pnlMapPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.pnlMapPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMapPreview.Controls.Add(Me.btnMapBack)
        Me.pnlMapPreview.Controls.Add(Me.btnMapFwd)
        Me.pnlMapPreview.Location = New System.Drawing.Point(802, 327)
        Me.pnlMapPreview.Name = "pnlMapPreview"
        Me.pnlMapPreview.Size = New System.Drawing.Size(447, 350)
        Me.pnlMapPreview.TabIndex = 4
        '
        'btnMapBack
        '
        Me.btnMapBack.Enabled = False
        Me.btnMapBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMapBack.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMapBack.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnMapBack.Location = New System.Drawing.Point(0, 0)
        Me.btnMapBack.Name = "btnMapBack"
        Me.btnMapBack.Size = New System.Drawing.Size(43, 350)
        Me.btnMapBack.TabIndex = 1
        Me.btnMapBack.Text = "<"
        Me.btnMapBack.UseVisualStyleBackColor = True
        '
        'btnMapFwd
        '
        Me.btnMapFwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMapFwd.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMapFwd.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnMapFwd.Location = New System.Drawing.Point(404, 0)
        Me.btnMapFwd.Name = "btnMapFwd"
        Me.btnMapFwd.Size = New System.Drawing.Size(43, 347)
        Me.btnMapFwd.TabIndex = 0
        Me.btnMapFwd.Text = ">"
        Me.btnMapFwd.UseVisualStyleBackColor = True
        '
        'lblDispRaceTitle
        '
        Me.lblDispRaceTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDispRaceTitle.AutoSize = True
        Me.lblDispRaceTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDispRaceTitle.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispRaceTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDispRaceTitle.Location = New System.Drawing.Point(122, 238)
        Me.lblDispRaceTitle.Name = "lblDispRaceTitle"
        Me.lblDispRaceTitle.Size = New System.Drawing.Size(85, 34)
        Me.lblDispRaceTitle.TabIndex = 6
        Me.lblDispRaceTitle.Text = "Race"
        '
        'lblDispMapTitle
        '
        Me.lblDispMapTitle.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDispMapTitle.AutoSize = True
        Me.lblDispMapTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDispMapTitle.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispMapTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDispMapTitle.Location = New System.Drawing.Point(1125, 238)
        Me.lblDispMapTitle.Name = "lblDispMapTitle"
        Me.lblDispMapTitle.Size = New System.Drawing.Size(76, 34)
        Me.lblDispMapTitle.TabIndex = 7
        Me.lblDispMapTitle.Text = "Map"
        '
        'pnlRacePreview
        '
        Me.pnlRacePreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.pnlRacePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRacePreview.Controls.Add(Me.lblRaceDesc)
        Me.pnlRacePreview.Controls.Add(Me.pbxRacePassive)
        Me.pnlRacePreview.Controls.Add(Me.btnRaceBack)
        Me.pnlRacePreview.Controls.Add(Me.btnRaceFwd)
        Me.pnlRacePreview.Location = New System.Drawing.Point(45, 327)
        Me.pnlRacePreview.Name = "pnlRacePreview"
        Me.pnlRacePreview.Size = New System.Drawing.Size(516, 347)
        Me.pnlRacePreview.TabIndex = 5
        '
        'lblRaceDesc
        '
        Me.lblRaceDesc.Font = New System.Drawing.Font("Century Gothic", 10.8!)
        Me.lblRaceDesc.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblRaceDesc.Location = New System.Drawing.Point(54, 27)
        Me.lblRaceDesc.Name = "lblRaceDesc"
        Me.lblRaceDesc.Size = New System.Drawing.Size(400, 224)
        Me.lblRaceDesc.TabIndex = 18
        '
        'pbxRacePassive
        '
        Me.pbxRacePassive.Location = New System.Drawing.Point(82, 272)
        Me.pbxRacePassive.Name = "pbxRacePassive"
        Me.pbxRacePassive.Size = New System.Drawing.Size(60, 60)
        Me.pbxRacePassive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxRacePassive.TabIndex = 2
        Me.pbxRacePassive.TabStop = False
        '
        'btnRaceBack
        '
        Me.btnRaceBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRaceBack.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRaceBack.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRaceBack.Location = New System.Drawing.Point(0, 0)
        Me.btnRaceBack.Name = "btnRaceBack"
        Me.btnRaceBack.Size = New System.Drawing.Size(43, 344)
        Me.btnRaceBack.TabIndex = 1
        Me.btnRaceBack.Text = "<"
        Me.btnRaceBack.UseVisualStyleBackColor = True
        '
        'btnRaceFwd
        '
        Me.btnRaceFwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRaceFwd.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRaceFwd.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRaceFwd.Location = New System.Drawing.Point(471, 0)
        Me.btnRaceFwd.Name = "btnRaceFwd"
        Me.btnRaceFwd.Size = New System.Drawing.Size(43, 344)
        Me.btnRaceFwd.TabIndex = 0
        Me.btnRaceFwd.Text = ">"
        Me.btnRaceFwd.UseVisualStyleBackColor = True
        '
        'btnReturnMenu
        '
        Me.btnReturnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnMenu.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnMenu.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReturnMenu.Location = New System.Drawing.Point(12, 12)
        Me.btnReturnMenu.Name = "btnReturnMenu"
        Me.btnReturnMenu.Size = New System.Drawing.Size(93, 33)
        Me.btnReturnMenu.TabIndex = 13
        Me.btnReturnMenu.Text = "Exit"
        Me.btnReturnMenu.UseVisualStyleBackColor = True
        '
        'lblMapName
        '
        Me.lblMapName.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblMapName.BackColor = System.Drawing.Color.Transparent
        Me.lblMapName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMapName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMapName.Location = New System.Drawing.Point(866, 276)
        Me.lblMapName.Name = "lblMapName"
        Me.lblMapName.Size = New System.Drawing.Size(325, 23)
        Me.lblMapName.TabIndex = 16
        Me.lblMapName.Text = "Equanos homeland"
        Me.lblMapName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRaceName
        '
        Me.lblRaceName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRaceName.BackColor = System.Drawing.Color.Transparent
        Me.lblRaceName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaceName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblRaceName.Location = New System.Drawing.Point(123, 276)
        Me.lblRaceName.Name = "lblRaceName"
        Me.lblRaceName.Size = New System.Drawing.Size(195, 23)
        Me.lblRaceName.TabIndex = 17
        Me.lblRaceName.Text = "Equanos"
        '
        'iglRace
        '
        Me.iglRace.ImageStream = CType(resources.GetObject("iglRace.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iglRace.TransparentColor = System.Drawing.Color.White
        Me.iglRace.Images.SetKeyName(0, "Equanos.jpg")
        Me.iglRace.Images.SetKeyName(1, "Elementan.png")
        Me.iglRace.Images.SetKeyName(2, "Infernus.jpg")
        Me.iglRace.Images.SetKeyName(3, "Prisma.jpg")
        Me.iglRace.Images.SetKeyName(4, "Umbra.jpg")
        '
        'lblNameQuery
        '
        Me.lblNameQuery.AutoSize = True
        Me.lblNameQuery.BackColor = System.Drawing.Color.Transparent
        Me.lblNameQuery.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameQuery.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblNameQuery.Location = New System.Drawing.Point(423, 153)
        Me.lblNameQuery.Name = "lblNameQuery"
        Me.lblNameQuery.Size = New System.Drawing.Size(94, 30)
        Me.lblNameQuery.TabIndex = 19
        Me.lblNameQuery.Text = "Name:"
        '
        'txtNameInput
        '
        Me.txtNameInput.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameInput.Location = New System.Drawing.Point(524, 150)
        Me.txtNameInput.MaxLength = 20
        Me.txtNameInput.Name = "txtNameInput"
        Me.txtNameInput.Size = New System.Drawing.Size(321, 37)
        Me.txtNameInput.TabIndex = 18
        '
        'lblInstructions
        '
        Me.lblInstructions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInstructions.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInstructions.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblInstructions.Location = New System.Drawing.Point(578, 373)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Padding = New System.Windows.Forms.Padding(10)
        Me.lblInstructions.Size = New System.Drawing.Size(206, 192)
        Me.lblInstructions.TabIndex = 20
        Me.lblInstructions.Text = "Use the arrows on either side to select your map and race of choice. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Then, lo" & _
    "ck it in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "below." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbx2PlrAdvanced
        '
        Me.gbx2PlrAdvanced.Controls.Add(Me.lblStartingMoney)
        Me.gbx2PlrAdvanced.Controls.Add(Me.nudStartCash)
        Me.gbx2PlrAdvanced.Controls.Add(Me.cbxQuests)
        Me.gbx2PlrAdvanced.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx2PlrAdvanced.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.gbx2PlrAdvanced.Location = New System.Drawing.Point(45, 71)
        Me.gbx2PlrAdvanced.Name = "gbx2PlrAdvanced"
        Me.gbx2PlrAdvanced.Size = New System.Drawing.Size(215, 132)
        Me.gbx2PlrAdvanced.TabIndex = 21
        Me.gbx2PlrAdvanced.TabStop = False
        Me.gbx2PlrAdvanced.Text = "Advanced"
        Me.gbx2PlrAdvanced.Visible = False
        '
        'lblStartingMoney
        '
        Me.lblStartingMoney.Location = New System.Drawing.Point(20, 66)
        Me.lblStartingMoney.Name = "lblStartingMoney"
        Me.lblStartingMoney.Size = New System.Drawing.Size(93, 58)
        Me.lblStartingMoney.TabIndex = 2
        Me.lblStartingMoney.Text = "Starting Money ($)"
        '
        'nudStartCash
        '
        Me.nudStartCash.Increment = New Decimal(New Integer() {250, 0, 0, 0})
        Me.nudStartCash.Location = New System.Drawing.Point(120, 70)
        Me.nudStartCash.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.nudStartCash.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudStartCash.Name = "nudStartCash"
        Me.nudStartCash.Size = New System.Drawing.Size(79, 33)
        Me.nudStartCash.TabIndex = 1
        Me.nudStartCash.ThousandsSeparator = True
        Me.nudStartCash.Value = New Decimal(New Integer() {3000, 0, 0, 0})
        '
        'cbxQuests
        '
        Me.cbxQuests.AutoSize = True
        Me.cbxQuests.Checked = True
        Me.cbxQuests.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxQuests.Location = New System.Drawing.Point(24, 27)
        Me.cbxQuests.Name = "cbxQuests"
        Me.cbxQuests.Size = New System.Drawing.Size(104, 28)
        Me.cbxQuests.TabIndex = 0
        Me.cbxQuests.Text = "Quests"
        Me.cbxQuests.UseVisualStyleBackColor = True
        '
        'MapSelect
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BackgroundImage = Global.Dawn_of_Dominion.My.Resources.Resources.Graphic_StaticGliesePast
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx2PlrAdvanced)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblNameQuery)
        Me.Controls.Add(Me.txtNameInput)
        Me.Controls.Add(Me.lblRaceName)
        Me.Controls.Add(Me.lblMapName)
        Me.Controls.Add(Me.btnReturnMenu)
        Me.Controls.Add(Me.pnlRacePreview)
        Me.Controls.Add(Me.lblDispMapTitle)
        Me.Controls.Add(Me.lblDispRaceTitle)
        Me.Controls.Add(Me.pnlMapPreview)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblAskName)
        Me.Controls.Add(Me.lblDispTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MapSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MapSelect"
        Me.pnlMapPreview.ResumeLayout(False)
        Me.pnlRacePreview.ResumeLayout(False)
        CType(Me.pbxRacePassive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx2PlrAdvanced.ResumeLayout(False)
        Me.gbx2PlrAdvanced.PerformLayout()
        CType(Me.nudStartCash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDispTitle As System.Windows.Forms.Label
    Friend WithEvents lblAskName As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents pnlMapPreview As System.Windows.Forms.Panel
    Friend WithEvents lblDispRaceTitle As System.Windows.Forms.Label
    Friend WithEvents lblDispMapTitle As System.Windows.Forms.Label
    Friend WithEvents ttpDescription As System.Windows.Forms.ToolTip
    Friend WithEvents btnMapBack As System.Windows.Forms.Button
    Friend WithEvents btnMapFwd As System.Windows.Forms.Button
    Friend WithEvents pnlRacePreview As System.Windows.Forms.Panel
    Friend WithEvents btnRaceBack As System.Windows.Forms.Button
    Friend WithEvents btnRaceFwd As System.Windows.Forms.Button
    Friend WithEvents btnReturnMenu As System.Windows.Forms.Button
    Friend WithEvents pbxRacePassive As System.Windows.Forms.PictureBox
    Friend WithEvents lblRaceDesc As System.Windows.Forms.Label
    Friend WithEvents lblMapName As System.Windows.Forms.Label
    Friend WithEvents lblRaceName As System.Windows.Forms.Label
    Friend WithEvents iglRace As System.Windows.Forms.ImageList
    Friend WithEvents lblNameQuery As System.Windows.Forms.Label
    Friend WithEvents txtNameInput As System.Windows.Forms.TextBox
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents gbx2PlrAdvanced As System.Windows.Forms.GroupBox
    Friend WithEvents cbxQuests As System.Windows.Forms.CheckBox
    Friend WithEvents lblStartingMoney As System.Windows.Forms.Label
    Friend WithEvents nudStartCash As System.Windows.Forms.NumericUpDown
End Class
