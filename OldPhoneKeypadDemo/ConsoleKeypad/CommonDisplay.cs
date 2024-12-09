using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleKeypad
{
    public class CommonDisplay
    {
        // Declare and initialize a Dictionary<char, string>
        static Dictionary<char, string> charStringDictionary = new Dictionary<char, string>
{
    { '2', "abc" },
    { '3', "def" },
    { '4', "ghi" },
    { '5', "jkl" },
    { '6', "mno" },
    { '7', "pqrs" },
    { '8', "tuv" },
    { '9', "wxyz" },
    {'*',"*" }
};

        public CommonDisplay()
        {

        } 
        public static string OldPhonePad(string input)
        {
            try
            {
                var output = new StringBuilder();
                string[] strArray = input.Split(" "); // Split input by spaces

                foreach (var item in strArray)
                {
                    char[] charArray = item.ToCharArray(); // Convert each word into a char array

                    // If the item is a single character, process it
                    if (charArray.Length == 1)
                    {
                        ProcessSingleCharacter(charArray[0], output);
                    }
                    else
                    {
                        // Loop through characters to process repeated ones
                        ProcessMultipleCharacters(charArray, output);
                    }
                }

                return output.ToString().ToUpper();
            }
            catch (Exception ex)
            {
                // Log the error for debugging purposes and then throw
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        private static void ProcessSingleCharacter(char character, StringBuilder output)
        {
            if (charStringDictionary.TryGetValue(character, out string letters))
            {
                output.Append(letters[0]); // Append the first letter (since there's only one character)
            }
        }
        private static void ProcessMultipleCharacters(char[] charArray, StringBuilder output)
        {
            string checkingChar = "";

            for (int i = 0; i < charArray.Length; i++)
            {
                // If current char matches the next one, add it to checkingChar
                if (i < charArray.Length - 1 && charArray[i] == charArray[i + 1])
                {
                    checkingChar += charArray[i];
                }
                else
                {
                    checkingChar += charArray[i];
                    // Process the collected sequence
                    if (checkingChar.Length > 0)
                    {
                        AppendCharacterFromDictionary(checkingChar.Length, checkingChar[0], output);
                        checkingChar = ""; // Reset the checkingChar for the next sequence
                    } 
                }
            }
        }
        private static void AppendCharacterFromDictionary(int count, char character, StringBuilder output)
        {
            if (charStringDictionary.TryGetValue(character, out string letters))
            {
                int adjustedCount = count - 1;

                // If * is found, remove the last character from output
                if (letters == "*")
                {
                    if (output.Length > 0)
                        output.Remove(output.Length - 1, 1);
                }
                else
                {
                    int letterIndex = adjustedCount % letters.Length;
                    output.Append(letters[letterIndex]);
                }
            }
        }
    }
}
