Public Class frmTeam18NewUser
    Private Sub btnTeam18GoBackNewUser_Click(sender As Object, e As EventArgs) Handles btnTeam18GoBackNewUser.Click
        Me.Close()
        frmTeam18Welcome.Show()
    End Sub

    Private Sub btnTeam18CreateAccount_Click(sender As Object, e As EventArgs) Handles btnTeam18CreateAccount.Click
        Me.Close()
        frmTeam18Welcome.Show()
    End Sub

    Private Sub btnTeam18ExitNewUser_Click(sender As Object, e As EventArgs) Handles btnTeam18ExitNewUser.Click
        Me.Close()
    End Sub
End Class