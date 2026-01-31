' -- Copyright (c) Stuart Garner 2012. All rights reserved. --

Public Class frmHelp

    ' -- Form Events --

    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Load the help HTML page form the resources into the web browser.
        webHelp.DocumentText = My.Resources.help

    End Sub

End Class