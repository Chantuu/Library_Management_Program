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
    }
}
