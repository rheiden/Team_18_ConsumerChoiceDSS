Imports System.Data.OleDb                             'Team18: We use the OleDB namespace for an MS Access namespace
'**************************************************************************************************************************
Public Class Database

    'ADO.NET Data Provider Objects
    Private Team18DataAdapter As New OleDbDataAdapter    ': ADO.NET DataAdapter Object -  The DataAdapter facilitates the conversion from the external Database to the internal DataSet
    Private Team18Connection As New OleDbConnection      'Team18: ADO.NET Connection Object property -  
    Private Team18ConnectionString As String             'Team18: ADO.NET Connection Object property -  The connection string is found in the app.config file.  This string points to the external DataBase
    Private Team18SQL As String                          'Team18: ADO.NET Command Object property - This string is declared for any SQL statements that we will write
    Private Team18DataSet As New DataSet                 'Team18: ADO.NET DataSet Object - The external Database will be transformed into an internal DataSetDim orderList As New List(Of SalesOrder)
    Private Team18Command As New OleDbCommand            'Team18: ADO.NET DataSet Command Object - sql commands are conveyed via a Command object
    Private Team18TableName As String                    'Team18: sql Commands are executed on tables
    '**************************************************************************************************************************
    Public Sub New()
        ' This sub creates a new DBMSe object
    End Sub
    '**************************************************************************************************************************
    Public Sub RunSQL(ByVal Team18TableName, ByVal Team18SQL, ByVal Team18DataSet, ByVal Team18ConnectionString)
        '
        'Team18:  First we build the Database Connection Object
        Team18Connection.ConnectionString = Team18ConnectionString      'Team18:  We use the Connection String that is found in the app.config file to connect to the DataBase
        Team18Command = Team18Connection.CreateCommand()
        '
        'Team18: Now we build the Command that will be sent to the Data Adapter
        Team18Command.CommandText = Team18SQL                            'Team18: The sql is embedded in an object called a Command
        '
        'Team18: Now we build the Data Adapter
        Team18DataAdapter.SelectCommand = Team18Command                  'Team18: The DataAdaptor executes the query Command
        Team18DataAdapter.Fill(Team18DataSet, Team18TableName)              'Team18: The Fill method of the DataAdaptor fills tables in the DataSet from data from the DataBase

    End Sub


End Class
