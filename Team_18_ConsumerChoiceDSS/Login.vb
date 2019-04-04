'Team 18 holds the login for the users of the system

Public Class Login

    Public Shared Property LoginList As List(Of Login) 'Team 18 creates a shared list of Login objects

    'Team 18 Creates the instance properties of the Login class
    Public Property ID As Long 'Team 18 a number that is specific to each Login object
    Public Property UserName As String 'Team 18 the name of the user that is asoociated with a specific instance of the Handling class
    Public Property Password As String 'Team 18 is the password of the user that is associated with this Login object

    'Team 18 Creates the constructor for the Handling class
    Public Sub New()

    End Sub
End Class
