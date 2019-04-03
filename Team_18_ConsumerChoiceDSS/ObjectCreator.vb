'**************************************************************************************************************************
Public Class ObjectCreator
    '**************************************************************************************************************************
    Public Sub New()
        'Team18: Creates a new ObjectCreator Object
    End Sub
    '**************************************************************************************************************************
    Public Sub CreateObjectsAndLists()

        'Team18: Parameters for the RunSQL Method
        Dim mySQL As String                                                                                             'Team18: The SQL Query
        Dim myConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\IC4.mdb"       'Team18: the connection string to the data source
        Dim myDataSet As New DataSet                                                                                    'Creating a DataSet object 
        Dim tableName As String                                                                                         'Team18: the table object we are referring to
        Dim myDataBase As New DataBase                                                                                  ' Creating a DataBase Object

        'Team18: Defining the variables we just created and running the Query
        tableName = "Meal"                                                      'Team18: name of the table we want to create
        mySQL = "SELECT * FROM " & tableName                                    'Team18: Creating the SQL Query
        myDataBase.RunSQL(tableName, mySQL, myDataSet, myConnectionString)      'Team18: Running the SQL Query

        'Team18: Creating a Meal object and setting the properties
        For rowNumber As Integer = 0 To myDataSet.Tables(tableName).Rows.Count - 1
            'Dim myMeal As New Meal
            'With myMeal
            '    .ID = myDataSet.Tables(tableName).Rows(rowNumber)("ID")                        'Team18: Setting the ID Property
            '    .MealName = myDataSet.Tables(tableName).Rows(rowNumber)("MealName")            'Team18: Setting the MealName Property
            '    .NormalPrice = myDataSet.Tables(tableName).Rows(rowNumber)("NormalPrice")      'Team18: Setting the NormalPrice Property 
            '    .Location = myDataSet.Tables(tableName).Rows(rowNumber)("Location")            'Team18: Setting the Location property
            'End With
            'Meal.MealList.Add(myMeal)                                                          'Team18: Adds meal object to Meal list
        Next
    End Sub
    '**************************************************************************************************************************
End Class
