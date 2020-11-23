using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class ExerciseTwo
    {
        public static void DailyExercise()
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

            var open = true;
            var keyRead = Console.ReadKey();

            do
            {
                if (keyRead.Key == ConsoleKey.D6 || keyRead.Key == ConsoleKey.NumPad6)
                {
                    Console.Beep(415, 500);
                    Console.Clear();
                    break;
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
            } while (open == false);

            Program.MainMenu();
        }
    }
}
