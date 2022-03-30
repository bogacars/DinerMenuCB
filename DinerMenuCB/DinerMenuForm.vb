Public Class DinerMenuForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub ToolMenuItem_Click(sender As Object, e As EventArgs) Handles ToolMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem2.Click
        AboutForm.Show()
        Me.Hide()
    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = ("        Soup of the day: Homemade Chicken Noodle Soup") & vbNewLine &
            ("This chicken noodle soup features all home grown ingredients") & vbNewLine &
            ("                        Gluten free options also availible")
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text = ("              Salad of the day: Fresh Chicken Salad") & vbNewLine &
            ("Fresh Romanine and iceberg lettuce with spinach, carrots, ") & vbNewLine &
            ("   and free range chicken. With your choice of dressing")
    End Sub
    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Text = ("              Fish of the day: Chicken fish?") & vbNewLine &
            ("You may be thinking chicken fish is that a thing? Yes!") & vbNewLine &
            ("The freshest caught fish on the farm, only ever fed ") & vbNewLine &
            ("real free range chicken. It's as simple as fish that tastes like chicken!")
    End Sub

End Class
