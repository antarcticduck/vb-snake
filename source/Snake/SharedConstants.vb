' -- Copyright (c) Stuart Garner 2012. All rights reserved. --

Imports System.Collections.ObjectModel

Public NotInheritable Class SharedConstants

    Public Const GameNew As Integer = 3
    Public Const GameResume As Integer = 4
    Public Const GameTimeLength As Integer = 120

    Public Shared ReadOnly GameTips As New ReadOnlyCollection(Of String)({
                            "Press P or Esc to pause and show game menu",
                            "Use the arrow keys to control the snake",
                            "Configure game settings in Options, under the game menu",
                            "Collect the fruit; you score 10 points for each piece",
                            "Don't hit the blue snake",
                            "You can view the local high scores in the game menu",
                            "You can change the tips cycle time under Options in the Game Menu",
                            "For further help, click the Help button in the game menu",
                            "You only have 2 minutes to score",
                            "Hit the edge of the field and see what happens..."})

    Public Shared ReadOnly SnakeMoveUp As Point = New Point(0, -10)
    Public Shared ReadOnly SnakeMoveDown As Point = New Point(0, 10)
    Public Shared ReadOnly SnakeMoveLeft As Point = New Point(-10, 0)
    Public Shared ReadOnly SnakeMoveRight As Point = New Point(10, 0)

    ' Required as static members should not have constructors.
    Private Sub New()
    End Sub

End Class
