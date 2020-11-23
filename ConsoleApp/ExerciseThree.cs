using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class ExerciseThree
    {
        public static void SubMenu()
        {
            bool open = true;
            Selection();
            var cki = Console.ReadKey();
            do
            {
                if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
                {
                    Console.Clear();
                    First();
                }

                if (cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.NumPad2)
                {
                    Console.Clear();
                    Second();
                }

                if (cki.Key == ConsoleKey.D0 || cki.Key == ConsoleKey.NumPad0)
                {
                    Console.Clear();
                    break;
                }
            } while (open == false);

            Program.MainMenu();
        }

        public static void Selection()
        {
            Console.WriteLine("Choose which exercise to review: ");
            Console.WriteLine("1 - First");
            Console.WriteLine("2 - Second");
            Console.WriteLine("0 - Return to main menu");
        }

        public static void First()
        {
            int[] myArray = new int[3] { 10, 4, 8 };

            int n = 0;

            while (n < myArray.Length)
            {
                Console.WriteLine(myArray[n]);
                n++;
            }

            Console.WriteLine("");

            SubMenu();
        }

        public static void Second()
        {

            List<string> myList = new List<string>();
            bool keepGoing = false;

            do
            {
                Console.WriteLine("Skriv in ett namn: ");
                string name = Console.ReadLine();

                if (!String.IsNullOrEmpty(name))
                {
                    myList.Add(name);
                    keepGoing = true;
                }
                Console.WriteLine("Vill du lägga en till? (Y or N)");
                string c = Console.ReadLine();
                if (c == "Y" || c == "y")
                {
                    keepGoing = false;
                }
            } while (keepGoing == false);

            myList.ForEach(Console.WriteLine);

            Console.WriteLine("");

            Console.WriteLine("Type in your name: ");
            string yourName = Console.ReadLine();
            char[] charArray = yourName.ToCharArray();
            Array.Reverse(charArray);
            charArray[0] = char.ToUpper(charArray[0]);
            charArray[charArray.Length - 1] = char.ToLower(charArray[charArray.Length - 1]);
            yourName = new string(charArray);

            List<string> myNameList = new List<string>();
            myNameList.Add(yourName);

            foreach (var item in myNameList)
            {
                Console.WriteLine(item);
            }            

            Console.WriteLine("press Enter to return to main menu");
            Console.ReadLine();
            Console.Clear();
            SubMenu();
        }
    }
}
