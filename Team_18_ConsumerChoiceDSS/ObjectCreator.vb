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
        tableName = "CarData"                                              'Team18: name of the table we want to create
        mySQL = "SELECT * FROM " & tableName                                    'Team18: Creating the SQL Query
        myDataBase.RunSQL(tableName, mySQL, myDataSet, myConnectionString)      'Team18: Running the SQL Query

        'Team18: Creating an Acceleration object and setting the properties
        For rowNumber As Integer = 0 To myDataSet.Tables(tableName).Rows.Count - 1
            Dim myCar As New Car
            With myCar
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


    End Sub
    '**************************************************************************************************************************
End Class
