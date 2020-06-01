<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Shop))
        Me.pnlTransparency = New System.Windows.Forms.Panel()
        Me.lblDispTitle = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tmrInOut = New System.Windows.Forms.Timer(Me.components)
        Me.gbxShopItems = New System.Windows.Forms.GroupBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.gbxUnitInventory = New System.Windows.Forms.GroupBox()
        Me.pbxInventoryDisp = New System.Windows.Forms.PictureBox()
        Me.pbxDisplay = New System.Windows.Forms.PictureBox()
        Me.iglUpgradeSprites = New System.Windows.Forms.ImageList(Me.components)
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.btnSell = New System.Windows.Forms.Button()
        Me.gbxUnitInventory.SuspendLayout
        CType(Me.pbxInventoryDisp,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbxDisplay,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'pnlTransparency
        '
        Me.pnlTransparency.BackColor = System.Drawing.Color.Red
        Me.pnlTransparency.Location = New System.Drawing.Point(640, 0)
        Me.pnlTransparency.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlTransparency.Name = "pnlTransparency"
        Me.pnlTransparency.Size = New System.Drawing.Size(640, 720)
        Me.pnlTransparency.TabIndex = 1
        '
        'lblDispTitle
        '
        Me.lblDispTitle.AutoSize = true
        Me.lblDispTitle.Font = New System.Drawing.Font("Century Gothic", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDispTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDispTitle.Location = New System.Drawing.Point(36, 23)
        Me.lblDispTitle.Name = "lblDispTitle"
        Me.lblDispTitle.Size = New System.Drawing.Size(340, 37)
        Me.lblDispTitle.TabIndex = 2
        Me.lblDispTitle.Text = "Welcome to the Shop!"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(42,Byte),Integer), CType(CType(42,Byte),Integer), CType(CType(42,Byte),Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnClose.Location = New System.Drawing.Point(502, 23)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(98, 33)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = false
        '
        'tmrInOut
        '
        Me.tmrInOut.Interval = 1
        '
        'gbxShopItems
        '
        Me.gbxShopItems.Font = New System.Drawing.Font("Century Gothic", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbxShopItems.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.gbxShopItems.Location = New System.Drawing.Point(65, 76)
        Me.gbxShopItems.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxShopItems.Name = "gbxShopItems"
        Me.gbxShopItems.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxShopItems.Size = New System.Drawing.Size(517, 436)
        Me.gbxShopItems.TabIndex = 5
        Me.gbxShopItems.TabStop = false
        Me.gbxShopItems.Text = "Units"
        '
        'lblDescription
        '
        Me.lblDescription.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDescription.Location = New System.Drawing.Point(39, 529)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(320, 176)
        Me.lblDescription.TabIndex = 6
        Me.lblDescription.Text = "Click on a shop item for more information!"
        '
        'gbxUnitInventory
        '
        Me.gbxUnitInventory.Controls.Add(Me.pbxInventoryDisp)
        Me.gbxUnitInventory.Font = New System.Drawing.Font("Century Gothic", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbxUnitInventory.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.gbxUnitInventory.Location = New System.Drawing.Point(466, 529)
        Me.gbxUnitInventory.Name = "gbxUnitInventory"
        Me.gbxUnitInventory.Size = New System.Drawing.Size(129, 122)
        Me.gbxUnitInventory.TabIndex = 7
        Me.gbxUnitInventory.TabStop = false
        Me.gbxUnitInventory.Text = "Unit Inventory"
        Me.gbxUnitInventory.Visible = false
        '
        'pbxInventoryDisp
        '
        Me.pbxInventoryDisp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxInventoryDisp.Location = New System.Drawing.Point(22, 26)
        Me.pbxInventoryDisp.Name = "pbxInventoryDisp"
        Me.pbxInventoryDisp.Size = New System.Drawing.Size(80, 80)
        Me.pbxInventoryDisp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxInventoryDisp.TabIndex = 9
        Me.pbxInventoryDisp.TabStop = false
        '
        'pbxDisplay
        '
        Me.pbxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxDisplay.Location = New System.Drawing.Point(378, 555)
        Me.pbxDisplay.Name = "pbxDisplay"
        Me.pbxDisplay.Size = New System.Drawing.Size(80, 80)
        Me.pbxDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxDisplay.TabIndex = 8
        Me.pbxDisplay.TabStop = false
        '
        'iglUpgradeSprites
        '
        Me.iglUpgradeSprites.ImageStream = CType(resources.GetObject("iglUpgradeSprites.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.iglUpgradeSprites.TransparentColor = System.Drawing.Color.White
        Me.iglUpgradeSprites.Images.SetKeyName(0, "DESword.png")
        Me.iglUpgradeSprites.Images.SetKeyName(1, "HPWell.png")
        Me.iglUpgradeSprites.Images.SetKeyName(2, "AMRPLT.png")
        Me.iglUpgradeSprites.Images.SetKeyName(3, "PreIgniter.png")
        Me.iglUpgradeSprites.Images.SetKeyName(4, "Fortitude.png")
        Me.iglUpgradeSprites.Images.SetKeyName(5, "RedBuckler.png")
        Me.iglUpgradeSprites.Images.SetKeyName(6, "OSRTPLT.png")
        Me.iglUpgradeSprites.Images.SetKeyName(7, "CannonPlate.png")
        Me.iglUpgradeSprites.Images.SetKeyName(8, "Talon.png")
        Me.iglUpgradeSprites.Images.SetKeyName(9, "Gatling.png")
        Me.iglUpgradeSprites.Images.SetKeyName(10, "Override.png")
        Me.iglUpgradeSprites.Images.SetKeyName(11, "GoG.png")
        Me.iglUpgradeSprites.Images.SetKeyName(12, "Gauntlet.png")
        Me.iglUpgradeSprites.Images.SetKeyName(13, "Vstaff.png")
        Me.iglUpgradeSprites.Images.SetKeyName(14, "OHO")
        Me.iglUpgradeSprites.Images.SetKeyName(15, "TriForce.png")
        '
        'btnBuy
        '
        Me.btnBuy.BackColor = System.Drawing.Color.FromArgb(CType(CType(42,Byte),Integer), CType(CType(42,Byte),Integer), CType(CType(42,Byte),Integer))
        Me.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuy.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnBuy.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuy.Location = New System.Drawing.Point(378, 673)
        Me.btnBuy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(98, 33)
        Me.btnBuy.TabIndex = 9
        Me.btnBuy.Text = "Buy"
        Me.btnBuy.UseVisualStyleBackColor = false
        Me.btnBuy.Visible = false
        '
        'btnSell
        '
        Me.btnSell.BackColor = System.Drawing.Color.FromArgb(CType(CType(42,Byte),Integer), CType(CType(42,Byte),Integer), CType(CType(42,Byte),Integer))
        Me.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSell.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSell.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSell.Location = New System.Drawing.Point(484, 672)
        Me.btnSell.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSell.Name = "btnSell"
        Me.btnSell.Size = New System.Drawing.Size(98, 33)
        Me.btnSell.TabIndex = 10
        Me.btnSell.Text = "Sell"
        Me.btnSell.UseVisualStyleBackColor = false
        Me.btnSell.Visible = false
        '
        'Shop
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
        Me.CausesValidation = false
        Me.ClientSize = New System.Drawing.Size(640, 720)
        Me.Controls.Add(Me.pnlTransparency)
        Me.Controls.Add(Me.btnSell)
        Me.Controls.Add(Me.btnBuy)
        Me.Controls.Add(Me.pbxDisplay)
        Me.Controls.Add(Me.gbxUnitInventory)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.gbxShopItems)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblDispTitle)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = true
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Shop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shop"
        Me.TopMost = true
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.gbxUnitInventory.ResumeLayout(false)
        CType(Me.pbxInventoryDisp,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbxDisplay,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents pnlTransparency As System.Windows.Forms.Panel
    Friend WithEvents lblDispTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents tmrInOut As System.Windows.Forms.Timer
    Friend WithEvents gbxShopItems As System.Windows.Forms.GroupBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents gbxUnitInventory As System.Windows.Forms.GroupBox
    Friend WithEvents pbxDisplay As System.Windows.Forms.PictureBox
    Friend WithEvents pbxInventoryDisp As System.Windows.Forms.PictureBox
    Friend WithEvents iglUpgradeSprites As System.Windows.Forms.ImageList
    Friend WithEvents btnBuy As System.Windows.Forms.Button
    Friend WithEvents btnSell As System.Windows.Forms.Button
End Class
