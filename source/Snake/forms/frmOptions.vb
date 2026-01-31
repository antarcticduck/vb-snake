' -- Copyright (c) Stuart Garner 2012. All rights reserved. --

Public Class frmOptions

    ' -- Form Events --

    Private Sub frmOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Get settings and set up form appropriatly.
        chkTipsShowTips.Checked = My.Settings.AreTipsEnabled
        cboTipsCycle.Text = My.Settings.TipsCycle

    End Sub

    ' -- Form Buttons --

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        ' Set and save all of the options.
        My.Settings.AreTipsEnabled = chkTipsShowTips.Checked
        My.Settings.TipsCycle = cboTipsCycle.Text
        My.Settings.Save()
        Me.Close()

        ' Change frmGame to comply with the new modified options
        frmGame.lblTips.Visible = My.Settings.AreTipsEnabled
        frmGame.tmrTips.Interval = My.Settings.TipsCycle * 1000

        If My.Settings.AreTipsEnabled Then
            frmGame.tmrTips.Start()
        Else
            frmGame.tmrTips.Stop()
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ' -- Options --

    Private Sub chkTipsShowTips_CheckedChanged(sender As Object, e As EventArgs) Handles chkTipsShowTips.CheckedChanged
        cboTipsCycle.Enabled = chkTipsShowTips.Checked
    End Sub

    Private Sub bthHighScoresResetHighScores_Click(sender As Object, e As EventArgs) Handles bthHighScoresResetHighScores.Click

        ' Ask if the user is sure they want to clear the high scores, if Yes, then clear high scores.
        If MsgBox("Are you sure you want to reset all high scores?" & vbCrLf & "This action cannot be undone.", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            My.Settings.HighScores.Clear()
            My.Settings.Save()
        End If

    End Sub

    Private Sub btnGameResetEverything_Click(sender As Object, e As EventArgs) Handles btnGameResetEverything.Click

        ' Ask if the user is sure they want to reset the options and highscores, if Yes then reset options and high scores.
        If MsgBox("Are you sure you want to reset Snake Attack?" & vbCrLf & "This will reset all high scores and options." & vbCrLf & "This action cannot be undone.", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            chkTipsShowTips.Checked = True
            cboTipsCycle.Text = 20
            My.Settings.HighScores.Clear()
            My.Settings.Save()
        End If

    End Sub

End Class