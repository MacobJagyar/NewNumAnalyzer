
bool loopChoice = true;
string loopAnswer;


while (loopChoice)
{
    bool validInput = false;
    int userNumber = 0;

    while (!validInput)
    {
        Console.Write("Please enter a number between 1 and 100: ");
        string userInput = Console.ReadLine();


        if (IsNum(userInput) && IsInRange(userInput, 1, 100))
        {
            userNumber = int.Parse(userInput);
            validInput = true;
        }
        else
        {
            Console.WriteLine("\nInvalid input. Please enter a number between 1 and 100.");
            Thread.Sleep(1500);
            Console.Clear();
        }
    }

        if (userNumber < 60 && userNumber % 2 != 0)
        {
            Console.WriteLine("\nOdd and less than 60");
        }
        else if (userNumber >= 2 && userNumber <= 24 && userNumber % 2 == 0)
        {
            Console.WriteLine("\nEven and less than 25.");
        }
        else if (userNumber >= 26 && userNumber <= 60 && userNumber % 2 == 0)
        {
            Console.WriteLine("\nEven and between 26 and 60 inclusive");
        }
        else if (userNumber > 60 && userNumber % 2 == 0)
        {
            Console.WriteLine("\n" + userNumber + " - even and greater than 60");
        }
        else if (userNumber > 60 && userNumber % 2 != 0)
        {
            Console.WriteLine("\n" + userNumber + " - odd and greater than 60");
        }

        Console.WriteLine("\nWould you like to try another number? Y/N");
        loopAnswer = Console.ReadLine().ToUpper();

        if (loopAnswer == "Y")
        {
            Console.WriteLine("\nRestarting...");
            Thread.Sleep(1500);
            Console.Clear();

        }
        else if (loopAnswer == "N")
        {
            Console.WriteLine("\nGoodbye!");
            loopChoice = false;
        }
        else
        {
            Console.WriteLine("\nThat was neither Y or N. Restarting anyway...");
            Thread.Sleep(1500);
            Console.Clear();
        }

    }


    static bool IsNum(string input)
    {
        return int.TryParse(input, out _);
    }

    static bool IsInRange(string input, int min, int max)
    {
        if (IsNum(input))
        {
            int number = int.Parse(input);
            return number >= min && number <= max;
        }
        return false;
    }

