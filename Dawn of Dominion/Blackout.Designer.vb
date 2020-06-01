<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Blackout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Blackout))
        Me.tmrFadeInOut = New System.Windows.Forms.Timer(Me.components)
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblDispPrompt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmrFadeInOut
        '
        Me.tmrFadeInOut.Interval = 1
        '
        'btnNext
        '
        Me.btnNext.Enabled = False
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnNext.Location = New System.Drawing.Point(532, 416)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(151, 86)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblDispPrompt
        '
        Me.lblDispPrompt.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispPrompt.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDispPrompt.Location = New System.Drawing.Point(289, 63)
        Me.lblDispPrompt.Name = "lblDispPrompt"
        Me.lblDispPrompt.Size = New System.Drawing.Size(583, 145)
        Me.lblDispPrompt.TabIndex = 1
        Me.lblDispPrompt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Blackout
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.lblDispPrompt)
        Me.Controls.Add(Me.btnNext)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Blackout"
        Me.Opacity = 0.0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blackout"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrFadeInOut As System.Windows.Forms.Timer
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblDispPrompt As System.Windows.Forms.Label
End Class
