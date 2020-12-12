using System;
using System.Collections.Generic;

namespace task._7
{
    internal class Program
    {
        private static List<string> strings = new List<string>(150);

        private static void DisplayPage(int pageNumber)
        {
            if (pageNumber > 0)
            {
                for (var i = 0; i < 5 && (pageNumber - 1) * 5 + i < strings.Count; i++)
                {
                    Console.Out.WriteLine(strings[(pageNumber - 1) * 5 + i]);
                }

                return;
            }
            Console.Out.WriteLine("You entered a non-positive number. Try anything else.");
        }

        private static void Main(string[] args)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var randomNumber = new Random();

            for (var i = 0; i < 150; i++)
                strings.Add(
                    new string(
                        new[]
                        {
                            chars[randomNumber.Next(0, 26)],
                            chars[randomNumber.Next(0, 26)],
                            chars[randomNumber.Next(0, 26)],
                            chars[randomNumber.Next(0, 26)]
                        }
                    )
                );

            Console.Out.WriteLine($"Before formatting: {strings.Count}");
            strings.RemoveAll(s => s[0] == 'Z');
            var withoutDuplicates = new HashSet<string>(strings);
            strings = new List<string>(withoutDuplicates);
            withoutDuplicates.Clear();
            strings.Sort((s1, s2) => string.Compare(s2, s1, StringComparison.InvariantCultureIgnoreCase));

            Console.Out.WriteLine($"After formatting: {strings.Count}");

            while (true)
            {
                try
                {
                    Console.Out.Write("Enter page number: ");
                    DisplayPage(int.Parse(Console.ReadLine()));
                }
                catch (FormatException)
                {
                    return;
                }
            }
        }
    }
}