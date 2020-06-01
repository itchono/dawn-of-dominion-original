<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cutscene
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cutscene))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.rctBackGround = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.tmrTransition = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTextIn = New System.Windows.Forms.Timer(Me.components)
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblText = New System.Windows.Forms.Label()
        Me.btnSkip = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rctBackGround})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1280, 720)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'rctBackGround
        '
        Me.rctBackGround.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.rctBackGround.Location = New System.Drawing.Point(-1, -1)
        Me.rctBackGround.Name = "rctBackGround"
        Me.rctBackGround.Size = New System.Drawing.Size(1279, 720)
        '
        'tmrTransition
        '
        Me.tmrTransition.Interval = 50
        '
        'tmrTextIn
        '
        Me.tmrTextIn.Interval = 20
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnNext.Enabled = False
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnNext.Location = New System.Drawing.Point(625, 610)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(143, 71)
        Me.btnNext.TabIndex = 22
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lblText
        '
        Me.lblText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblText.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblText.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblText.Location = New System.Drawing.Point(140, 190)
        Me.lblText.Name = "lblText"
        Me.lblText.Padding = New System.Windows.Forms.Padding(10)
        Me.lblText.Size = New System.Drawing.Size(1000, 250)
        Me.lblText.TabIndex = 23
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSkip
        '
        Me.btnSkip.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSkip.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSkip.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSkip.Location = New System.Drawing.Point(467, 610)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(143, 71)
        Me.btnSkip.TabIndex = 24
        Me.btnSkip.Text = "Skip"
        Me.btnSkip.UseVisualStyleBackColor = False
        '
        'Cutscene
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.btnSkip)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cutscene"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cutscene"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents rctBackGround As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents tmrTransition As System.Windows.Forms.Timer
    Friend WithEvents tmrTextIn As System.Windows.Forms.Timer
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents btnSkip As System.Windows.Forms.Button
End Class
