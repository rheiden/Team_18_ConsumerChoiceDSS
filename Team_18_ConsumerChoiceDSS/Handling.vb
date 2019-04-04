'Team 18 This class holds the handling information for the cars in the databae

Public Class Handling

    Public Shared Property HandlingList As List(Of Handling) 'Team 18 creates a shared list of Handling objects

    'Team 18 Creates the instance properties of the Handling class
    Public Property ID As Long 'Team 18 a number that is specific to each Handling object
    Public Property Name As String 'Team 18 the name of the car that is asoociated with a specific instance of the Handling class
    Public Property Braking As Single 'Team 18 is how well the car can handle turns

    'Team 18 Creates the constructor for the Handling class
    Public Sub New()

    End Sub

End Class
