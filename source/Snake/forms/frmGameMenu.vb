' -- Copyright (c) Stuart Garner 2012. All rights reserved. --

Public Class frmGameMenu

    ' -- Varibales --

    Dim gameAlreadyRunning As Boolean

    ' -- Class Events --

    Public Sub New(title As String, isAGameAlreadyRunning As Boolean)

        ' Required by the designer.
        InitializeComponent()

        ' Set the Game Menu title to what was sent from the snake attack form.
        lblGameMenuTitle.Text = title

        ' Set gameAlreadyRunning, so that other subs in this class can see if a game is currently running and has been paused.
        gameAlreadyRunning = isAGameAlreadyRunning

        ' If a game is already running, the user can press the Resume button, if not, they cant.
        btnResumeGame.Enabled = gameAlreadyRunning

        ' If a game is already running, the default button is btnResumeGame, if not, btnNewGame is the default button.
        If isAGameAlreadyRunning Then
            Me.AcceptButton = btnResumeGame
            Me.CancelButton = btnResumeGame
        Else
            Me.AcceptButton = btnNewGame
            Me.CancelButton = btnNewGame
        End If

    End Sub

    ' -- Form Events --

    Private Sub frmGameMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        ' If the New Game button and Resume Game button haven't been clicked, and the user is attempting to close the Game Menu, cancel the event.
        If Me.DialogResult <> SharedConstants.GameNew And Me.DialogResult <> SharedConstants.GameResume And e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
        End If

    End Sub

    Private Sub frmGameMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        ' If a game is currently running and the P key is pressed, resume the game.
        If gameAlreadyRunning And e.KeyCode = Keys.P Then
            Me.DialogResult = SharedConstants.GameResume
            Me.Close()
        End If

    End Sub

    ' -- MenuItems --

    Private Sub btnResumeGame_Click(sender As Object, e As EventArgs) Handles btnResumeGame.Click
        Me.DialogResult = SharedConstants.GameResume
        Me.Close()
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click

        ' If a game is currently running, check that the user is happy to loose their current progress, if a game isn't running, just start a new game.
        If gameAlreadyRunning Then
            If MsgBox("Are you sure you want to start a new game?" & vbCrLf & "All current progress will be lost.", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Me.DialogResult = SharedConstants.GameNew
                Me.Close()
            End If
        Else
            Me.DialogResult = SharedConstants.GameNew
            Me.Close()
        End If

    End Sub

    Private Sub btnHighScores_Click(sender As Object, e As EventArgs) Handles btnHighScores.Click
        Dim frm As New frmHighScores
        frm.ShowDialog()
    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        Dim frm As New frmOptions
        frm.ShowDialog()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Dim frm As New frmHelp
        frm.ShowDialog()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim frm As New frmAbout
        frm.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Are you sure you want to exit Snake Attack?" & vbCrLf & "Any unsaved scores will be lost.", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then Application.Exit()
    End Sub

End Class