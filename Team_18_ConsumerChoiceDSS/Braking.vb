'Team 18 This class is the Braking object which measures how well the cars in the database can brake.

Public Class Braking

    Public Shared Property BrakingList As List(Of Braking) 'Team 18 creates a shared list of Braking objects

    'Team 18 Creates the instance properties of the braking class
    Public Property ID As Long 'Team 18 a number that is specific to each braking object
    Public Property Name As String 'Team 18 the name of the car that is asoociated with this instance braking class
    Public Property Braking As Single 'Team 18 is how well the car brakes, graded on a scale of 1 to 5

    'Team 18 Creates the constructor for the Braking class
    Public Sub New()

    End Sub
End Class
