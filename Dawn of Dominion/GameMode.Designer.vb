<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameMode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameMode))
        Me.tmrFadeIn = New System.Windows.Forms.Timer(Me.components)
        Me.pnlGrids = New System.Windows.Forms.Panel()
        Me.btnPlace = New System.Windows.Forms.Button()
        Me.btnFire = New System.Windows.Forms.Button()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.btnNextTurn = New System.Windows.Forms.Button()
        Me.lblTurnNumber = New System.Windows.Forms.Label()
        Me.lblControlIndicator = New System.Windows.Forms.Label()
        Me.lblInfoDisp = New System.Windows.Forms.Label()
        Me.lblAllyActives = New System.Windows.Forms.Label()
        Me.iglUnitSprites = New System.Windows.Forms.ImageList(Me.components)
        Me.lblEnemyActives = New System.Windows.Forms.Label()
        Me.lblPhaseIndicate = New System.Windows.Forms.Label()
        Me.btnShop = New System.Windows.Forms.Button()
        Me.btnReturnMenu = New System.Windows.Forms.Button()
        Me.ttpDescription = New System.Windows.Forms.ToolTip(Me.components)
        Me.pbxRaceDisp = New System.Windows.Forms.PictureBox()
        Me.lblIncomeDisp = New System.Windows.Forms.Label()
        Me.btnGuide = New System.Windows.Forms.Button()
        CType(Me.pbxRaceDisp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrFadeIn
        '
        Me.tmrFadeIn.Interval = 1
        '
        'pnlGrids
        '
        Me.pnlGrids.BackColor = System.Drawing.Color.DimGray
        Me.pnlGrids.Location = New System.Drawing.Point(140, 190)
        Me.pnlGrids.Name = "pnlGrids"
        Me.pnlGrids.Size = New System.Drawing.Size(1000, 450)
        Me.pnlGrids.TabIndex = 0
        '
        'btnPlace
        '
        Me.btnPlace.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnPlace.Enabled = False
        Me.btnPlace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlace.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlace.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPlace.Location = New System.Drawing.Point(171, 134)
        Me.btnPlace.Name = "btnPlace"
        Me.btnPlace.Size = New System.Drawing.Size(150, 33)
        Me.btnPlace.TabIndex = 1
        Me.btnPlace.Text = "Done Placing"
        Me.btnPlace.UseVisualStyleBackColor = False
        '
        'btnFire
        '
        Me.btnFire.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnFire.Enabled = False
        Me.btnFire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnFire.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFire.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFire.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnFire.Location = New System.Drawing.Point(751, 134)
        Me.btnFire.Name = "btnFire"
        Me.btnFire.Size = New System.Drawing.Size(98, 33)
        Me.btnFire.TabIndex = 2
        Me.btnFire.Text = "FIRE"
        Me.btnFire.UseVisualStyleBackColor = False
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.BackColor = System.Drawing.Color.Transparent
        Me.lblMoney.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMoney.Location = New System.Drawing.Point(12, 119)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(142, 23)
        Me.lblMoney.TabIndex = 3
        Me.lblMoney.Text = "Money: $3000"
        '
        'btnNextTurn
        '
        Me.btnNextTurn.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnNextTurn.Enabled = False
        Me.btnNextTurn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnNextTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextTurn.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextTurn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnNextTurn.Location = New System.Drawing.Point(892, 134)
        Me.btnNextTurn.Name = "btnNextTurn"
        Me.btnNextTurn.Size = New System.Drawing.Size(98, 33)
        Me.btnNextTurn.TabIndex = 4
        Me.btnNextTurn.Text = "Next Turn"
        Me.btnNextTurn.UseVisualStyleBackColor = False
        '
        'lblTurnNumber
        '
        Me.lblTurnNumber.AutoSize = True
        Me.lblTurnNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblTurnNumber.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurnNumber.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTurnNumber.Location = New System.Drawing.Point(12, 61)
        Me.lblTurnNumber.Name = "lblTurnNumber"
        Me.lblTurnNumber.Size = New System.Drawing.Size(65, 23)
        Me.lblTurnNumber.TabIndex = 5
        Me.lblTurnNumber.Text = "Turn 1"
        '
        'lblControlIndicator
        '
        Me.lblControlIndicator.AutoSize = True
        Me.lblControlIndicator.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControlIndicator.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblControlIndicator.Location = New System.Drawing.Point(209, 31)
        Me.lblControlIndicator.Name = "lblControlIndicator"
        Me.lblControlIndicator.Size = New System.Drawing.Size(144, 23)
        Me.lblControlIndicator.TabIndex = 6
        Me.lblControlIndicator.Text = "Player 1's Turn"
        '
        'lblInfoDisp
        '
        Me.lblInfoDisp.BackColor = System.Drawing.Color.Transparent
        Me.lblInfoDisp.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoDisp.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblInfoDisp.Location = New System.Drawing.Point(718, 60)
        Me.lblInfoDisp.Name = "lblInfoDisp"
        Me.lblInfoDisp.Size = New System.Drawing.Size(412, 71)
        Me.lblInfoDisp.TabIndex = 7
        Me.lblInfoDisp.Text = "Message"
        '
        'lblAllyActives
        '
        Me.lblAllyActives.AutoSize = True
        Me.lblAllyActives.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllyActives.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblAllyActives.Location = New System.Drawing.Point(11, 190)
        Me.lblAllyActives.Name = "lblAllyActives"
        Me.lblAllyActives.Size = New System.Drawing.Size(121, 21)
        Me.lblAllyActives.TabIndex = 8
        Me.lblAllyActives.Text = "Active Units: 0"
        '
        'iglUnitSprites
        '
        Me.iglUnitSprites.ImageStream = CType(resources.GetObject("iglUnitSprites.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iglUnitSprites.TransparentColor = System.Drawing.Color.White
        Me.iglUnitSprites.Images.SetKeyName(0, "EquanosTank.png")
        Me.iglUnitSprites.Images.SetKeyName(1, "ElementanTank.png")
        Me.iglUnitSprites.Images.SetKeyName(2, "InfernusTank.png")
        Me.iglUnitSprites.Images.SetKeyName(3, "PrismaTank.png")
        Me.iglUnitSprites.Images.SetKeyName(4, "UmbraTank.png")
        Me.iglUnitSprites.Images.SetKeyName(5, "Void Swarm.png")
        Me.iglUnitSprites.Images.SetKeyName(6, "Surface Missile Battery.png")
        Me.iglUnitSprites.Images.SetKeyName(7, "Equanos Howitzer.png")
        Me.iglUnitSprites.Images.SetKeyName(8, "EquanosShip.png")
        Me.iglUnitSprites.Images.SetKeyName(9, "ElementanShip.png")
        Me.iglUnitSprites.Images.SetKeyName(10, "InfernusShip.png")
        Me.iglUnitSprites.Images.SetKeyName(11, "ElementanSub.png")
        Me.iglUnitSprites.Images.SetKeyName(12, "Prisma Heli.png")
        Me.iglUnitSprites.Images.SetKeyName(13, "Prisma Jet.png")
        Me.iglUnitSprites.Images.SetKeyName(14, "Infernus Jet.png")
        Me.iglUnitSprites.Images.SetKeyName(15, "Elementan Air Fortress.png")
        '
        'lblEnemyActives
        '
        Me.lblEnemyActives.AutoSize = True
        Me.lblEnemyActives.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemyActives.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblEnemyActives.Location = New System.Drawing.Point(1146, 190)
        Me.lblEnemyActives.Name = "lblEnemyActives"
        Me.lblEnemyActives.Size = New System.Drawing.Size(121, 21)
        Me.lblEnemyActives.TabIndex = 9
        Me.lblEnemyActives.Text = "Active Units: 0"
        '
        'lblPhaseIndicate
        '
        Me.lblPhaseIndicate.AutoSize = True
        Me.lblPhaseIndicate.BackColor = System.Drawing.Color.Transparent
        Me.lblPhaseIndicate.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhaseIndicate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPhaseIndicate.Location = New System.Drawing.Point(12, 89)
        Me.lblPhaseIndicate.Name = "lblPhaseIndicate"
        Me.lblPhaseIndicate.Size = New System.Drawing.Size(131, 23)
        Me.lblPhaseIndicate.TabIndex = 10
        Me.lblPhaseIndicate.Text = "Setup Phase"
        '
        'btnShop
        '
        Me.btnShop.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnShop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShop.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShop.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnShop.Location = New System.Drawing.Point(1142, 23)
        Me.btnShop.Name = "btnShop"
        Me.btnShop.Size = New System.Drawing.Size(98, 33)
        Me.btnShop.TabIndex = 11
        Me.btnShop.Text = "Shop"
        Me.btnShop.UseVisualStyleBackColor = False
        '
        'btnReturnMenu
        '
        Me.btnReturnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnReturnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnReturnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnMenu.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnMenu.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReturnMenu.Location = New System.Drawing.Point(15, 12)
        Me.btnReturnMenu.Name = "btnReturnMenu"
        Me.btnReturnMenu.Size = New System.Drawing.Size(93, 33)
        Me.btnReturnMenu.TabIndex = 12
        Me.btnReturnMenu.Text = "Exit"
        Me.btnReturnMenu.UseVisualStyleBackColor = False
        '
        'ttpDescription
        '
        Me.ttpDescription.AutoPopDelay = 5000
        Me.ttpDescription.InitialDelay = 500
        Me.ttpDescription.ReshowDelay = 1000
        '
        'pbxRaceDisp
        '
        Me.pbxRaceDisp.Location = New System.Drawing.Point(36, 307)
        Me.pbxRaceDisp.Name = "pbxRaceDisp"
        Me.pbxRaceDisp.Size = New System.Drawing.Size(40, 40)
        Me.pbxRaceDisp.TabIndex = 15
        Me.pbxRaceDisp.TabStop = False
        '
        'lblIncomeDisp
        '
        Me.lblIncomeDisp.AutoSize = True
        Me.lblIncomeDisp.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncomeDisp.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblIncomeDisp.Location = New System.Drawing.Point(718, 27)
        Me.lblIncomeDisp.Name = "lblIncomeDisp"
        Me.lblIncomeDisp.Size = New System.Drawing.Size(161, 21)
        Me.lblIncomeDisp.TabIndex = 16
        Me.lblIncomeDisp.Text = "Income Per Turn: $0"
        '
        'btnGuide
        '
        Me.btnGuide.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnGuide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuide.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuide.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuide.Location = New System.Drawing.Point(209, 81)
        Me.btnGuide.Name = "btnGuide"
        Me.btnGuide.Size = New System.Drawing.Size(93, 33)
        Me.btnGuide.TabIndex = 17
        Me.btnGuide.Text = "Guide"
        Me.btnGuide.UseVisualStyleBackColor = False
        '
        'GameMode
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BackgroundImage = Global.Dawn_of_Dominion.My.Resources.Resources.Graphic_StaticGlieseNow
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.btnGuide)
        Me.Controls.Add(Me.lblIncomeDisp)
        Me.Controls.Add(Me.pbxRaceDisp)
        Me.Controls.Add(Me.btnReturnMenu)
        Me.Controls.Add(Me.lblAllyActives)
        Me.Controls.Add(Me.btnShop)
        Me.Controls.Add(Me.lblPhaseIndicate)
        Me.Controls.Add(Me.lblControlIndicator)
        Me.Controls.Add(Me.lblEnemyActives)
        Me.Controls.Add(Me.lblInfoDisp)
        Me.Controls.Add(Me.lblTurnNumber)
        Me.Controls.Add(Me.btnNextTurn)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.btnFire)
        Me.Controls.Add(Me.btnPlace)
        Me.Controls.Add(Me.pnlGrids)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GameMode"
        Me.Opacity = 0.0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GameMode"
        CType(Me.pbxRaceDisp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrFadeIn As System.Windows.Forms.Timer
    Friend WithEvents pnlGrids As System.Windows.Forms.Panel
    Friend WithEvents btnPlace As System.Windows.Forms.Button
    Friend WithEvents btnFire As System.Windows.Forms.Button
    Friend WithEvents lblMoney As System.Windows.Forms.Label
    Friend WithEvents btnNextTurn As System.Windows.Forms.Button
    Friend WithEvents lblTurnNumber As System.Windows.Forms.Label
    Friend WithEvents lblControlIndicator As System.Windows.Forms.Label
    Friend WithEvents lblInfoDisp As System.Windows.Forms.Label
    Friend WithEvents lblAllyActives As System.Windows.Forms.Label
    Friend WithEvents iglUnitSprites As System.Windows.Forms.ImageList
    Friend WithEvents lblEnemyActives As System.Windows.Forms.Label
    Friend WithEvents lblPhaseIndicate As System.Windows.Forms.Label
    Friend WithEvents btnShop As System.Windows.Forms.Button
    Friend WithEvents btnReturnMenu As System.Windows.Forms.Button
    Friend WithEvents ttpDescription As System.Windows.Forms.ToolTip
    Friend WithEvents pbxRaceDisp As System.Windows.Forms.PictureBox
    Friend WithEvents lblIncomeDisp As System.Windows.Forms.Label
    Friend WithEvents btnGuide As System.Windows.Forms.Button
End Class
