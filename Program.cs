namespace Strings_Mangum_Stephen
{
    using System;

    class Program
    {
        static void Main()
        {
            // Prompt user to enter a character
            Console.Write("Enter a single character: ");
            char myChar = Console.ReadKey().KeyChar; // Get the character input
            bool isLetter = Char.IsLetter(myChar); // Check if it's a letter

            // Print result with a new line before it
            Console.WriteLine($"\n{myChar} is a letter: {isLetter}");

            // Prompt user to enter a string
            Console.Write("\nEnter a string of words: ");
            string string1 = Console.ReadLine();

            // Prompt user to enter a word to search for
            Console.Write("Enter a single word to search for: ");
            string string2 = Console.ReadLine();

            // Check if the word exists in the string
            bool containsWord = string1.Contains(string2, StringComparison.OrdinalIgnoreCase);

            // Print result
            Console.WriteLine($"\n\"{string2}\" exists in \"{string1}\": {containsWord}");
        }
    }

}