' -- Copyright (c) Stuart Garner 2012. All rights reserved. --

Public Class frmHighScores

    ' -- Form Events --

    Private Sub frmHighScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Populate lstHighScores with each item in My.Settings.HighScores in format: "{rank}. {name}: {score}".
        For Each item As String In My.Settings.HighScores

            Dim itemDetails As String() = Split(item, ",")

            lstHighScores.Items.Add(lstHighScores.Items.Count + 1 & ". " & itemDetails(1) & ": " & itemDetails(0))

        Next

    End Sub

    ' -- Form Buttons --

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class