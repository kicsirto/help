using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    class Program
    {
       static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Szia hogy hívnak");
            var n = Console.ReadLine();
            Console.WriteLine("milyen szép a szemed {n}");
            Console.WriteLine("szeretel phoghamozni");
            var v = Console.ReadLine();
            if (v.ToLower() == "igen" )
            {
                Console.WriteLine("az fasza");
            }
            else
            {
                Console.WriteLine("nem vagyunk barátok");
            }
            Console.WriteLine("nesze itt van 100 csillag");
            for (int i = 0; i < 100; i++)
            {
                Console.SetCursorPosition(rnd.Next(Console.WindowWidth),rnd.Next(Console.WindowHeight));
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 14);
                Console.Write("*");
            }
            Console.ReadKey();
        }
    }
}
