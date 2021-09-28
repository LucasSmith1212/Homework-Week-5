using System;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 8;
            int r, j;
            double headCount = 0;
            double tailCount = 0;
            
            Console.WriteLine("Enter 8 coin toss results");
            char[] tosses = new char[7];
            for (int i = 0; i < 7; i++) {
                tosses[i] = Convert.ToChar(Console.ReadLine());
            }
            int n = 1;
            foreach (char toss in tosses)
            {
                Console.WriteLine("Toss: " + n + ": " + toss);
                n++;
            }

            for (j = 0; j < num; j++)
            {
                if (tosses[j] == 'h')
                {
                    headCount++;
                    break;
                } else if (tosses[j] == 't')
                {
                    tailCount++;
                    break;
                }
            }
            
            double total = headCount + tailCount;
            double headsPercent = headCount / total * 100;
            double tailsPercent = tailCount / total * 100;

            Console.WriteLine("Heads: " + headsPercent + "%.");
            Console.WriteLine("Tails: " + tailsPercent + "%.");
        }
    }
}
