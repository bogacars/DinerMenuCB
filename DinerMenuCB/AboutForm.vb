﻿Public Class AboutForm
    Private Sub AboutForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        DinerMenuForm.Show()
    End Sub
End Class