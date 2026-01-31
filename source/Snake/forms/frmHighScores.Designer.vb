<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighScores
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
        Me.pnlFormButtons = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lstHighScores = New System.Windows.Forms.ListBox()
        Me.pnlFormButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFormButtons
        '
        Me.pnlFormButtons.BackColor = System.Drawing.SystemColors.Control
        Me.pnlFormButtons.Controls.Add(Me.btnClose)
        Me.pnlFormButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFormButtons.Location = New System.Drawing.Point(0, 212)
        Me.pnlFormButtons.Name = "pnlFormButtons"
        Me.pnlFormButtons.Size = New System.Drawing.Size(339, 47)
        Me.pnlFormButtons.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(252, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lstHighScores
        '
        Me.lstHighScores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstHighScores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstHighScores.FormattingEnabled = True
        Me.lstHighScores.Location = New System.Drawing.Point(0, 0)
        Me.lstHighScores.Name = "lstHighScores"
        Me.lstHighScores.Size = New System.Drawing.Size(339, 212)
        Me.lstHighScores.TabIndex = 5
        '
        'frmHighScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(339, 259)
        Me.Controls.Add(Me.lstHighScores)
        Me.Controls.Add(Me.pnlFormButtons)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHighScores"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "High Scores"
        Me.pnlFormButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlFormButtons As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lstHighScores As System.Windows.Forms.ListBox
End Class
