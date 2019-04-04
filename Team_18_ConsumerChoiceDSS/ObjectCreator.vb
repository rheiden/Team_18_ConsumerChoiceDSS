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
        Dim myConnectionString As String = ""                                                                           'Team18: the connection string to the data source
        Dim myDataSet As New DataSet                                                                                    'Team18: Creating a DataSet object 
        Dim tableName As String                                                                                         'Team18: the table object we are referring to
        Dim myDataBase As New DataBase                                                                                  'Team18: Creating a DataBase Object

        'Team18: Defining the variables we just created and running the Query
        tableName = "Acceleration"                                              'Team18: name of the table we want to create
        mySQL = "SELECT * FROM " & tableName                                    'Team18: Creating the SQL Query
        myDataBase.RunSQL(tableName, mySQL, myDataSet, myConnectionString)      'Team18: Running the SQL Query

        'Team18: Creating an Acceleration object and setting the properties
        For rowNumber As Integer = 0 To myDataSet.Tables(tableName).Rows.Count - 1
            Dim myAcceleration As New Acceleration
            With myAcceleration
                .ID = myDataSet.Tables(tableName).Rows(rowNumber)("ID")                        'Team18: Setting the ID Property
                .Name = myDataSet.Tables(tableName).Rows(rowNumber)("Name")                    'Team18: Setting the Name Property
                .Acceleration = myDataSet.Tables(tableName).Rows(rowNumber)("Acceleration")    'Team18: Setting the Acceleration Property                          
            End With
            Acceleration.AccelerationList.Add(myAcceleration)                                  'Team18: Adds Acceleration object to AccelerationList
        Next

        'Team18: Defining the variables we just created and running the Query
        tableName = "Braking"                                                   'Team18: name of the table we want to create
        mySQL = "SELECT * FROM " & tableName                                    'Team18: Creating the SQL Query
        myDataBase.RunSQL(tableName, mySQL, myDataSet, myConnectionString)      'Team18: Running the SQL Query

        'Team18: Creating a Braking object and setting the properties
        For rowNumber As Integer = 0 To myDataSet.Tables(tableName).Rows.Count - 1
            Dim myBraking As New Braking
            With myBraking
                .ID = myDataSet.Tables(tableName).Rows(rowNumber)("ID")                        'Team18: Setting the ID Property
                .Name = myDataSet.Tables(tableName).Rows(rowNumber)("Name")                    'Team18: Setting the Name Property
                .Braking = myDataSet.Tables(tableName).Rows(rowNumber)("Braking")              'Team18: Setting the Braking Property                 
            End With
            Braking.BrakingList.Add(myBraking)                                                 'Team18: Adds Braking object to BrakingList
        Next

        'Team18: Defining the variables we just created and running the Query
        tableName = "Handling"                                                      'Team18: name of the table we want to create
        mySQL = "SELECT * FROM " & tableName                                        'Team18: Creating the SQL Query
        myDataBase.RunSQL(tableName, mySQL, myDataSet, myConnectionString)          'Team18: Running the SQL Query

        'Team18: Creating a Handling object and setting the properties
        For rowNumber As Integer = 0 To myDataSet.Tables(tableName).Rows.Count - 1
            Dim myHandling As New Handling
            With myHandling
                .ID = myDataSet.Tables(tableName).Rows(rowNumber)("ID")                        'Team18: Setting the ID Property
                .Name = myDataSet.Tables(tableName).Rows(rowNumber)("Name")                    'Team18: Setting the Name Property
                .Handling = myDataSet.Tables(tableName).Rows(rowNumber)("Handling")            'Team18: Setting the Handling Property                   
            End With
            Handling.HandlingList.Add(myHandling)                                              'Team18: Adds Handling object to HandlingList
        Next

        'Team18: Defining the variables we just created and running the Query
        tableName = "Login"                                                      'Team18: name of the table we want to create
        mySQL = "SELECT * FROM " & tableName                                     'Team18: Creating the SQL Query
        myDataBase.RunSQL(tableName, mySQL, myDataSet, myConnectionString)       'Team18: Running the SQL Query

        'Team18: Creating a Login object and setting the properties
        For rowNumber As Integer = 0 To myDataSet.Tables(tableName).Rows.Count - 1
            Dim myLogin As New Login
            With myLogin
                .ID = myDataSet.Tables(tableName).Rows(rowNumber)("ID")                        'Team18: Setting the ID Property
                .Username = myDataSet.Tables(tableName).Rows(rowNumber)("Username")            'Team18: Setting the Username Property
                .Password = myDataSet.Tables(tableName).Rows(rowNumber)("Password")            'Team18: Setting the Password Property                        
            End With
            Login.LoginList.Add(myLogin)                                                       'Team18: Adds Login object to LoginList
        Next

        'Team18: Defining the variables we just created and running the Query
        tableName = "Safety"                                                      'Team18: name of the table we want to create
        mySQL = "SELECT * FROM " & tableName                                      'Team18: Creating the SQL Query
        myDataBase.RunSQL(tableName, mySQL, myDataSet, myConnectionString)        'Team18: Running the SQL Query

        'Team18: Creating a Safety object and setting the properties
        For rowNumber As Integer = 0 To myDataSet.Tables(tableName).Rows.Count - 1
            Dim mySafety As New Safety
            With mySafety
                .ID = myDataSet.Tables(tableName).Rows(rowNumber)("ID")                        'Team18: Setting the ID Property
                .Name = myDataSet.Tables(tableName).Rows(rowNumber)("Name")                    'Team18: Setting the Name Property
                .SafetyRating = myDataSet.Tables(tableName).Rows(rowNumber)("Safety Rating")   'Team18: Setting the SafetyRating Property                      
            End With
            Safety.SafetyList.Add(mySafety)                                                    'Team18: Adds Safety object to SafetyList
        Next

        'Team18: Defining the variables we just created and running the Query
        tableName = "Speed"                                                      'Team18: name of the table we want to create
        mySQL = "SELECT * FROM " & tableName                                     'Team18: Creating the SQL Query
        myDataBase.RunSQL(tableName, mySQL, myDataSet, myConnectionString)       'Team18: Running the SQL Query

        'Team18: Creating a Speed object and setting the properties
        For rowNumber As Integer = 0 To myDataSet.Tables(tableName).Rows.Count - 1
            Dim mySpeed As New Speed
            With mySpeed
                .ID = myDataSet.Tables(tableName).Rows(rowNumber)("ID")                        'Team18: Setting the ID Property
                .Name = myDataSet.Tables(tableName).Rows(rowNumber)("Name")                    'Team18: Setting the Name Property
                .Speed = myDataSet.Tables(tableName).Rows(rowNumber)("Speed")                  'Team18: Setting the Speed Property  
            End With
            Speed.SpeedList.Add(mySpeed)                                                       'Team18: Adds Speed Object to SpeedList
        Next

        'Team18: Defining the variables we just created and running the Query
        tableName = "FuelTankCapacity"                                          'Team18: name of the table we want to create
        mySQL = "SELECT * FROM " & tableName                                    'Team18: Creating the SQL Query
        myDataBase.RunSQL(tableName, mySQL, myDataSet, myConnectionString)      'Team18: Running the SQL Query
        'Team18: Creating a FuelTankCapacity object and setting the properties
        For rowNumber As Integer = 0 To myDataSet.Tables(tableName).Rows.Count - 1
            Dim myFTCapacity As New FuelTankCapacity
            With myFTCapacity
                .ID = myDataSet.Tables(tableName).Rows(rowNumber)("ID")                        'Team18: Setting the ID Property
                .Name = myDataSet.Tables(tableName).Rows(rowNumber)("Name")                    'Team18: Setting the Name Property
                .EngineType = myDataSet.Tables(tableName).Rows(rowNumber)("Engine Type")       'Team18: Setting the EngineType Property 
                .Capacity = myDataSet.Tables(tableName).Rows(rowNumber)("Capacity")            'Team18: Setting the Capacity Property
            End With
            FuelTankCapacity.FuelTankCapacityList.Add(myFTCapacity)                            'Team18: Adds FuelTankCapacity Object to FuelTankCapacityList
        Next

        'Team18: Defining the variables we just created and running the Query
        tableName = "Torque"                                                      'Team18: name of the table we want to create
        mySQL = "SELECT * FROM " & tableName                                      'Team18: Creating the SQL Query
        myDataBase.RunSQL(tableName, mySQL, myDataSet, myConnectionString)        'Team18: Running the SQL Query

        'Team18: Creating a Torque object and setting the properties
        For rowNumber As Integer = 0 To myDataSet.Tables(tableName).Rows.Count - 1
            Dim myTorque As New Torque
            With myTorque
                .ID = myDataSet.Tables(tableName).Rows(rowNumber)("ID")                        'Team18: Setting the ID Property
                .Name = myDataSet.Tables(tableName).Rows(rowNumber)("Name")                    'Team18: Setting the Name Property
                .Torque = myDataSet.Tables(tableName).Rows(rowNumber)("Torque")                'Team18: Setting the Torque Property  
            End With
            Torque.TorqueList.Add(myTorque)                                                    'Team18: Adds Torue Object to TorqueList
        Next

        'Team18: Defining the variables we just created and running the Query
        tableName = "Turning Radius"                                              'Team18: name of the table we want to create
        mySQL = "SELECT * FROM " & tableName                                      'Team18: Creating the SQL Query
        myDataBase.RunSQL(tableName, mySQL, myDataSet, myConnectionString)        'Team18: Running the SQL Query

        'Team18: Creating a TurningRadius object and setting the properties
        For rowNumber As Integer = 0 To myDataSet.Tables(tableName).Rows.Count - 1
            Dim myTurningRadius As New TurningRadius
            With myTurningRadius
                .ID = myDataSet.Tables(tableName).Rows(rowNumber)("ID")                        'Team18: Setting the ID Property
                .Name = myDataSet.Tables(tableName).Rows(rowNumber)("Name")                    'Team18: Setting the Name Property
                .TurningRadius = myDataSet.Tables(tableName).Rows(rowNumber)("Turning Radius") 'Team18: Setting the TurningRadius Property  
            End With
            TurningRadius.TurningRadiusList.Add(myTurningRadius)                               'Team18: Adds TurningRadius Object to TurningRadiusList
        Next

        'Team18: Defining the variables we just created and running the Query
        tableName = "Curb Weight"                                               'Team18: name of the table we want to create
        mySQL = "SELECT * FROM " & tableName                                    'Team18: Creating the SQL Query
        myDataBase.RunSQL(tableName, mySQL, myDataSet, myConnectionString)      'Team18: Running the SQL Query

        'Team18: Creating a CurbWeight object and setting the properties
        For rowNumber As Integer = 0 To myDataSet.Tables(tableName).Rows.Count - 1
            Dim myCurbWeight As New CurbWeight
            With myCurbWeight
                .ID = myDataSet.Tables(tableName).Rows(rowNumber)("ID")                        'Team18: Setting the ID Property
                .Name = myDataSet.Tables(tableName).Rows(rowNumber)("Name")                    'Team18: Setting the Name Property
                .CurbWeight = myDataSet.Tables(tableName).Rows(rowNumber)("Curb Weight")       'Team18: Setting the CurbWeight Property  
            End With
            CurbWeight.CurbWeightList.Add(myCurbWeight)                                        'Team18: Adds CurbWeight Object to CurbWeightList
        Next

    End Sub
    '**************************************************************************************************************************
End Class
