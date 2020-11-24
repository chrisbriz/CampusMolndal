using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class ExerciseFive
    {
        public static void SubMenu()
        {
            bool open = true;
            Selection();
            var ki = Console.ReadKey();
            do
            {
                if (ki.Key == ConsoleKey.D1 || ki.Key == ConsoleKey.NumPad1)
                {
                    Console.Clear();
                    First();
                }

                //if (ki.Key == ConsoleKey.D2 || ki.Key == ConsoleKey.NumPad2)
                //{
                //    Console.Clear();
                //    Second();
                //}

                //if (ki.Key == ConsoleKey.D3 || ki.Key == ConsoleKey.NumPad3)
                //{
                //    Console.Clear();
                //    Third();
                //}

                if (ki.Key == ConsoleKey.D0 || ki.Key == ConsoleKey.NumPad0)
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
            Console.WriteLine("3 - Third");
            Console.WriteLine("0 - Return to main menu");
        }

        public static void First()
        {
            List<string> buddies = new List<string>();
            buddies.Add("Robin");
            buddies.Add("Tove");
            buddies.Add("Elias");
            buddies.Add("Johan");
            buddies.Add("Robert");
            buddies.Add("Viktor");
            buddies.Add("Oskar");

            foreach (var buddy in buddies)
            {
                Console.WriteLine("Hej {0}", buddy);
            }
            Console.WriteLine("Press enter to return to previous menu");
            Console.ReadLine();
            Console.Clear();
            SubMenu();
        }

        public static void Second()
        {

        }
    }
}
