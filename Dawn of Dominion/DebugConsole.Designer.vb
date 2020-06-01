<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DebugConsole
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DebugConsole))
        Me.lbxOutput = New System.Windows.Forms.ListBox()
        Me.lblDispTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbxOutput
        '
        Me.lbxOutput.FormattingEnabled = True
        Me.lbxOutput.ItemHeight = 16
        Me.lbxOutput.Items.AddRange(New Object() {"Debug Messages:"})
        Me.lbxOutput.Location = New System.Drawing.Point(12, 40)
        Me.lbxOutput.Name = "lbxOutput"
        Me.lbxOutput.Size = New System.Drawing.Size(404, 292)
        Me.lbxOutput.TabIndex = 0
        '
        'lblDispTitle
        '
        Me.lblDispTitle.AutoSize = True
        Me.lblDispTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblDispTitle.Name = "lblDispTitle"
        Me.lblDispTitle.Size = New System.Drawing.Size(191, 17)
        Me.lblDispTitle.TabIndex = 1
        Me.lblDispTitle.Text = "Welcome the Debug Console"
        '
        'DebugConsole
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(428, 344)
        Me.Controls.Add(Me.lblDispTitle)
        Me.Controls.Add(Me.lbxOutput)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DebugConsole"
        Me.Text = "Debug Console"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbxOutput As System.Windows.Forms.ListBox
    Friend WithEvents lblDispTitle As System.Windows.Forms.Label
End Class
