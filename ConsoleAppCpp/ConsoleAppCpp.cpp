
#include "methods.h"

int main()
{
    std::string firstName = ConsoleAppCs::Methods::GetAString("What is your first name: ");

    ConsoleAppCs::Methods::ApplicationStartMessage(firstName);

    double x = ConsoleAppCs::Methods::GetADouble("Please enter your first number: ");
    double y = ConsoleAppCs::Methods::GetADouble("Please enter your second number: ");

    double result = ConsoleAppCs::Methods::Add(x, y);

    ConsoleAppCs::Methods::PrintResultMessage("The sum of " + std::to_string(x) + " and " + std::to_string(y) + " is " + std::to_string(result));

    std::cin.get();
    return 0;
}