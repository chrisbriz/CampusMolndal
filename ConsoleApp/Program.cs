using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            //bool valid = true;
            bool open = true;

            MainMenu();

            var cki = Console.ReadKey();

            do
            {
                if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
                {
                    Console.Clear();
                    ExerciseOne.Exercise();
                }

                if (cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.NumPad2)
                {
                    Console.Clear();
                    ExerciseTwo.DailyExercise();
                }

                if (cki.Key == ConsoleKey.D3 || cki.Key == ConsoleKey.NumPad3)
                {
                    Console.Clear();
                    ExerciseThree.SubMenu();
                }

                if (cki.Key == ConsoleKey.D4 || cki.Key == ConsoleKey.NumPad4)
                {
                    Console.Clear();
                    PirateAreAwesome.PirateSpeech();
                }

                if (cki.Key == ConsoleKey.D5 || cki.Key == ConsoleKey.NumPad5)
                {
                    Console.Clear();
                    ExerciseFour.SubMenu();
                }

                if (cki.Key == ConsoleKey.D0 || cki.Key == ConsoleKey.NumPad0)
                {
                    return;
                }

            } while (open == false);
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
            Console.WriteLine("0 - Exit");
        }
    }
}