'Team 18 This class that defines the CurbWeight for the cars in the database

Public Class CurbWeight

    Public Shared Property CurbWeightList As List(Of CurbWeight) 'Team 18 creates a shared list of CurbWeight objects

    'Team 18 Creates the instance properties of the CurbWeight Class
    Public Property ID As Long 'Team 18 a number that is specific to each CurbWeight object
    Public Property Name As String 'Team 18 the name of the car that is asoociated to a specific instance of the CurbWeight class
    Public Property CurbWeight As Single 'Team 18 is the total weight of the car in pounds associated with this CurbWeight object

    'Team 18 Creates the constructor for the CurbWeight class
    Public Sub New()

    End Sub

End Class
