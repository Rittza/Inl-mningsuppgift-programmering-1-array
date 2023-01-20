using System;
namespace Inlämningsuppgift
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur många meningar vill du skriva in?");
            int antal = int.Parse(Console.ReadLine());
            string[] mening = new string[antal];
            for(int i = 0; i < antal; i++)
            {
                Console.WriteLine("Skriv in en mening");
                mening[i] = Console.ReadLine();
            }
            Console.WriteLine("Detta är dina meningar");
            for(int i = 0; i < antal; i++)
            {
                Console.WriteLine(mening[i]);
            }
        }
    }
}