using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.GetEncoding(1200);
            Console.OutputEncoding = Encoding.GetEncoding(1200);

            int[] myArray = SorteraTreTal(1, 2, 3);
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            MainMenu();

        }

        static int[] SorteraTreTal(int a, int b, int c)
        {

            int[] talArray = new int[] { a, b, c };
            Array.Sort(talArray);
            return talArray;
        }

        public static void MainMenu()
        {
            Console.Title = "Välkommen till övningarna";
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Choose which exercise to review: ");
            Console.WriteLine("1 - Exercise One");
            Console.WriteLine("2 - Exercise Two");
            Console.WriteLine("3 - Exercise Three");
            Console.WriteLine("4 - Pirate Speech");
            Console.WriteLine("5 - Exercise Four");
            Console.WriteLine("6 - Exercise Five");
            Console.WriteLine("0 - Exit");

            bool open = true;

            var cki = Console.ReadKey();

            do
            {
                switch (cki.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        ExerciseOne.Exercise();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        ExerciseTwo.DailyExercise();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        ExerciseThree.SubMenu();
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.Clear();
                        PirateAreAwesome.PirateSpeech();
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Console.Clear();
                        ExerciseFour.SubMenu();
                        break;

                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        Console.Clear();
                        ExerciseFive.SubMenu();
                        break;

                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                        break;
                }

                //Motsvarighet till switch statement
                //if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
                //{
                //    Console.Clear();
                //    ExerciseOne.Exercise();
                //}

                //if (cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.NumPad2)
                //{
                //    Console.Clear();
                //    ExerciseTwo.DailyExercise();
                //}

                //if (cki.Key == ConsoleKey.D3 || cki.Key == ConsoleKey.NumPad3)
                //{
                //    Console.Clear();
                //    ExerciseThree.SubMenu();
                //}

                //if (cki.Key == ConsoleKey.D4 || cki.Key == ConsoleKey.NumPad4)
                //{
                //    Console.Clear();
                //    PirateAreAwesome.PirateSpeech();
                //}

                //if (cki.Key == ConsoleKey.D5 || cki.Key == ConsoleKey.NumPad5)
                //{
                //    Console.Clear();
                //    ExerciseFour.SubMenu();
                //}

                //if (cki.Key == ConsoleKey.D6 || cki.Key == ConsoleKey.NumPad6)
                //{
                //    Console.Clear();
                //    ExerciseFive.SubMenu();
                //}

                //if (cki.Key == ConsoleKey.D0 || cki.Key == ConsoleKey.NumPad0)
                //{
                //    break;
                //}

            } while (open == false);

            Environment.Exit(1);
        }
    }
}