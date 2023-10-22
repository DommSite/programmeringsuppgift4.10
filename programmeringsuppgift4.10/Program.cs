using System;

namespace inlämningsuppgift4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många X per grupp?");
            int antalx = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O per grupp?");
            int antalo = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur mågna O-mönster per rad?");
            int antalrep = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många rader?");
            int antalrader = int.Parse(Console.ReadLine());

            for (int a = 1; a <= antalrader; a++)
            {
                for (int b = 1; b <= antalrep; b++)
                {
                    for (int c = 1; c <= antalx; c++)
                    {
                        Console.Write("X");
                    }
                    Console.Write("-");
                    for (int d = 1; d <= antalo; d++)
                    {
                        Console.Write("O");
                    }
                    Console.Write("-");
                }
                for (int c = 1; c <= antalx; c++)
                {
                    Console.Write("X");
                }
                Console.WriteLine("");
            
            }
        }
    }
}
