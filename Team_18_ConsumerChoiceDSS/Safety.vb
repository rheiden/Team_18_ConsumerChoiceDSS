'Team 18 this class holds the safety information for the cars in the database

Public Class Safety

    Public Shared Property SafetyList As List(Of Safety) 'Team 18 creates a shared list of Safety objects

    'Team 18 Creates the instance properties of the Safety class
    Public Property ID As Long 'Team 18 a number that is specific to each instance of a Safety object
    Public Property Name As String 'Team 18 the name of the car that is asoociated of this instance Safety class
    Public Property SafetyRating As Single 'Team 18 is the weight of the car associated with this Safety object

    'Team 18 Creates the constructor for the Safety class
    Public Sub New()

    End Sub

End Class
