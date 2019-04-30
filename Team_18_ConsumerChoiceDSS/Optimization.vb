﻿Imports Microsoft.SolverFoundation.Common
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
            Team18Solver.AddVariable(dvKey, dvIndex)
            Team18Solver.SetBounds(dvIndex, 0, Rational.PositiveInfinity)

            dvKey = "Dminus " & myGoal.Goal
            Team18Solver.AddVariable(dvKey, dvIndex)
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
            dvIndex = Team18Solver.GetIndexFromKey("Dplus " & myGoal.Goal)
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
        objKey = "Total Deviation"
        Team18Solver.AddRow(objKey, objIndex)
        Team18Solver.AddGoal(objIndex, 1, True)
        For Each dev As Deviation In Deviation.DeviationList
            For Each myCar As Car In Car.CarList
                dvIndex = Team18Solver.GetIndexFromKey(dev.Deviation & "_" mycar.Car)
                Dim myActivityIndex As Integer = myCar.ActivityList.IndexOf(myCar)
                coefficient = dev.Deviation(myActivityIndex)
                Team18Solver.SetCoefficient(constraintIndex, dvIndex, coefficient)
            Next
        Next
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

        'CLR Now we display the optimal values of the variables and objective function
        optimalObj = CSng(Team18Solver.GetValue(objIndex).ToDouble)

        'CLR We transfer the values of the decision variables to an array 
        Dim rowIndex As Integer = 0
        Dim columnIndex As Integer = 0

        '
        For Each myCar As Car In Car.CarList
            rowIndex = Car.CarList.IndexOf(myCar)
            For Each myGoal As Goal In Goal.GoalList
                columnIndex = Goal.GoalList.IndexOf(myGoal)
                dvKey = myCar.Model & "_" & myGoal.Goal
                dvIndex = Team18Solver.GetIndexFromKey(dvKey)
                dvValues(rowIndex, columnIndex) = CSng(Team18Solver.GetValue(dvIndex).ToDouble)
            Next
        Next
        '************************************************************************************
        Solution.tblTeam18Output.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        '
        'CLR We enter the column headings into the table
        For column As Integer = 1 To Solution.tblTeam18Output.ColumnCount - 1
            Dim myLabel As New Label
            myLabel.Text = "Goal " & CStr(column)
            Solution.tblTeam18Output.Controls.Add(myLabel)
            myLabel.Visible = True
            myLabel.TextAlign = ContentAlignment.MiddleCenter
            Solution.tblTeam18Output.SetRow(myLabel, 0)
            Solution.tblTeam18Output.SetColumn(myLabel, column)
            myLabel.Anchor = AnchorStyles.Bottom
            myLabel.Anchor = AnchorStyles.Top
            myLabel.Anchor = AnchorStyles.Left
            myLabel.Anchor = AnchorStyles.Right

        Next
        '
        'CLR We enter the row headings into the table
        rowIndex = 0
        For Each myCar As Car In Car.CarList
            Dim myLabel As New Label
            myLabel.Text = myCar.Model
            myLabel.Visible = True
            myLabel.TextAlign = ContentAlignment.MiddleCenter
            Solution.tblTeam18Output.SetRow(myLabel, rowIndex + 1)
            Solution.tblTeam18Output.SetColumn(myLabel, 0)
            Solution.tblTeam18Output.Dock = DockStyle.Fill
            Solution.tblTeam18Output.Controls.Add(myLabel)
            myLabel.Anchor = AnchorStyles.Bottom
            myLabel.Anchor = AnchorStyles.Top
            myLabel.Anchor = AnchorStyles.Left
            myLabel.Anchor = AnchorStyles.Right
            rowIndex += 1
        Next

        For row As Integer = 1 To Solution.tblTeam18Output.RowCount - 1
            For column As Integer = 1 To Solution.tblTeam18Output.ColumnCount - 1
                Dim myLabel As New Label
                myLabel.Text = CStr(dvValues(row - 1, column - 1))
                myLabel.Visible = True
                myLabel.TextAlign = ContentAlignment.MiddleCenter
                Solution.tblTeam18Output.SetRow(myLabel, row)
                Solution.tblTeam18Output.SetColumn(myLabel, column)
                Solution.tblTeam18Output.Dock = DockStyle.Fill
                Solution.tblTeam18Output.Controls.Add(myLabel)
                myLabel.Anchor = AnchorStyles.Bottom
                myLabel.Anchor = AnchorStyles.Top
                myLabel.Anchor = AnchorStyles.Left
                myLabel.Anchor = AnchorStyles.Right
            Next
        Next

        Solution.Show()

    End Sub



End Class



