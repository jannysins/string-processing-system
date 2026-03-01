using System;
using StringProcessingApp.Services;

namespace StringProcessingApp.Views
{
    public class StringView
    {
        private readonly StringService _stringService;

        public StringView()
        {
            _stringService = new StringService();
        }

        public void Run()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\n=============================");
                Console.WriteLine("  String Processing System");
                Console.WriteLine("=============================");
                Console.WriteLine("1. Enter Text");
                Console.WriteLine("2. View Current Text");
                Console.WriteLine("3. Convert to UPPERCASE");
                Console.WriteLine("4. Convert to lowercase");
                Console.WriteLine("5. Count Characters");
                Console.WriteLine("6. Check if Contains Word");
                Console.WriteLine("7. Replace Word");
                Console.WriteLine("8. Extract Substring");
                Console.WriteLine("9. Trim Spaces");
                Console.WriteLine("10. Reset Text");
                Console.WriteLine("11. Exit");
                Console.WriteLine("=============================");
                Console.Write("Choose an option (1-11): ");
                
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("\nEnter new text: ");
                        string input = Console.ReadLine();
                        _stringService.SetText(input);
                        Console.WriteLine("Text saved successfully.");
                        break;
                    case "2":
                        Console.WriteLine($"\nCurrent Text: '{_stringService.GetCurrentText()}'");
                        break;
                    case "3":
                        _stringService.ConvertToUppercase();
                        Console.WriteLine("\Text converted to UPPERCASE.");
                        break;
                    case "4":
                        _stringService.ConvertToLowercase();
                        Console.WriteLine("\nText converted to lowercase.");
                        break;
                    case "5":
                        Console.WriteLine($"\nTotal characters: {_stringService.CountCharacters()}");
                        break;
                    case "6":
                        Console.Write("\nEnter word to search for: ");
                        string searchWord = Console.ReadLine();
                        bool exists = _stringService.CheckIfContains(searchWord);
                        Console.WriteLine(exists ? "The text CONTAINS the word." : "The text DOES NOT contain the word.");
                        break;
                    case "7":
                        Console.Write("\nEnter word to replace: ");
                        string oldWord = Console.ReadLine();
                        Console.Write("Enter the new word: ");
                        string newWord = Console.ReadLine();
                        _stringService.ReplaceWord(oldWord, newWord);
                        Console.WriteLine("\nWord replacement executed.");
                        break;
                    case "8":
                        try
                        {
                            Console.Write("\nEnter start index: ");
                            int start = int.Parse(Console.ReadLine());
                            Console.Write("Enter length to extract: ");
                            int length = int.Parse(Console.ReadLine());
                            _stringService.ExtractSubstring(start, length);
                            Console.WriteLine("Substring extraction executed.");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\n[Error] Please enter valid numeric values for index and length.");
                        }
                        break;
                    case "9":
                        _stringService.TrimSpaces();
                        Console.WriteLine("\nLeading and trailing spaces trimmed.");
                        break;
                    case "10":
                        _stringService.ResetToOriginal();
                        Console.WriteLine("\nText reset to its original state.");
                        break;
                    case "11":
                        isRunning = false;
                        Console.WriteLine("\nExiting the String Processing System. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("\n[Error] Invalid option. Please select a number between 1 and 11.");
                        break;
                }
            }
        }
    }
}
