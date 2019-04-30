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
    Public dvValues(Car.CarList.Count - 1, Goal.GoalList.Count - 1) As Single
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
        Team18Solver.SetBounds(constraintIndex, 0, CInt(frmTeam18NewUser.txtTeam18Budget.Text))
        For Each myCar As Car In Car.CarList
            dvIndex = Team18Solver.GetIndexFromKey(myCar.Make & myCar.Model)
            coefficient = myCar.Cost
            Team18Solver.SetCoefficient(constraintIndex, dvIndex, coefficient)
        Next
        '----------------------------------------------------------------------------------------------------------
        'Team 18: Objective Function
        objKey = "Total Effectiveness"
        Team18Solver.AddRow(objKey, objIndex)
        Team18Solver.AddGoal(objIndex, 1, True)
    End Sub
    '**************************************************************************************************************************
    Public Sub RunModel()

        'CLR runs the solver and displays the reselts
        Dim mySolverParms As New SimplexSolverParams
        mySolverParms.MixedIntegerGapTolerance = 1
        mySolverParms.VariableFeasibilityTolerance = 0.00001
        mySolverParms.MaxPivotCount = 1000
        Team18Solver.Solve(mySolverParms)

        If Team18Solver.Result = LinearResult.UnboundedPrimal Then
            MessageBox.Show("Solution is unbounded")
            Exit Sub
        ElseIf _
        Team18Solver.Result = LinearResult.InfeasiblePrimal Then
            MessageBox.Show("Decision model is infeasible")
            Exit Sub
        Else
            ShowAnswer()
        End If

    End Sub
    '**************************************************************************************************************************
    Public Sub ShowAnswer()

        frmRCHResults.rbxTeam18Make.Text =
        frmRCHResults.rbxTeam18Model.Text =
        frmRCHResults.rbxTeam18Cost.Text =
        frmRCHResults.rtxTeam18BodyType.Text =
        frmRCHResults.rtxTeam18Transmission.Text =
        frmRCHResults.rtxTeam18Engine.Text =
        frmRCHResults.rtxTeam18FuelEfficiency.Text =
        frmRCHResults.rtxTeam18BodyType.Text = 

    End Sub

End Class
