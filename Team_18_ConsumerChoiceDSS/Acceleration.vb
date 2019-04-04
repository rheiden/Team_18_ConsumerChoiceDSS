'Team 18 This class is the Acceleration class and it holds the acceleration time for the cars in the database

Public Class Acceleration

    Public Shared Property AccelerationList As New List(Of Acceleration) 'Team 18 creates a shared list of Acceleration objects

    'Team 18 Creates the instance properties of the acceleration class
    Public Property ID As Single 'Team 18 the ID number unique to each acceleration object
    Public Property Name As String 'Team 18 the name of car associated with this instance of the acceleration class
    Public Property Acceleration As Single 'Team 18 the time it takes for a car to reach 60 mph

    'Team 18 creates the constructor for the acceleration class
    Public Sub New()

    End Sub
End Class
