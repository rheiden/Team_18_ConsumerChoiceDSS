'Team 18 this class holds the turningRadius information for the cars in the database

Public Class TurningRadius

    Public Shared Property TurningRadiusList As List(Of TurningRadius) 'Team 18 creates a shared list of TurningRadius objects

    'Team 18 Creates the instance properties of the TurningRadius class
    Public Property ID As Long 'Team 18 a number that is specific to each TurningRadius object
    Public Property Name As String 'Team 18 the name of the car that is asoociated with a specific instance of the TurningRadius class
    Public Property Braking As Single 'Team 18 is how tight the car is able to turn

    'Team 18 Creates the constructor for the TurningRadius class
    Public Sub New()

    End Sub
End Class
