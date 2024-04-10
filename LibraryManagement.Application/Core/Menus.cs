namespace LibraryManagement.Application.Core
{
    internal static class Menus
    {
        private static string _mainMenuTitle = "\n***************     Main Menu     ***************\n";
        private static string _addNewBookMenuTitle = "\n***************     Add New Book     ***************\n";

        private static string _cancelPrompt = " (Please type cancel to abort the operation):";

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

            Processes.ChooseNextMenu(result, MainMenu, AddNewBookMenuTitle);
        }

        public static void AddNewBookMenuTitle()
        {
            Processes.DisplayMenuTitle(_addNewBookMenuTitle);

            Console.WriteLine(" Please input the title of the new book");

            Processes.ShowNavigationText(_cancelPrompt, "cancel");

            string result = Processes.ShowUserInputPrompt();
        }

        public static string AddNewBookMenuAuthor(string title)
        {
            Processes.DisplayMenuTitle(_addNewBookMenuTitle);

            Console.WriteLine($" Title: {title}");
            Console.WriteLine(" Please input the author of the new book");

            Processes.ShowNavigationText(_cancelPrompt, "cancel");

            string result = Processes.ShowUserInputPrompt();
            
            return result;
        }

        public static string AddNewBookMenuGenre(string title, string author)
        {
            Processes.DisplayMenuTitle(_addNewBookMenuTitle);

            Console.WriteLine($" Title: {title}");
            Console.WriteLine($" Author: {author}");
            Console.WriteLine(" Please input the genre of the new book");

            Processes.ShowNavigationText(_cancelPrompt, "cancel");

            string result = Processes.ShowUserInputPrompt();
            
            return result;
        }
    }
}
