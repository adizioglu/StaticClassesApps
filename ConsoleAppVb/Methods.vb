Namespace ConsoleAppCs
    Public Module Methods

        Public Function GetAString(message As String) As String
            Console.Write(message)
            Dim output As String = Console.ReadLine()
            Return output
        End Function

        Public Function GetADouble(message As String) As Double
            Console.Write(message)
            Dim numberText As String = Console.ReadLine()
            Dim output As Double

            Dim isDouble As Boolean = Double.TryParse(numberText, output)

            While isDouble = False
                Console.WriteLine("That was not a valid number. Please try again.")
                Console.Write(message)
                numberText = Console.ReadLine()

                isDouble = Double.TryParse(numberText, output)
            End While

            Return output
        End Function

        Public Sub ApplicationStartMessage(firstName As String)
            Console.Clear()
            Console.WriteLine("Welcome to the Static Class Demo App")

            Dim hourOfDay As Integer = DateTime.Now.Hour

            If hourOfDay < 12 Then
                Console.WriteLine($"Good morning {firstName}!")
            ElseIf hourOfDay < 19 Then
                Console.WriteLine($"Good afternoon {firstName}!")
            Else
                Console.WriteLine($"Good evening {firstName}!")
            End If
        End Sub

        Public Sub PrintResultMessage(message As String)
            Console.WriteLine(message)
            Console.WriteLine()
            Console.WriteLine("Thank you for using our app to calculate for you.")
        End Sub

        Public Function Add(x As Double, y As Double) As Double
            Dim output As Double = x + y

            Return output
        End Function

    End Module
End Namespace

