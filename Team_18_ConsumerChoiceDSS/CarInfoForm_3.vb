Public Class frmTeam18CarInfo
    Private Sub btnTeam18GoBackCarInfo_Click(sender As Object, e As EventArgs) Handles btnTeam18GoBackCarInfo.Click
        Me.Close()
        frmTeam18Welcome.Show()
    End Sub

    Private Sub btnTeam18ExitCarInfo_Click(sender As Object, e As EventArgs) Handles btnTeam18ExitCarInfo.Click
        Me.Close()
    End Sub

    Private Sub btnTeam18ConfirmInfo_Click(sender As Object, e As EventArgs) Handles btnTeam18ConfirmInfo.Click
        'Team18: We create an instance of the CreateObjects class and run the method to import data and create objects and lists of objects
        Dim Team18CreateObjects As New ObjectCreator
        Team18CreateObjects.CreateObjectsAndLists()
        '
        'Team18: Now we create an Optimization object to build an run the linear program
        Dim Team18Optimization As New Optimization
        Team18Optimization.BuildModel()
        Team18Optimization.RunModel()
    End Sub
End Class