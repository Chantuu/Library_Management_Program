namespace LibraryManagement.Application.Core
{
    internal static class Processes
    {
        private static string _incorrectInputError = "The input is incorrect. Please try again!";

        public static void DisplayMenuTitle(string title)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static string ShowUserInputPrompt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n Your input: ");

            string result = Console.ReadLine() ?? "";

            Console.ForegroundColor = ConsoleColor.White;
            return result;
        }

        public static void ShowNavigationText(string fullText, string prompt)
        {
            int promptTextIndex = fullText.IndexOf(prompt);

            if (promptTextIndex == -1)
            {
                throw new ArgumentException(" The provided prompt string was not found in the main text string. Please ensure that prompt string is present in main string.", "promptText");
            }

            string firstPart = fullText.Substring(0, promptTextIndex);
            string lastPart = fullText.Substring(promptTextIndex + prompt.Length);

            Console.Write(firstPart);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(prompt);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(lastPart);
        }

        public static void DisplayErrorMessage(string message)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void DisplayWarningMessage(string message)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ChooseNextMenu(string result, Action callerMethod, params Action[] menus)
        {
            int choice;

            if (int.TryParse(result, out choice) == true)
            {
                if (choice < 1 || choice > menus.Length)
                {
                    DisplayErrorMessage(_incorrectInputError);
                    callerMethod();
                    return;
                }

                for (int i = 1; i <= menus.Length; i++)
                {
                    Console.Clear();
                    menus[i - 1]();
                }
            }
            else
            {
                DisplayErrorMessage(_incorrectInputError);
                callerMethod();
            }
        }
    }
}
