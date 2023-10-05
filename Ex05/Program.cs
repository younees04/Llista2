using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int num, prev1 = 0, prev2 = 0;
            int introductions = 0;

            Console.WriteLine("Entra els números: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (prev1 + prev2 < num)
            {
                introductions++;
                prev1 = prev2;
                prev2 = num;
                num = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"La suma de {prev1} i {prev2} és més gran que {num}");
            Console.WriteLine($"Número d'introduccions: {introductions}");
        }
    }

}
