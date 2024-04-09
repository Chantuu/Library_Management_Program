namespace LibraryManagement.Application.Core
{
    internal static class Menus
    {
        private static string _mainMenuTitle = "\n***************     Main Menu     ***************\n";
        private static string _addNewBookMenuTitle = "\n***************     Add New Book     ***************\n";

        public static void MainMenu()
        {
            Processes.DisplayMenuTitle(_mainMenuTitle);

            Console.WriteLine("  Welcome to the application, please choose what \n operation would you like to perform:\n");
            Console.WriteLine(" 1. Search The Books");
            Console.WriteLine(" 2. Add New Book");
            Console.WriteLine(" 3. Remove The Book");
            Console.WriteLine(" 4. Update The Book");
            Console.WriteLine(" 5. Exit The Program");

            string result = Processes.ShowUserInputPrompt();
        }

        public static void AddNewBookMenuTitle()
        {
            Processes.DisplayMenuTitle(_addNewBookMenuTitle);

            Console.WriteLine(" Please input the title of the new book");

            Processes.ShowNavigationText(" (Please type cancel to abort the operation):", "cancel");

            string result = Processes.ShowUserInputPrompt();
        }
    }
}
