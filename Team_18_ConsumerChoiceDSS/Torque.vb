'Team 18 is the torque information for the cars in the database

Public Class Torque

    Public Shared Property TorqueList As List(Of Torque) 'Team 18 creates a shared list of Torque objects

    'Team 18 Creates the instance properties of the Torque class
    Public Property ID As Long 'Team 18 a number that is specific to each Torque object
    Public Property Name As String 'Team 18 the name of the car that is asoociated with a specific instance of the Torque class
    Public Property Torque As Single 'Team 18 is the power of the car per 4000 rpm tha is associated with this instance of Torque

    'Team 18 Creates the constructor for the Torque class
    Public Sub New()

    End Sub
End Class
