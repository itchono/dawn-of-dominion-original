<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPlayerIntro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SPlayerIntro))
        Me.lblNameQuery = New System.Windows.Forms.Label()
        Me.txtNameInput = New System.Windows.Forms.TextBox()
        Me.lblStoryText = New System.Windows.Forms.Label()
        Me.tmrTextIn = New System.Windows.Forms.Timer(Me.components)
        Me.btnSubmitName = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.pnlName = New System.Windows.Forms.Panel()
        Me.btnSkip = New System.Windows.Forms.Button()
        Me.btnReturnMenu = New System.Windows.Forms.Button()
        Me.lblDispTitle = New System.Windows.Forms.Label()
        Me.pbxStory = New System.Windows.Forms.PictureBox()
        Me.pnlName.SuspendLayout()
        CType(Me.pbxStory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNameQuery
        '
        Me.lblNameQuery.AutoSize = True
        Me.lblNameQuery.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameQuery.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblNameQuery.Location = New System.Drawing.Point(19, 30)
        Me.lblNameQuery.Name = "lblNameQuery"
        Me.lblNameQuery.Size = New System.Drawing.Size(76, 23)
        Me.lblNameQuery.TabIndex = 17
        Me.lblNameQuery.Text = "Name:"
        '
        'txtNameInput
        '
        Me.txtNameInput.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameInput.Location = New System.Drawing.Point(101, 27)
        Me.txtNameInput.MaxLength = 20
        Me.txtNameInput.Name = "txtNameInput"
        Me.txtNameInput.Size = New System.Drawing.Size(282, 32)
        Me.txtNameInput.TabIndex = 16
        '
        'lblStoryText
        '
        Me.lblStoryText.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblStoryText.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStoryText.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblStoryText.Location = New System.Drawing.Point(170, 518)
        Me.lblStoryText.Name = "lblStoryText"
        Me.lblStoryText.Padding = New System.Windows.Forms.Padding(20)
        Me.lblStoryText.Size = New System.Drawing.Size(940, 175)
        Me.lblStoryText.TabIndex = 18
        '
        'tmrTextIn
        '
        Me.tmrTextIn.Interval = 10
        '
        'btnSubmitName
        '
        Me.btnSubmitName.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnSubmitName.Enabled = False
        Me.btnSubmitName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitName.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSubmitName.Location = New System.Drawing.Point(401, 30)
        Me.btnSubmitName.Name = "btnSubmitName"
        Me.btnSubmitName.Size = New System.Drawing.Size(72, 31)
        Me.btnSubmitName.TabIndex = 19
        Me.btnSubmitName.Text = "Submit"
        Me.btnSubmitName.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnNext.Enabled = False
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnNext.Location = New System.Drawing.Point(997, 650)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(90, 34)
        Me.btnNext.TabIndex = 21
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'pnlName
        '
        Me.pnlName.Controls.Add(Me.txtNameInput)
        Me.pnlName.Controls.Add(Me.lblNameQuery)
        Me.pnlName.Controls.Add(Me.btnSubmitName)
        Me.pnlName.Location = New System.Drawing.Point(186, 600)
        Me.pnlName.Name = "pnlName"
        Me.pnlName.Size = New System.Drawing.Size(496, 84)
        Me.pnlName.TabIndex = 22
        Me.pnlName.Visible = False
        '
        'btnSkip
        '
        Me.btnSkip.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSkip.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSkip.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSkip.Location = New System.Drawing.Point(880, 650)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(90, 34)
        Me.btnSkip.TabIndex = 23
        Me.btnSkip.Text = "Skip Intro"
        Me.btnSkip.UseVisualStyleBackColor = False
        '
        'btnReturnMenu
        '
        Me.btnReturnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnMenu.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnMenu.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReturnMenu.Location = New System.Drawing.Point(12, 12)
        Me.btnReturnMenu.Name = "btnReturnMenu"
        Me.btnReturnMenu.Size = New System.Drawing.Size(93, 33)
        Me.btnReturnMenu.TabIndex = 25
        Me.btnReturnMenu.Text = "Exit"
        Me.btnReturnMenu.UseVisualStyleBackColor = True
        '
        'lblDispTitle
        '
        Me.lblDispTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDispTitle.AutoSize = True
        Me.lblDispTitle.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDispTitle.Location = New System.Drawing.Point(579, 23)
        Me.lblDispTitle.Name = "lblDispTitle"
        Me.lblDispTitle.Size = New System.Drawing.Size(103, 47)
        Me.lblDispTitle.TabIndex = 26
        Me.lblDispTitle.Text = "Lore"
        '
        'pbxStory
        '
        Me.pbxStory.Image = Global.Dawn_of_Dominion.My.Resources.Resources.Graphic_LandScape
        Me.pbxStory.Location = New System.Drawing.Point(140, 100)
        Me.pbxStory.Name = "pbxStory"
        Me.pbxStory.Size = New System.Drawing.Size(1000, 400)
        Me.pbxStory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxStory.TabIndex = 24
        Me.pbxStory.TabStop = False
        '
        'SPlayerIntro
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.lblDispTitle)
        Me.Controls.Add(Me.btnReturnMenu)
        Me.Controls.Add(Me.pbxStory)
        Me.Controls.Add(Me.btnSkip)
        Me.Controls.Add(Me.pnlName)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblStoryText)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SPlayerIntro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NameInput"
        Me.pnlName.ResumeLayout(False)
        Me.pnlName.PerformLayout()
        CType(Me.pbxStory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNameQuery As System.Windows.Forms.Label
    Friend WithEvents txtNameInput As System.Windows.Forms.TextBox
    Friend WithEvents lblStoryText As System.Windows.Forms.Label
    Friend WithEvents tmrTextIn As System.Windows.Forms.Timer
    Friend WithEvents btnSubmitName As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents pnlName As System.Windows.Forms.Panel
    Friend WithEvents btnSkip As System.Windows.Forms.Button
    Friend WithEvents pbxStory As System.Windows.Forms.PictureBox
    Friend WithEvents btnReturnMenu As System.Windows.Forms.Button
    Friend WithEvents lblDispTitle As System.Windows.Forms.Label
End Class
