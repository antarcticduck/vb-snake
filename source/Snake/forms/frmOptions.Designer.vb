<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Me.grpTips = New System.Windows.Forms.GroupBox()
        Me.lblTipsSeconds = New System.Windows.Forms.Label()
        Me.cboTipsCycle = New System.Windows.Forms.ComboBox()
        Me.chkTipsShowTips = New System.Windows.Forms.CheckBox()
        Me.grpHighScores = New System.Windows.Forms.GroupBox()
        Me.bthHighScoresResetHighScores = New System.Windows.Forms.Button()
        Me.grpGame = New System.Windows.Forms.GroupBox()
        Me.btnGameResetEverything = New System.Windows.Forms.Button()
        Me.pnlFormButtons = New System.Windows.Forms.Panel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpTips.SuspendLayout()
        Me.grpHighScores.SuspendLayout()
        Me.grpGame.SuspendLayout()
        Me.pnlFormButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTips
        '
        Me.grpTips.Controls.Add(Me.lblTipsSeconds)
        Me.grpTips.Controls.Add(Me.cboTipsCycle)
        Me.grpTips.Controls.Add(Me.chkTipsShowTips)
        Me.grpTips.Location = New System.Drawing.Point(12, 12)
        Me.grpTips.Name = "grpTips"
        Me.grpTips.Size = New System.Drawing.Size(343, 46)
        Me.grpTips.TabIndex = 0
        Me.grpTips.TabStop = False
        Me.grpTips.Text = "Tips"
        '
        'lblTipsSeconds
        '
        Me.lblTipsSeconds.AutoSize = True
        Me.lblTipsSeconds.Location = New System.Drawing.Point(253, 22)
        Me.lblTipsSeconds.Name = "lblTipsSeconds"
        Me.lblTipsSeconds.Size = New System.Drawing.Size(49, 13)
        Me.lblTipsSeconds.TabIndex = 3
        Me.lblTipsSeconds.Text = "seconds"
        '
        'cboTipsCycle
        '
        Me.cboTipsCycle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipsCycle.FormattingEnabled = True
        Me.cboTipsCycle.Items.AddRange(New Object() {"10", "20", "40", "60", "120"})
        Me.cboTipsCycle.Location = New System.Drawing.Point(168, 19)
        Me.cboTipsCycle.Name = "cboTipsCycle"
        Me.cboTipsCycle.Size = New System.Drawing.Size(79, 21)
        Me.cboTipsCycle.TabIndex = 2
        '
        'chkTipsShowTips
        '
        Me.chkTipsShowTips.AutoSize = True
        Me.chkTipsShowTips.Checked = True
        Me.chkTipsShowTips.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTipsShowTips.Location = New System.Drawing.Point(6, 21)
        Me.chkTipsShowTips.Name = "chkTipsShowTips"
        Me.chkTipsShowTips.Size = New System.Drawing.Size(156, 17)
        Me.chkTipsShowTips.TabIndex = 1
        Me.chkTipsShowTips.Text = "Show &tips and cycle every"
        Me.chkTipsShowTips.UseVisualStyleBackColor = True
        '
        'grpHighScores
        '
        Me.grpHighScores.Controls.Add(Me.bthHighScoresResetHighScores)
        Me.grpHighScores.Location = New System.Drawing.Point(12, 64)
        Me.grpHighScores.Name = "grpHighScores"
        Me.grpHighScores.Size = New System.Drawing.Size(343, 48)
        Me.grpHighScores.TabIndex = 1
        Me.grpHighScores.TabStop = False
        Me.grpHighScores.Text = "High Scores"
        '
        'bthHighScoresResetHighScores
        '
        Me.bthHighScoresResetHighScores.Location = New System.Drawing.Point(6, 19)
        Me.bthHighScoresResetHighScores.Name = "bthHighScoresResetHighScores"
        Me.bthHighScoresResetHighScores.Size = New System.Drawing.Size(120, 23)
        Me.bthHighScoresResetHighScores.TabIndex = 3
        Me.bthHighScoresResetHighScores.Text = "Reset &High Scores..."
        Me.bthHighScoresResetHighScores.UseVisualStyleBackColor = True
        '
        'grpGame
        '
        Me.grpGame.Controls.Add(Me.btnGameResetEverything)
        Me.grpGame.Location = New System.Drawing.Point(12, 118)
        Me.grpGame.Name = "grpGame"
        Me.grpGame.Size = New System.Drawing.Size(343, 48)
        Me.grpGame.TabIndex = 2
        Me.grpGame.TabStop = False
        Me.grpGame.Text = "Game"
        '
        'btnGameResetEverything
        '
        Me.btnGameResetEverything.Location = New System.Drawing.Point(6, 19)
        Me.btnGameResetEverything.Name = "btnGameResetEverything"
        Me.btnGameResetEverything.Size = New System.Drawing.Size(120, 23)
        Me.btnGameResetEverything.TabIndex = 4
        Me.btnGameResetEverything.Text = "&Reset Everything..."
        Me.btnGameResetEverything.UseVisualStyleBackColor = True
        '
        'pnlFormButtons
        '
        Me.pnlFormButtons.BackColor = System.Drawing.SystemColors.Control
        Me.pnlFormButtons.Controls.Add(Me.btnOK)
        Me.pnlFormButtons.Controls.Add(Me.btnCancel)
        Me.pnlFormButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFormButtons.Location = New System.Drawing.Point(0, 178)
        Me.pnlFormButtons.Name = "pnlFormButtons"
        Me.pnlFormButtons.Size = New System.Drawing.Size(367, 47)
        Me.pnlFormButtons.TabIndex = 3
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(199, 12)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(280, 12)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmOptions
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(367, 225)
        Me.Controls.Add(Me.pnlFormButtons)
        Me.Controls.Add(Me.grpGame)
        Me.Controls.Add(Me.grpHighScores)
        Me.Controls.Add(Me.grpTips)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptions"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Options"
        Me.grpTips.ResumeLayout(False)
        Me.grpTips.PerformLayout()
        Me.grpHighScores.ResumeLayout(False)
        Me.grpGame.ResumeLayout(False)
        Me.pnlFormButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpTips As System.Windows.Forms.GroupBox
    Friend WithEvents cboTipsCycle As System.Windows.Forms.ComboBox
    Friend WithEvents chkTipsShowTips As System.Windows.Forms.CheckBox
    Friend WithEvents grpHighScores As System.Windows.Forms.GroupBox
    Friend WithEvents bthHighScoresResetHighScores As System.Windows.Forms.Button
    Friend WithEvents grpGame As System.Windows.Forms.GroupBox
    Friend WithEvents btnGameResetEverything As System.Windows.Forms.Button
    Friend WithEvents pnlFormButtons As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblTipsSeconds As System.Windows.Forms.Label
End Class
