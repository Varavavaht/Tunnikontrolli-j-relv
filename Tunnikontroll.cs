using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnikontrolli_järelvastamine
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();
            bool sisestamine = true;

            while (sisestamine)
            {
                Console.Write("Sisesta midagi:");
                string sisestus = Console.ReadLine();
                list.Add(sisestus);

                Console.WriteLine("Kas sa tahad veel midagi sisestada?");
                Console.WriteLine("Kui  EI, siis vajuta nr 9");
                Console.WriteLine("Kui JAH, siis vajuta suvalist nr-it");

                ConsoleKeyInfo input = Console.ReadKey();
                Console.WriteLine();
                int sisend2 = int.Parse(input.KeyChar.ToString());

                

                if (sisend2 == 9)
                {
                    break;
                }
                Console.Clear();
            }
            var result = String.Join(", ", list.ToArray());
            Console.WriteLine("Sinu sisestatud andmed olid:");
            Console.WriteLine("[{0}]", string.Join(", ", list));

            Random rnd = new Random();
            int indeks = rnd.Next(list.Count);
            string valitu = list[indeks];

            Console.WriteLine("Valin neist välja suvalise: " + valitu);
            Console.ReadLine();



            //    võtab vastu portsu tekste, kuni ta paneb mingi märgi, et rohkem ei sisesta.
            //        Seejärel prindib arvuti kõik välja ja valime lõpuks ühe välja
            //
        }
    }
}
