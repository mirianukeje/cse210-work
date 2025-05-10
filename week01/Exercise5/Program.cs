using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        // The program will ask the user for their name and favorite number
        // It will then compute the square of the number and display the result

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    // This method prompts the user for their name
    // It returns the name as a string

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    // This method prompts the user for their favorite number
    // It returns the number as an integer

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    // This method computes the square of a number

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    // This method displays the result to the user
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"Hello {name}, the square of your number is {square}");
    }
}