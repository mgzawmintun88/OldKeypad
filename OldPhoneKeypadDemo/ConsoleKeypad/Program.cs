// See https://aka.ms/new-console-template for more information
using ConsoleKeypad;

bool continueRunning = true;
char[] validChars = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '*', '#', ' ' };

while (continueRunning)
{
    Console.Clear();
    Console.SetCursorPosition(0, 0);

    // Prompt user to enter some text
    Console.WriteLine("Enter a string:");

    // Read user input
    string userInput = Console.ReadLine();

    // Check if all characters in user input are valid
    if (!string.IsNullOrEmpty(userInput) && userInput.All(c => validChars.Contains(c)))
    {
        if (userInput.Contains("#"))
        {
            string strOutput = CommonDisplay.OldPhonePad(userInput);
            // Show the character on the screen only if it's valid
            Console.WriteLine($"Your string: '{strOutput}'");
        }
        else
        {
            Console.WriteLine("Please key in # at the end of every input.");
        }
    }
    else
    {
        // If invalid, show an error message
        Console.WriteLine($"Invalid character in: '{userInput}'");
    }

    // Ask the user whether they want to continue or exit
    Console.WriteLine("Do you want to continue? (Y/N):");
    string userChoice = Console.ReadLine()?.Trim().ToUpper();

    // Check if the user wants to continue
    if (userChoice != "Y")
    {
        continueRunning = false;
        Console.WriteLine("Exiting the program...");
    }
}
