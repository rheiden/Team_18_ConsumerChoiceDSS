Public Class Goal
    Public Shared Property GoalList As List(Of Goal) 'Team 18 creates a shared list of Login objects

    'Team 18 Creates the instance properties of the Login class
    Public Property ID As Long 'Team 18 a number that is specific to each Login object
    Public Property Goal As String 'Team 18 the name of the user that is asoociated with a specific instance of the Handling class
    Public Property Dplus As Integer 'Team 18 is the password of the user that is associated with this Login object
    Public Property Dminus As Integer

    'Team 18 Creates the constructor for the Handling class
    Public Sub New()

    End Sub
End Class
