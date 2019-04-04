'Team 18 this class holds the information for the speed property for the cars in the database

Public Class Speed

    Public Shared Property SpeedList As List(Of Speed) 'Team 18 creates a shared list of Speed objects

    'Team 18 Creates the instance properties of the Handling class
    Public Property ID As Long 'Team 18 a number that is specific to each Speed object
    Public Property Name As String 'Team 18 the name of the car that is asoociated with a specific instance of the Speed class
    Public Property Speed As Single 'Team 18 is the top speed in mph that the car can reach

    'Team 18 Creates the constructor for the Speed class
    Public Sub New()

    End Sub
End Class
