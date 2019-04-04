'Team 18 creates the class that holds the FuelTankCapacity information for the cars in the database

Public Class FuelTankCapacity

    Public Shared Property FuelTankCapacityList As List(Of FuelTankCapacity) 'Team 18 creates a shared list of FuelTankCapacity objects

    'Team 18 Creates the instance properties of the FuelTankCapacity class
    Public Property ID As Long 'Team 18 a number that is specific to each FuelTankCapacity object
    Public Property Name As String 'Team 18 the name of the car that is asoociated with a specific instance of the FuelTankCapacity class
    Public Property Capacity As Single 'Team 18 the amount of gas in gallons that the car's engine can hold
    Public Property EngineType As String 'Team 18 the type of engine that the associated with the FuelTankCapacity has 

    'Team 18 Creates the constructor for the FuelTankCapacity class
    Public Sub New()

    End Sub


End Class
