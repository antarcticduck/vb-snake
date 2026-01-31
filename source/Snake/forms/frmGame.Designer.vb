<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.tmrTips = New System.Windows.Forms.Timer(Me.components)
        Me.pnlField = New System.Windows.Forms.Panel()
        Me.barTips = New System.Windows.Forms.Panel()
        Me.lblTips = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.barGameInfo = New System.Windows.Forms.Panel()
        Me.lblTimeRemaining = New System.Windows.Forms.Label()
        Me.lblComputerScore = New System.Windows.Forms.Label()
        Me.lblHumanScore = New System.Windows.Forms.Label()
        Me.tmrSnakeMover = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTimeRemaining = New System.Windows.Forms.Timer(Me.components)
        Me.barTips.SuspendLayout()
        Me.barGameInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrTips
        '
        '
        'pnlField
        '
        Me.pnlField.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlField.Location = New System.Drawing.Point(0, 25)
        Me.pnlField.Name = "pnlField"
        Me.pnlField.Size = New System.Drawing.Size(560, 380)
        Me.pnlField.TabIndex = 1
        '
        'barTips
        '
        Me.barTips.Controls.Add(Me.lblTips)
        Me.barTips.Controls.Add(Me.lblVersion)
        Me.barTips.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barTips.Location = New System.Drawing.Point(0, 405)
        Me.barTips.Name = "barTips"
        Me.barTips.Size = New System.Drawing.Size(560, 25)
        Me.barTips.TabIndex = 2
        '
        'lblTips
        '
        Me.lblTips.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTips.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTips.Location = New System.Drawing.Point(0, 0)
        Me.lblTips.Name = "lblTips"
        Me.lblTips.Size = New System.Drawing.Size(460, 25)
        Me.lblTips.TabIndex = 1
        Me.lblTips.Text = "Tip: You can turn tips off in Options, under the game menu"
        Me.lblTips.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTips.Visible = False
        '
        'lblVersion
        '
        Me.lblVersion.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lblVersion.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVersion.Location = New System.Drawing.Point(460, 0)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(100, 25)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "Loading..."
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'barGameInfo
        '
        Me.barGameInfo.Controls.Add(Me.lblTimeRemaining)
        Me.barGameInfo.Controls.Add(Me.lblComputerScore)
        Me.barGameInfo.Controls.Add(Me.lblHumanScore)
        Me.barGameInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.barGameInfo.Location = New System.Drawing.Point(0, 0)
        Me.barGameInfo.Name = "barGameInfo"
        Me.barGameInfo.Size = New System.Drawing.Size(560, 25)
        Me.barGameInfo.TabIndex = 3
        '
        'lblTimeRemaining
        '
        Me.lblTimeRemaining.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTimeRemaining.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeRemaining.Location = New System.Drawing.Point(100, 0)
        Me.lblTimeRemaining.Name = "lblTimeRemaining"
        Me.lblTimeRemaining.Size = New System.Drawing.Size(360, 25)
        Me.lblTimeRemaining.TabIndex = 2
        Me.lblTimeRemaining.Text = "Time Remaining: 02:00"
        Me.lblTimeRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComputerScore
        '
        Me.lblComputerScore.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblComputerScore.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputerScore.Location = New System.Drawing.Point(460, 0)
        Me.lblComputerScore.Name = "lblComputerScore"
        Me.lblComputerScore.Size = New System.Drawing.Size(100, 25)
        Me.lblComputerScore.TabIndex = 3
        Me.lblComputerScore.Text = "CPU: 0"
        Me.lblComputerScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHumanScore
        '
        Me.lblHumanScore.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblHumanScore.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHumanScore.Location = New System.Drawing.Point(0, 0)
        Me.lblHumanScore.Name = "lblHumanScore"
        Me.lblHumanScore.Size = New System.Drawing.Size(100, 25)
        Me.lblHumanScore.TabIndex = 1
        Me.lblHumanScore.Text = "You: 0"
        Me.lblHumanScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrSnakeMover
        '
        '
        'tmrTimeRemaining
        '
        Me.tmrTimeRemaining.Interval = 1000
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 430)
        Me.Controls.Add(Me.pnlField)
        Me.Controls.Add(Me.barGameInfo)
        Me.Controls.Add(Me.barTips)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGame"
        Me.Text = "Snake Attack"
        Me.barTips.ResumeLayout(False)
        Me.barGameInfo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrTips As System.Windows.Forms.Timer
    Friend WithEvents pnlField As System.Windows.Forms.Panel
    Friend WithEvents barTips As System.Windows.Forms.Panel
    Friend WithEvents barGameInfo As System.Windows.Forms.Panel
    Friend WithEvents lblTips As System.Windows.Forms.Label
    Friend WithEvents lblTimeRemaining As System.Windows.Forms.Label
    Friend WithEvents lblHumanScore As System.Windows.Forms.Label
    Friend WithEvents tmrSnakeMover As System.Windows.Forms.Timer
    Friend WithEvents tmrTimeRemaining As System.Windows.Forms.Timer
    Friend WithEvents lblComputerScore As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
End Class
