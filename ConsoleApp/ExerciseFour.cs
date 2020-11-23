using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class ExerciseFour
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

                if (ki.Key == ConsoleKey.D2 || ki.Key == ConsoleKey.NumPad2)
                {
                    Console.Clear();
                    Second();
                }

                if (ki.Key == ConsoleKey.D3 || ki.Key == ConsoleKey.NumPad3)
                {
                    Console.Clear();
                    Third();
                }

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
            Console.WriteLine("0 - Return to main menu");
        }

        public static void First()
        {
            List<string> myList;

            myList = new List<string>()
            {
                "February",
                "Mars",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November"
            };

            //Do While
            int countDoWhile = 0;
            Console.WriteLine("do...while-loop");
            do
            {
                Console.WriteLine(myList[countDoWhile]);
                countDoWhile++;
            } while (countDoWhile < myList.Count);

            Console.ReadLine();

            //While
            int countWhile = 0;
            Console.WriteLine("while-loop");
            while (countWhile < myList.Count)
            {
                Console.WriteLine(myList[countWhile]);
                countWhile++;
            }

            Console.ReadLine();

            //For
            Console.WriteLine("For-loop");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.ReadLine();
            Console.WriteLine("Press Enter to return to menu");
            SubMenu();
        }

        public static void Second()
        {
            char[] persNum = new char[10] { '8', '5', '0', '9', '0', '8', '7', '8', '7', '7' };
            Random rnd = new Random();
            Console.WriteLine(persNum);

            for (int i = 6; i < persNum.Length; i++)
            {
                string myInt = rnd.Next(0, 9).ToString();
                persNum[i] = char.Parse(myInt);
            }

            Console.WriteLine(persNum);
            Console.ReadLine();
            Console.WriteLine("Press Enter to return to menu");
            SubMenu();
        }

        public static void Third()
        {
            List<string> story;

            story = new List<string>()
            {
                "Det var en gång ",
                "som gick till ",
                "och sedan ",
                "snipp snapp snutt, så var sagan slut."
            };

            Console.WriteLine("Complete the story as it goes");
            for (int i = 0; i < story.Count; i+=2)
            {
                Console.WriteLine(story[i]);
                string storyPart = Console.ReadLine();

                story.Insert(i + 1, storyPart);
            };

            Console.WriteLine("your full story is: ");
            Console.WriteLine(story);
        }
    }
}

