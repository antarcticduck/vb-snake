' -- Copyright (c) Stuart Garner 2012. All rights reserved. --

Public Class frmGame

#Region "Variables"

    Dim cpuSnake As Snake
    Dim fruit As Fruit
    Dim humanSnake As Snake
    Dim humanSnakeDirection As Point
    Dim rnd As New Random
    Dim timeRemaining As Integer

#End Region

#Region "Form Events"

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set the version label's text.
        lblVersion.Text = "V" & My.Application.Info.Version.ToString

        ' If tips have been enabled by the user, show tips bar and start tips timer to cycle tips.
        If My.Settings.AreTipsEnabled Then
            lblTips.Visible = True
            tmrTips.Interval = My.Settings.TipsCycle * 1000
            tmrTips.Start()
        End If

    End Sub

    Private Sub frmGame_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        ' Show Game Menu with title "welcome", a game is not currently running.
        Dim frm As New frmGameMenu("welcome", False)
        frm.ShowDialog()

        ' If the New Game button clicked, call game_New.
        If frm.DialogResult = SharedConstants.GameNew Then
            game_New()
        End If

    End Sub

    Private Sub frmGame_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        ' If the user is trying to close the form, and the Application.Exit method wasn't called, check that the user definatly wants to exit.
        If e.CloseReason = CloseReason.UserClosing Then

            ' Pause the game but don't show the pause menu.
            game_Pause(False)

            ' If the user clicks Yes, the application exits, if they press No, the close event is cancelled and the game is resumed.
            If MsgBox("Are you sure you want to exit Snake Attack?" & vbCrLf & "Any unsaved scores will be lost.", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Application.Exit()
            Else
                e.Cancel = True
                game_Resume()
            End If

        End If

    End Sub

    Private Sub frmGame_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        ' If the P or Escape key is pressed, pause the game.
        If e.KeyCode = Keys.P Or e.KeyCode = Keys.Escape Then game_Pause()

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        ' NOTE: This is in an Overide Funtion and not the Form KeyDown event because arrow keys
        '       are used to change focus on obejcts in a form. This can and has caused issues
        '       in the past and although I am not 100% happy with this, its better than using
        '       the W, A, S and D keys :)

        ' Changes the direction of the snake, e.g. if the Up key is pressed and the human snake is not moving down, set the humanSnakeDirection variable to up, etc.
        If keyData = Keys.Up And humanSnake.Direction <> SharedConstants.SnakeMoveDown Then
            humanSnakeDirection = SharedConstants.SnakeMoveUp

        ElseIf keyData = Keys.Down And humanSnake.Direction <> SharedConstants.SnakeMoveUp Then
            humanSnakeDirection = SharedConstants.SnakeMoveDown

        ElseIf keyData = Keys.Left And humanSnake.Direction <> SharedConstants.SnakeMoveRight Then
            humanSnakeDirection = SharedConstants.SnakeMoveLeft

        ElseIf keyData = Keys.Right And humanSnake.Direction <> SharedConstants.SnakeMoveLeft Then
            humanSnakeDirection = SharedConstants.SnakeMoveRight

        End If

        ' Returns the same as the ProcessCmdKey usually does.
        Return MyBase.ProcessCmdKey(msg, keyData)

    End Function

#End Region

#Region "Game"

    Private Sub game_New()

        ' Clear the paying field.
        pnlField.Controls.Clear()

        ' Set the time remaining variable.
        timeRemaining = SharedConstants.GameTimeLength

        ' Set the score labels and time remaining label.
        lblComputerScore.Text = "CPU: 0"
        lblHumanScore.Text = "You: 0"
        lblTimeRemaining.Text = "Time Remaining: " & Format(SharedConstants.GameTimeLength \ 60, "00") & ":" & Format(SharedConstants.GameTimeLength Mod 60, "00")

        ' Create the new cpu snake.
        cpuSnake = New Snake
        cpuSnake.Create(pnlField, New Point(10, 10), Color.Blue)
        cpuSnake.Direction = SharedConstants.SnakeMoveRight

        ' Create the human snake.
        humanSnake = New Snake
        humanSnake.Create(pnlField, New Point(pnlField.Width - 20, pnlField.Height - 20), Color.Red)
        humanSnakeDirection = SharedConstants.SnakeMoveLeft

        ' Create the fruit.
        fruit_Create()

        ' Start the snake mover and time remiaing timers.
        tmrSnakeMover.Start()
        tmrTimeRemaining.Start()

    End Sub

    Private Sub game_Pause(Optional ShowPauseMenu As Boolean = True)

        ' Stop the snake mover and time remaining timers.
        tmrSnakeMover.Stop()
        tmrTimeRemaining.Stop()

        ' If show pause menu is true, show the game menu.
        If ShowPauseMenu Then

            Dim frm As New frmGameMenu("game paused", True)
            frm.ShowDialog()

            If frm.DialogResult = SharedConstants.GameResume Then
                game_Resume()
            ElseIf frm.DialogResult = SharedConstants.GameNew Then
                game_New()
            End If

        End If

    End Sub

    Private Sub game_Resume()

        ' Start the snake mover and time remaining timers.
        tmrSnakeMover.Start()
        tmrTimeRemaining.Start()

    End Sub

    Private Sub game_Over()

        ' Get the score of the human snake.
        Dim humanScore As Integer = humanSnake.Score

        ' Stop the snake mover and time remaining timers.
        tmrSnakeMover.Stop()
        tmrTimeRemaining.Stop()

        ' Show the submit score form.
        Dim frmSubmit As New frmSubmitScore(humanScore)
        frmSubmit.ShowDialog()

        ' Show the high scores form.
        Dim frmScores As New frmHighScores
        frmScores.ShowDialog()

        ' Show the game menu.
        Dim frmMenu As New frmGameMenu("game over", False)
        frmMenu.ShowDialog()

        ' If the New Game button was pressed on the game menu, create a new game.
        If frmMenu.DialogResult = SharedConstants.GameNew Then
            game_New()
        End If

    End Sub

    Private Sub tmrTimeRemaining_Tick(sender As Object, e As EventArgs) Handles tmrTimeRemaining.Tick

        ' Subtract 1 from time remaining and set the time remaining label.
        timeRemaining -= 1
        lblTimeRemaining.Text = "Time Remaining: " & Format(timeRemaining \ 60, "00") & ":" & Format(timeRemaining Mod 60, "00")

        ' If there is no time remaining, the game is over.
        If timeRemaining = 0 Then
            game_Over()
        End If

    End Sub

#End Region

#Region "Snakes"

    Private Sub cpuSnake_SetDirection()

        ' Example: If the cpu snake is higher than the fruit and not moving down, move up.
        ' Basically, this applies to each other direction, e.g. if the snake needs to move right and is not moving left, move right, etc.
        ' The snake will be on the correct 'grid' part of the y axis, before it is on the correct part of the x axis.

        If cpuSnake.BodyParts(0).Top > fruit.Top And cpuSnake.Direction <> SharedConstants.SnakeMoveDown Then
            cpuSnake.Direction = SharedConstants.SnakeMoveUp
        ElseIf cpuSnake.BodyParts(0).Top < fruit.Top And cpuSnake.Direction <> SharedConstants.SnakeMoveUp Then
            cpuSnake.Direction = SharedConstants.SnakeMoveDown
        ElseIf cpuSnake.BodyParts(0).Left > fruit.Left And cpuSnake.Direction <> SharedConstants.SnakeMoveRight Then
            cpuSnake.Direction = SharedConstants.SnakeMoveLeft
        ElseIf cpuSnake.BodyParts(0).Left < fruit.Left And cpuSnake.Direction <> SharedConstants.SnakeMoveLeft Then
            cpuSnake.Direction = SharedConstants.SnakeMoveRight
        End If

    End Sub

    Private Sub tmrSnakeMover_Tick(sender As Object, e As EventArgs) Handles tmrSnakeMover.Tick

        ' Set the human snakes direction (doing this here and not in the KeyDown event prevents the user moving the snake into itself if they press two keys within 100m/s)
        humanSnake.Direction = humanSnakeDirection

        ' Move the snakes.
        cpuSnake.Move()
        humanSnake.Move()

        ' Check if there has been a head on collision.
        collision_HeadOn(humanSnake, cpuSnake)

        ' Check if the human snake has had any collisions with other objects.
        collision_EdgeOfField(humanSnake)
        collision_Fruit(humanSnake)
        collision_WithSelf(humanSnake)
        collision_WithSnake(humanSnake, cpuSnake)

        ' Check if the cpu snake has had any collisions with other objects.
        collision_Fruit(cpuSnake)
        collision_EdgeOfField(cpuSnake)
        collision_WithSelf(cpuSnake)
        collision_WithSnake(cpuSnake, humanSnake)

        ' Set the direction of the cpuSnake.
        cpuSnake_SetDirection()

        ' Set the score labels.
        lblComputerScore.Text = "CPU: " & cpuSnake.Score
        lblHumanScore.Text = "You: " & humanSnake.Score

    End Sub

#End Region

#Region "Collisions"

    Private Sub collision_EdgeOfField(snake As Snake)

        ' Moves snake to opposite side, e.g. if the snake has crossed the left side of the field, send it to the right side, etc.

        If snake.BodyParts(0).Left < 0 Then
            snake.BodyParts(0).Left = pnlField.Width - snake.BodyParts(0).Width

        ElseIf snake.BodyParts(0).Right > pnlField.Width Then
            snake.BodyParts(0).Left = 0

        ElseIf snake.BodyParts(0).Top < 0 Then
            snake.BodyParts(0).Top = pnlField.Height - snake.BodyParts(0).Height

        ElseIf snake.BodyParts(0).Bottom > pnlField.Height Then
            snake.BodyParts(0).Top = 0

        End If

    End Sub

    Private Sub collision_Fruit(snake As Snake)

        ' Decide whether the first body part of the snake has touched the fruit.
        If snake.BodyParts(0).Bounds.IntersectsWith(fruit.Bounds) Then

            ' Extend the snake.
            snake.Extend()

            ' Set the snakes score.
            snake.Score += 10

            ' Move the fruit to a new random location.
            fruit_Move()

        End If

    End Sub

    Private Sub collision_HeadOn(snake1 As Snake, snake2 As Snake)

        ' If the snake1 and snake2 have had a head on collision, reset them.
        If snake1.BodyParts(0).Bounds.IntersectsWith(snake2.BodyParts(0).Bounds) Then
            snake1.Reset()
            snake2.Reset()
        End If

    End Sub

    Private Sub collision_WithSelf(snake As Snake)

        ' For each snake body part, exluding the head.
        For i = 1 To snake.BodyParts.GetUpperBound(0)

            ' If the snake head has hit the body part, then reset the snake
            If snake.BodyParts(0).Bounds.IntersectsWith(snake.BodyParts(i).Bounds) Then
                snake.Reset()
                Exit Sub
            End If

        Next

    End Sub

    Private Sub collision_WithSnake(snake As Snake, collidedWith As Snake)

        ' For each snake body part, exluding the head.
        For i = 1 To collidedWith.BodyParts.GetUpperBound(0)

            ' If the snake head has hit the other snakes body part, then reset the snake.
            If snake.BodyParts(0).Bounds.IntersectsWith(collidedWith.BodyParts(i).Bounds) Then
                snake.Reset()
                Exit Sub
            End If

        Next

    End Sub

#End Region

#Region "Fruit"

    Private Sub fruit_Create()

        ' Set the fruit variable to a new Fruit.
        fruit = New Fruit

        ' Set fruit's location.
        fruit_Move()

        ' Add fruit to pnlField.
        pnlField.Controls.Add(fruit)

    End Sub

    Private Sub fruit_Move()

        ' Set the new location of the fruit.
        fruit.Location = New Point(Math.Round(rnd.Next(0, pnlField.Width - fruit.Width) / 10) * 10, Math.Round(rnd.Next(0, pnlField.Height - fruit.Height) / 10) * 10)

    End Sub

#End Region

#Region "Tips"

    Private Sub tmrTips_Tick(sender As Object, e As EventArgs) Handles tmrTips.Tick

        ' Generate a random number to select a tip from the array of tips.
        lblTips.Text = "Tip: " & SharedConstants.GameTips(rnd.Next(0, SharedConstants.GameTips.Count))

    End Sub

#End Region

End Class