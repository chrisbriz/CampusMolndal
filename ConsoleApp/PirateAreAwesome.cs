using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class PirateAreAwesome
    {
        public static void PirateSpeech()
        {
            string word;
            string pirateWorrrd = string.Empty;
            List<char> vowels;

            Console.WriteLine("Type in a word:");
            word = Console.ReadLine();

            //initiate list with vowels
            vowels = new List<char>()
            {
                'a','e','i','o','u','y','å','ä','ö','A','E','I','O','U','Y','Å','Ä','Ö'
            };

            Console.OutputEncoding = Encoding.UTF8;
            //Loop through list if there is a match
            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(word[i]) && char.IsLetter(word[i]))
                {
                    Console.OutputEncoding = Encoding.UTF8;
                    pirateWorrrd += word[i];
                }
                else if (char.IsLetter(word[i]))
                {
                    Console.OutputEncoding = Encoding.UTF8;
                    pirateWorrrd += word[i] + "o" + char.ToLower(word[i]);
                }
                else
                {
                    Console.OutputEncoding = Encoding.UTF8;
                    Console.WriteLine(word[i]);
                    pirateWorrrd += word[i];
                }
            }

            Console.WriteLine(pirateWorrrd);

            Console.ReadLine();

            Console.WriteLine("press Enter to return to main menu");
            Console.ReadLine();
            Console.Clear();
            Program.MainMenu();
        }
    }
}
