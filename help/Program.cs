using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    class Program
    {
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
            Console.ReadKey();
        }
    }
}
