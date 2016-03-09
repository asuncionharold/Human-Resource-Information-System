Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Searchbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Searchbt.Click
        Form5.Show()
    End Sub

    Private Sub Addbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addbt.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class