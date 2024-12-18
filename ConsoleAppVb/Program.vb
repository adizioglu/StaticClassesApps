Imports System

Module Program
    Sub Main(args As String())

        Dim firstName As String = ConsoleAppCs.Methods.GetAString("What is your first name: ")

        ConsoleAppCs.Methods.ApplicationStartMessage(firstName)

        Dim x As Double = ConsoleAppCs.Methods.GetADouble("Please enter your first number: ")
        Dim y As Double = ConsoleAppCs.Methods.GetADouble("Please enter your second number: ")

        Dim result As Double = ConsoleAppCs.Methods.Add(x, y)

        ConsoleAppCs.Methods.PrintResultMessage($"The sum of {x} and {y} is {result}")

        Console.ReadLine()

    End Sub
End Module
