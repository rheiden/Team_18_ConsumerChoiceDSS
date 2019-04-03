'**************************************************************************************************************************
Public Class frmTeam18Welcome
    '**************************************************************************************************************************
    Private Sub frmTeam18Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Team18: Creating a new ObjectCreator and running the method that creates all objects and lists
        Dim myObjectCreator As New ObjectCreator
        myObjectCreator.CreateObjectsAndLists()
    End Sub
    '**************************************************************************************************************************
End Class
