Imports Microsoft.SolverFoundation.Common
Imports Microsoft.SolverFoundation.Services
Imports Microsoft.SolverFoundation.Solvers
'**************************************************************************************************************************
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
    Public dvValues(Car.CarList, Goal.GoalList) As Single
    '**************************************************************************************************************************
    Public Sub BuildModel()
        '----------------------------------------------------------------------------------------------------------
        'Team18: Define the decision variables

        'Team18: Defines car decision variables
        For Each myCar As Car In Car.CarList
            dvKey = "Car Choice" & myCar.Make & myCar.Model
            Team18Solver.AddVariable(dvKey, dvIndex)
            Team18Solver.SetBounds(dvIndex, 0, 1)
            Team18Solver.SetIntegrality(dvIndex, True)
        Next
        '----------------------------------------------------------------------------------------------------------
        'Team18: Defines goal decision variables
        For Each myGoal As Goal In Goal.GoalList
            dvKey = "Dplus " & myGoal.Goal
            Team18Solver.addvariable(dvKey, dvIndex)
            Team18Solver.SetBounds(dvIndex, 0, Rational.PositiveInfinity)

            dvKey = "Dminus " & myGoal.Goal
            Team18Solver.addvariable(dvKey, dvIndex)
            Team18Solver.SetBounds(dvIndex, 0, Rational.PositiveInfinity)
        Next
        '----------------------------------------------------------------------------------------------------------
        'Team18: Items Purchased Constraint
        constraintKey = "Purchase Constraint"
        Team18Solver.AddRow(constraintKey, constraintIndex)
        Team18Solver.SetBounds(constraintIndex, 1, 1)
        For Each myCar As Car In Car.CarList
            dvIndex = Team18Solver.GetIndexFromKey(myCar.Make & myCar.Model)
            coefficient = 1
            Team18Solver.SetCoefficient(constraintIndex, dvIndex, coefficient)
        Next
        '----------------------------------------------------------------------------------------------------------
        'Team18: Surplus Constraint (Dplus)
        constraintKey = "Surplus Constraint"
        Team18Solver.AddRow(constraintKey, constraintIndex)
        Team18Solver.SetBounds(constraintIndex, 0, Rational.PositiveInfinity)
        For Each myGoal As Goal In Goal.GoalList
            dvIndex = Team18Solver.getIndexFromKey("Dplus " & myGoal.Goal)
            coefficient = 1
            Team18Solver.SetCoefficient(constraintIndex, dvIndex, coefficient)
        Next
        '----------------------------------------------------------------------------------------------------------
        'Team18: Budget Constraint
        constraintKey = "Budget Constraint"
        Team18Solver.AddRow(constraintKey, constraintIndex)
        'Team18Solver.SetBounds(constraintIndex, 0, CInt(frmTeam18CarInfo.txtTeam18Budget.Text))
        For Each myCar As Car In Car.CarList
            dvIndex = Team18Solver.GetIndexFromKey(myCar.Make & myCar.Model)
            coefficient = myCar.Cost
            Team18Solver.SetCoefficient(constraintIndex, dvIndex, coefficient)
        Next
    End Sub
    '**************************************************************************************************************************
    Public Sub RunModel()

    End Sub
    '**************************************************************************************************************************
    Public Sub ShowAnswer()

    End Sub

End Class
