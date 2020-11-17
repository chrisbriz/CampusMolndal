using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            bool open = true;
            bool valid = true;

            MainMenu();

            do
            {
                do
                {
                    var cki = Console.ReadKey();

                    do
                    {
                        if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
                        {
                            Console.Clear();
                            ExerciseOne();
                        }

                        if (cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.NumPad2)
                        {
                            Console.Clear();
                            DailyExercise();
                        }

                        if (cki.Key == ConsoleKey.D3 || cki.Key == ConsoleKey.NumPad3)
                        {
                            Console.Clear();
                            ExerciseTwo();
                        }

                        if (cki.Key == ConsoleKey.D4 || cki.Key == ConsoleKey.NumPad4)
                        {
                            Console.Clear();
                            ExerciseThree();
                        }

                        if (cki.Key == ConsoleKey.D0 || cki.Key == ConsoleKey.NumPad0)
                        {
                            return;
                        }
                    } while (valid == false);

                } while (valid == false);

            } while (open);

            Console.ReadLine();

        }

        static void MainMenu()
        {
            Console.Title = "Välkommen till övningarna";
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Choose which exercise to review: ");
            Console.WriteLine("1 - Exercise One");
            Console.WriteLine("2 - Daily Exercise 1");
            Console.WriteLine("3 - Exercise Two");
            Console.WriteLine("4 - Exercise Three");
            Console.WriteLine("0 - Exit");
        }

        static void ExerciseOne()
        {
            string firstString = "Hej";
            string secondString = "Goddag";
            string thirdString = "jag";
            string fourthString = "älskar";
            string fifthString = "kaffe";

            int firstInt = 1;
            int secondInt = 1;
            int thirdInt = 1;
            int fourthInt = 1;
            int fifthInt = 1;

            Console.WriteLine("Hello Robin!");
            Console.WriteLine(firstString + " " + firstInt);
            Console.WriteLine(secondString + " " + secondInt);
            Console.WriteLine(thirdString + " " + thirdInt);
            Console.WriteLine(fourthString + " " + fourthInt);
            Console.WriteLine(fifthString + " " + fifthInt);

            Console.WriteLine("Welcome to todays meeting Christopher, " + DateTime.Now);
            Console.WriteLine();

            Console.WriteLine("Type in your name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Type in your age:");
            string age = Console.ReadLine();
            Console.WriteLine("Type in your length:");
            string length = Console.ReadLine();
            Console.WriteLine("Type in the town where you live:");
            string town = Console.ReadLine();
            Console.WriteLine("Type in your hobby:");
            string hobby = Console.ReadLine();
            Console.WriteLine("Type in your superpower:");
            string superPower = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("name:" + " " + userName);
            Console.WriteLine("age:" + " " + age);
            Console.WriteLine("Lenght:" + " " + length);
            Console.WriteLine("Town of residence:" + " " + town);
            Console.WriteLine("Hobby:" + " " + hobby);
            Console.WriteLine("Superpower:" + " " + superPower);

            Console.WriteLine("press Enter to return to main menu");
            Console.ReadLine();
            Console.Clear();
            MainMenu();
        }

        static void DailyExercise()
        {
            Console.Title = "Min miniräknare";
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            int firstNumber;
            int secondNumber;

            Console.WriteLine("Välkommen till miniräknaren");
            Console.WriteLine("Vad vill du göra");
            Console.WriteLine("1. Addera två tal");
            Console.WriteLine("2. Sub två tal");
            Console.WriteLine("3. Multiplicera två tal");
            Console.WriteLine("4. Dividera två tal");
            Console.WriteLine("5. Returnera återstoden");
            Console.WriteLine("6. avsluta");

            var keyRead = Console.ReadKey();

            if (keyRead.Key == ConsoleKey.D6 || keyRead.Key == ConsoleKey.NumPad6)
            {
                Console.Beep(415, 500);
                Console.Clear();
                MainMenu();
            }

            if (keyRead.Key == ConsoleKey.D1 || keyRead.Key == ConsoleKey.NumPad1)
            {
                Console.Beep(415, 500);
                Console.WriteLine("Du valde +");
                Console.WriteLine("Skriv ditt första tal: ");
                firstNumber = int.Parse(Console.ReadLine());
                Console.Beep(415, 500);
                Console.WriteLine("Skriv ditt andra tal");
                secondNumber = int.Parse(Console.ReadLine());
                Console.Beep(415, 500);
                int sum = firstNumber + secondNumber;
                Console.WriteLine("summan blir" + " " + sum);

                Console.ReadLine();
                Console.Beep(415, 500);
                Console.Clear();
                DailyExercise();
            }

            if (keyRead.Key == ConsoleKey.D2 || keyRead.Key == ConsoleKey.NumPad2)
            {
                Console.Beep(415, 500);
                Console.WriteLine("Du valde -");
                Console.WriteLine("Skriv ditt första tal: ");
                firstNumber = int.Parse(Console.ReadLine());
                Console.Beep(415, 500);
                Console.WriteLine("Skriv ditt andra tal");
                secondNumber = int.Parse(Console.ReadLine());
                Console.Beep(415, 500);
                int sum = firstNumber - secondNumber;
                Console.WriteLine("resultat blir" + " " + sum);

                Console.ReadLine();
                Console.Beep(415, 500);
                Console.Clear();
                DailyExercise();
            }

            if (keyRead.Key == ConsoleKey.D3 || keyRead.Key == ConsoleKey.NumPad3)
            {
                Console.Beep(415, 500);
                Console.WriteLine("Du valde *");
                Console.WriteLine("Skriv ditt första tal: ");
                firstNumber = int.Parse(Console.ReadLine());
                Console.Beep(415, 500);
                Console.WriteLine("Skriv ditt andra tal");
                secondNumber = int.Parse(Console.ReadLine());
                Console.Beep(415, 500);
                int sum = firstNumber * secondNumber;
                Console.WriteLine("summan blir" + " " + sum);

                Console.ReadLine();
                Console.Beep(415, 500);
                Console.Clear();
                DailyExercise();
            }

            if (keyRead.Key == ConsoleKey.D4 || keyRead.Key == ConsoleKey.NumPad4)
            {
                Console.Beep(415, 500);
                Console.WriteLine("Du valde /");
                Console.WriteLine("Skriv ditt första tal: ");
                firstNumber = int.Parse(Console.ReadLine());
                Console.Beep(415, 500);
                Console.WriteLine("Skriv ditt andra tal");
                secondNumber = int.Parse(Console.ReadLine());
                Console.Beep(415, 500);
                int sum = firstNumber / secondNumber;
                Console.WriteLine("summan blir" + " " + sum);

                Console.ReadLine();
                Console.Beep(415, 500);
                Console.Clear();
                DailyExercise();
            }

            if (keyRead.Key == ConsoleKey.D5 || keyRead.Key == ConsoleKey.NumPad5)
            {
                Console.Beep(415, 500);
                Console.WriteLine("Du valde %");
                Console.WriteLine("Skriv ditt första tal: ");
                firstNumber = int.Parse(Console.ReadLine());
                Console.Beep(415, 500);
                Console.WriteLine("Skriv ditt andra tal");
                secondNumber = int.Parse(Console.ReadLine());
                Console.Beep(415, 500);
                int sum = firstNumber % secondNumber;
                Console.WriteLine("summan blir" + " " + sum);

                Console.ReadLine();
                Console.Beep(415, 500);
                Console.Clear();
                DailyExercise();
            }
        }

        static void ExerciseTwo()
        {
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int third = Convert.ToInt32(Console.ReadLine());

            int sum = first + second + third;
            Console.WriteLine(sum);


        }

        static void ExerciseThree()
        {
            int[] myArray = new int[3] { 10, 4, 8 };
            int i = 0;

            while (i < myArray.Length)
            {
                Console.WriteLine(myArray[i]);
                i++;
            }

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
            Console.WriteLine("press Enter to return to main menu");
            Console.ReadLine();
            Console.Clear();
            MainMenu();
        }
    }
}