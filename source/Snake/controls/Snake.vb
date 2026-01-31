' -- Copyright (c) Stuart Garner 2012. All rights reserved. --

Public Class Snake
    Inherits Control

    ' -- Variables --

    Dim bodyColor As Color
    Dim initialPosition As Point

    Public BodyParts(0) As SnakeBodyPart
    Public Direction As Point
    Public Score As Integer

    ' -- Class Events --

    Public Sub Create(field As Control, location As Point, snakeColor As Color)

        ' Set the Parent to the field variable, the bodyColor to the snake color variable and the intial location of the snake.
        Me.Parent = field
        bodyColor = snakeColor
        initialPosition = location

        ' Add new snake body part to body parts array.
        BodyParts(0) = New SnakeBodyPart(bodyColor)

        ' Set the location of the new snake body part.
        BodyParts(0).Location = initialPosition

        ' Add body part to parent.
        Parent.Controls.Add(BodyParts(0))

        ' Extend snake with 3 body parts.
        Extend(3)

    End Sub

    Public Sub Extend(Optional numberOfBodyParts As Integer = 1)

        ' Extend snake by number of body parts specified when calling this sub, default is 1.
        For i = 1 To numberOfBodyParts

            ' Add the new snake body part to the body parts array.
            ReDim Preserve BodyParts(BodyParts.GetUpperBound(0) + 1)
            BodyParts(BodyParts.GetUpperBound(0)) = New SnakeBodyPart(bodyColor)

            ' Set the location of the new snake body part.
            BodyParts(BodyParts.GetUpperBound(0)).Location = BodyParts(BodyParts.GetUpperBound(0) - 1).Location

            ' Add body part to parent.
            Parent.Controls.Add(BodyParts(BodyParts.GetUpperBound(0)))

        Next

    End Sub

    Public Shadows Sub Move()

        ' Moving the last body part first, set the body part to the same position as that of the next body part.
        For i = BodyParts.GetUpperBound(0) To 1 Step -1
            BodyParts(i).Location = BodyParts(i - 1).Location
        Next

        ' Move the first body part of the snake in the direction specified by the current direction variable.
        BodyParts(0).Location += Direction

    End Sub

    Public Sub Reset()

        ' For each body part after the 1st body part, dispose of it.
        For i = 1 To BodyParts.GetUpperBound(0)
            BodyParts(i).Dispose()
        Next

        ' Reset the body parts array to 0 (1 body part).
        ReDim Preserve BodyParts(0)

        ' Set the location of the new snake body part.
        BodyParts(0).Location = initialPosition

        ' Extend snake with 3 body parts.
        Extend(3)

        ' Reset the score.
        Score = 0

    End Sub

End Class
