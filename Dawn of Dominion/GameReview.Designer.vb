<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameReview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameReview))
        Me.lblDispTitle = New System.Windows.Forms.Label()
        Me.tmrSequencer = New System.Windows.Forms.Timer(Me.components)
        Me.tlpInfo = New System.Windows.Forms.TableLayoutPanel()
        Me.lblStatName = New System.Windows.Forms.Label()
        Me.lbl2PTitle = New System.Windows.Forms.Label()
        Me.lbl1PTitle = New System.Windows.Forms.Label()
        Me.lbl1PInfo = New System.Windows.Forms.Label()
        Me.lbl2PInfo = New System.Windows.Forms.Label()
        Me.btnReturnMenu = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.tlpInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDispTitle
        '
        Me.lblDispTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDispTitle.AutoSize = True
        Me.lblDispTitle.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDispTitle.Location = New System.Drawing.Point(547, 35)
        Me.lblDispTitle.Name = "lblDispTitle"
        Me.lblDispTitle.Size = New System.Drawing.Size(151, 47)
        Me.lblDispTitle.TabIndex = 27
        Me.lblDispTitle.Text = "Results"
        '
        'tmrSequencer
        '
        Me.tmrSequencer.Interval = 600
        '
        'tlpInfo
        '
        Me.tlpInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.tlpInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpInfo.ColumnCount = 3
        Me.tlpInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpInfo.Controls.Add(Me.lblStatName, 0, 1)
        Me.tlpInfo.Controls.Add(Me.lbl2PTitle, 2, 0)
        Me.tlpInfo.Controls.Add(Me.lbl1PTitle, 1, 0)
        Me.tlpInfo.Controls.Add(Me.lbl1PInfo, 1, 1)
        Me.tlpInfo.Controls.Add(Me.lbl2PInfo, 2, 1)
        Me.tlpInfo.Location = New System.Drawing.Point(142, 134)
        Me.tlpInfo.Name = "tlpInfo"
        Me.tlpInfo.RowCount = 2
        Me.tlpInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.tlpInfo.Size = New System.Drawing.Size(951, 449)
        Me.tlpInfo.TabIndex = 28
        '
        'lblStatName
        '
        Me.lblStatName.AutoSize = True
        Me.lblStatName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStatName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblStatName.Location = New System.Drawing.Point(4, 68)
        Me.lblStatName.Name = "lblStatName"
        Me.lblStatName.Size = New System.Drawing.Size(372, 380)
        Me.lblStatName.TabIndex = 4
        '
        'lbl2PTitle
        '
        Me.lbl2PTitle.AutoSize = True
        Me.lbl2PTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl2PTitle.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2PTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl2PTitle.Location = New System.Drawing.Point(668, 1)
        Me.lbl2PTitle.Name = "lbl2PTitle"
        Me.lbl2PTitle.Size = New System.Drawing.Size(279, 66)
        Me.lbl2PTitle.TabIndex = 3
        '
        'lbl1PTitle
        '
        Me.lbl1PTitle.AutoSize = True
        Me.lbl1PTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl1PTitle.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1PTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl1PTitle.Location = New System.Drawing.Point(383, 1)
        Me.lbl1PTitle.Name = "lbl1PTitle"
        Me.lbl1PTitle.Size = New System.Drawing.Size(278, 66)
        Me.lbl1PTitle.TabIndex = 2
        '
        'lbl1PInfo
        '
        Me.lbl1PInfo.AutoSize = True
        Me.lbl1PInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl1PInfo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1PInfo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl1PInfo.Location = New System.Drawing.Point(383, 68)
        Me.lbl1PInfo.Name = "lbl1PInfo"
        Me.lbl1PInfo.Size = New System.Drawing.Size(278, 380)
        Me.lbl1PInfo.TabIndex = 0
        '
        'lbl2PInfo
        '
        Me.lbl2PInfo.AutoSize = True
        Me.lbl2PInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl2PInfo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2PInfo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl2PInfo.Location = New System.Drawing.Point(668, 68)
        Me.lbl2PInfo.Name = "lbl2PInfo"
        Me.lbl2PInfo.Size = New System.Drawing.Size(279, 380)
        Me.lbl2PInfo.TabIndex = 1
        '
        'btnReturnMenu
        '
        Me.btnReturnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnMenu.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnMenu.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReturnMenu.Location = New System.Drawing.Point(12, 12)
        Me.btnReturnMenu.Name = "btnReturnMenu"
        Me.btnReturnMenu.Size = New System.Drawing.Size(93, 33)
        Me.btnReturnMenu.TabIndex = 29
        Me.btnReturnMenu.Text = "Exit"
        Me.btnReturnMenu.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnDone.Enabled = False
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDone.Location = New System.Drawing.Point(579, 609)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(167, 73)
        Me.btnDone.TabIndex = 30
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'GameReview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BackgroundImage = Global.Dawn_of_Dominion.My.Resources.Resources.Graphic_StaticGlieseNow
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnReturnMenu)
        Me.Controls.Add(Me.tlpInfo)
        Me.Controls.Add(Me.lblDispTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GameReview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GameReview"
        Me.tlpInfo.ResumeLayout(False)
        Me.tlpInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDispTitle As System.Windows.Forms.Label
    Friend WithEvents tmrSequencer As System.Windows.Forms.Timer
    Friend WithEvents tlpInfo As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl1PInfo As System.Windows.Forms.Label
    Friend WithEvents lbl2PTitle As System.Windows.Forms.Label
    Friend WithEvents lbl1PTitle As System.Windows.Forms.Label
    Friend WithEvents lbl2PInfo As System.Windows.Forms.Label
    Friend WithEvents btnReturnMenu As System.Windows.Forms.Button
    Friend WithEvents lblStatName As System.Windows.Forms.Label
    Friend WithEvents btnDone As System.Windows.Forms.Button
End Class
