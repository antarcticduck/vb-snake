' -- Copyright (c) Stuart Garner 2012. All rights reserved. --

Public Class frmSubmitScore

    ' -- Class Events --

    Public Sub New(score As Integer)

        ' Required by the designer.
        InitializeComponent()

        ' Set the score label to the score sent from the snake attack form.
        lblScore.Text = score

    End Sub

    ' -- Form Buttons --

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        ' If no name has been entered into the Name text box, alert user and exit sub.
        If txtName.Text = "" Then
            MsgBox("Please enter your name.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        ' If this is the first score to be added to My.Settings.HighScores, add name and score to My.Settings.HighScores.
        If My.Settings.HighScores.Count = 0 Then
            My.Settings.HighScores.Add(lblScore.Text & "," & txtName.Text)
        Else

            ' Add high score to appropriate index in My.Settings.HighScores
            For Each item As String In My.Settings.HighScores

                Dim itemDetails As String() = Split(item, ",")

                ' If the score is larger than the current item's score in My.Settings.HighScores, then add the score and name before that item.
                If CInt(lblScore.Text) >= itemDetails(0) Then
                    My.Settings.HighScores.Insert(My.Settings.HighScores.IndexOf(item), lblScore.Text & "," & txtName.Text)
                    Exit For
                End If

                'If this is the last item in My.Settings.HighScores then add the score and name to the end of My.Settings.HighScore.
                If My.Settings.HighScores.IndexOf(item) = My.Settings.HighScores.Count - 1 Then
                    My.Settings.HighScores.Add(lblScore.Text & "," & txtName.Text)
                    Exit For
                End If

            Next

        End If

        My.Settings.Save()

        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        ' Check if the user is sure they don't want to submit their score, if they click Yes, close the form.
        If MsgBox("Are you sure you don't want to submit your score to the high scores board?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub

End Class