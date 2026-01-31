' -- Copyright (c) Stuart Garner 2012. All rights reserved. --

Public Class frmAbout

    ' -- Form Events --

    Private Sub frmAbout_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' Load application details into appropriate labels.
        lblProductName.Text = My.Application.Info.ProductName
        lblVersion.Text = "V" & My.Application.Info.Version.ToString
        lblCopyright.Text = My.Application.Info.Copyright

    End Sub

End Class