using System;

namespace MVC_Countries_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while (again == true)
            {
                CountryController cc = new CountryController();
                cc.WelcomeAction();
                again = GoAgain();
            }
        }

        public static bool GoAgain()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Would you like to learn about another Country? Y/N\n");
            string input = Console.ReadLine();

            if (input.ToUpper() == "Y" || input.ToUpper() == "YES")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Clear();
                return true;
            }
            else if (input.ToUpper() == "N" || input.ToUpper() == "NO")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Must input a valid response.");
                return GoAgain();
            }
        }
    }
}
