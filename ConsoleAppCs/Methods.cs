
namespace ConsoleAppCs
{
    public static class Methods
    {

        public static string GetAString(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();
            return output;
        }

        public static double GetADouble(string message)
        {
            Console.Write(message);
            string numberText = Console.ReadLine();
            double output;

            bool isDouble = double.TryParse(numberText, out output);

            while (isDouble == false)
            {
                Console.WriteLine("That was not a valid number. Please try again.");
                Console.Write(message);
                numberText = Console.ReadLine();

                isDouble = double.TryParse(numberText, out output);
            }

            return output;
        }

        public static void ApplicationStartMessage(string firstName)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Static Class Demo App");

            int hourOfDay = DateTime.Now.Hour;

            if (hourOfDay < 12)
            {
                Console.WriteLine($"Good morning {firstName}!");
            }
            else if (hourOfDay < 19)
            {
                Console.WriteLine($"Good afternoon {firstName}!");
            }
            else
            {
                Console.WriteLine($"Good evening {firstName}!");
            }
        }

        public static void PrintResultMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("Thank you for using our app to caluclate for you.");
        }

        public static double Add(double x, double y)
        {
            double output = x + y;

            return output;
        }

    }
}
