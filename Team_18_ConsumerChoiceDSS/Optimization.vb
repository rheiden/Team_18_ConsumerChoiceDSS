Imports Microsoft.SolverFoundation.Common
Imports Microsoft.SolverFoundation.Services
Imports Microsoft.SolverFoundation.Solvers
Public Class Optimization
    Dim Team18Solver As New SimplexSolver
    Dim dvKey As String
    Dim dvIndex As Integer
    Dim coefficient As Single
    Dim constraintKey As String
    Dim constraintIndex As Integer
    Dim objKey As String = "Objective Function"
    Dim objIndex As Integer
    Public optimalObj As Single
    Public dvValues("PlaceHolder", "PlaceHolder") As Single  'Change these values
    Public Sub BuildModel()

    End Sub
    Public Sub RunModel()

    End Sub
    Public Sub ShowAnswer()

    End Sub

End Class
