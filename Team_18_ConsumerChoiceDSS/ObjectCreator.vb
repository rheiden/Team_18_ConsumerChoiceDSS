'**************************************************************************************************************************
'Team18: This Class creates all the objects of each MS Access Class

Public Class ObjectCreator
    '**************************************************************************************************************************
    Public Sub New()
        'Team18: Creates a new ObjectCreator Object
    End Sub
    '**************************************************************************************************************************
    'Team18: This method creates every MS Access Class object and adds the created object to its corresponding list

    Public Sub CreateObjectsAndLists()

        'Team18: Parameters for the RunSQL Method
        Dim mySQL As String                                                                                             'Team18: The SQL Query
        Dim myConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\NewSP19_Project.mdb"                                                                           'Team18: the connection string to the data source
        Dim myDataSet As New DataSet                                                                                    'Team18: Creating a DataSet object 
        Dim tableName As String                                                                                         'Team18: the table object we are referring to
        Dim myDataBase As New DataBase                                                                                  'Team18: Creating a DataBase Object

        'Team18: Defining the variables we just created and running the Query
        tableName = "CarData"                                                  'Team18: name of the table we want to create
        mySQL = "SELECT * FROM " & tableName                                    'Team18: Creating the SQL Query
        myDataBase.RunSQL(tableName, mySQL, myDataSet, myConnectionString)      'Team18: Running the SQL Query

        'Team18: Creating an Acceleration object and setting the properties
        For rowNumber As Integer = 0 To myDataSet.Tables(tableName).Rows.Count - 1
            Dim myCar As New Car
            With myCar
                .ID = myDataSet.Tables(tableName).Rows(rowNumber)("ID")                         'Team18: Setting the ID Property
                .Cost = myDataSet.Tables(tableName).Rows(rowNumber)("Cost")                     'Team18: Setting the Cost Property
                .Transmission = myDataSet.Tables(tableName).Rows(rowNumber)("Transmission")     'Team18: Setting the Transmission Property                          
                .Engine = myDataSet.Tables(tableName).Rows(rowNumber)("Engine Type")            'Team18: Setting the Engine Type Property
                .Fuel = myDataSet.Tables(tableName).Rows(rowNumber)("Fuel Efficiency")          'Team18: Setting the Fuel Efficiency Property
                .Body = myDataSet.Tables(tableName).Rows(rowNumber)("Body Type")                'Team18: Setting the Body Type Property
                .Condition = myDataSet.Tables(tableName).Rows(rowNumber)("New/Used")            'Team18: Setting the Car Condition Property
                .Make = myDataSet.Tables(tableName).Rows(rowNumber)("Make")                     'Team18: Setting the Make Property
                .Model = myDataSet.Tables(tableName).Rows(rowNumber)("Model")                   'Team18: Setting the Model Property


            End With
            Car.CarList.Add(myCar)                                                              'Team18: Adds Car object to CarList
        Next

        'Team18: Defining the variables we just created and running the Query
        tableName = "Goal"                                                      'Team18: name of the table we want to create
        mySQL = "SELECT * FROM " & tableName                                    'Team18: Creating the SQL Query
        myDataBase.RunSQL(tableName, mySQL, myDataSet, myConnectionString)      'Team18: Running the SQL Query

        'Team18: Creating a Braking object and setting the properties
        For rowNumber As Integer = 0 To myDataSet.Tables(tableName).Rows.Count - 1
            Dim myGoal As New Goal
            With myGoal
                .ID = myDataSet.Tables(tableName).Rows(rowNumber)("ID")                        'Team18: Setting the ID Property
                .Goal = myDataSet.Tables(tableName).Rows(rowNumber)("Goal")                    'Team18: Setting the Goal Property
                .Dplus = myDataSet.Tables(tableName).Rows(rowNumber)("Weight on Dplus")        'Team18: Setting the Weight on Dplus Property   
                .Dminus = myDataSet.Tables(tableName).Rows(rowNumber)("Weight on Dminus")      'Team18: Setting the Weight on Dminus Property

            End With
            Goal.GoalList.Add(myGoal)                                                          'Team18: Adds Goal object to GoalList
        Next

        'Team18: Defining the variables we just created and running the Query
        tableName = "Login"                                                                    'Team18: name of the table we want to create
        mySQL = "SELECT * FROM " & tableName                                                   'Team18: Creating the SQL Query
        myDataBase.RunSQL(tableName, mySQL, myDataSet, myConnectionString)                     'Team18: Running the SQL Query

        'Team18: Creating a Handling object and setting the properties
        For rowNumber As Integer = 0 To myDataSet.Tables(tableName).Rows.Count - 1
            Dim myLogin As New Login
            With myLogin
                .ID = myDataSet.Tables(tableName).Rows(rowNumber)("ID")                        'Team18: Setting the ID Property
                .UserName = myDataSet.Tables(tableName).Rows(rowNumber)("UserName")            'Team18: Setting the UserName Property
                .Password = myDataSet.Tables(tableName).Rows(rowNumber)("Password")            'Team18: Setting the Password Property                   
            End With
            Login.LoginList.Add(myLogin)                                                      'Team18: Adds Login Object to LoginList
        Next


    End Sub
    '**************************************************************************************************************************
End Class
