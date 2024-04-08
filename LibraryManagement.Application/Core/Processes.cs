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
            Console.Write("\nYour input: ");

            string result = Console.ReadLine() ?? "";

            Console.ForegroundColor = ConsoleColor.White;
            return result;
        }

        public static void DisplayErrorMessage(string message)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{message}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
