#include <iostream>
#include <string>
#include <limits>

namespace ConsoleAppCs
{
    class Methods
    {
    public:
        static std::string GetAString(const std::string& message)
        {
            std::cout << message;
            std::string output;
            std::getline(std::cin, output);
            return output;
        }

        static double GetADouble(const std::string& message)
        {
            double output;
            while (true)
            {
                std::cout << message;
                std::string numberText;
                std::getline(std::cin, numberText);

                try
                {
                    output = std::stod(numberText);
                    break;
                }
                catch (const std::invalid_argument&)
                {
                    std::cout << "That was not a valid number. Please try again." << std::endl;
                }
                catch (const std::out_of_range&)
                {
                    std::cout << "The number is out of range. Please try again." << std::endl;
                }
            }
            return output;
        }

        static void ApplicationStartMessage(const std::string& firstName)
        {
            std::cout << "\033[2J\033[1;1H"; // Clear console
            std::cout << "Welcome to the Static Class Demo App" << std::endl;

            int hourOfDay = std::time(nullptr) % 86400 / 3600;

            if (hourOfDay < 12)
            {
                std::cout << "Good morning " << firstName << "!" << std::endl;
            }
            else if (hourOfDay < 19)
            {
                std::cout << "Good afternoon " << firstName << "!" << std::endl;
            }
            else
            {
                std::cout << "Good evening " << firstName << "!" << std::endl;
            }
        }

        static void PrintResultMessage(const std::string& message)
        {
            std::cout << message << std::endl;
            std::cout << std::endl;
            std::cout << "Thank you for using our app to calculate for you." << std::endl;
        }

        static double Add(double x, double y)
        {
            return x + y;
        }
    };
}


