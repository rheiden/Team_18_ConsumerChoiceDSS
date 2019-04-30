Public Class Car
    Public Shared Property CarList As List(Of Car) 'Team 18 creates a shared list of Login objects

    'Team 18 Creates the instance properties of the Login class
    Public Property ID As Long 'Team 18 a number that is specific to each Login object
    Public Property Cost As String 'Team 18 the name of the user that is asoociated with a specific instance of the Handling class
    Public Property Transmission As String 'Team 18 is the password of the user that is associated with this Login object
    Public Property Engine As String
    Public Property Fuel As String
    Public Property Body As String
    Public Property Condition As String
    Public Property Make As String
    Public Property Model As String


    'Team 18 Creates the constructor for the Handling class
    Public Sub New()

    End Sub
End Class
