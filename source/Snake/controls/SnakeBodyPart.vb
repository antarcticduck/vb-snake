' -- Copyright (c) Stuart Garner 2012. All rights reserved. --

Public Class SnakeBodyPart
    Inherits PictureBox

    Sub New(snakeColor As Color)
        With Me
            .Height = 10
            .Width = 10
            .BackColor = snakeColor
            .BorderStyle = BorderStyle.FixedSingle
        End With
    End Sub

End Class
