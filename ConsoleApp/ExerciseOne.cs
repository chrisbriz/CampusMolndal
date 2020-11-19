using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class ExerciseOne
    {
        public static void Exercise()
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
            Program.Main(null);
        }
    }
}
