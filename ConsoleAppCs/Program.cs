
string firstName = ConsoleAppCs.Methods.GetAString("What is your first name: ");

ConsoleAppCs.Methods.ApplicationStartMessage(firstName);

double x = ConsoleAppCs.Methods.GetADouble("Please enter your first number: ");
double y = ConsoleAppCs.Methods.GetADouble("Please enter your second number: ");

double result = ConsoleAppCs.Methods.Add(x, y);

ConsoleAppCs.Methods.PrintResultMessage($"The sum of {x} and {y} is {result}");

Console.ReadLine();
