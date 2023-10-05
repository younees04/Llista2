using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c;
            int cont = 0;

            Console.WriteLine("Escriu una paraula acabada en punt: ");
            c = (char)Console.Read();

            while (c != '.')
            {
                cont++;
                c = (char)Console.Read();
            }
            Console.WriteLine("El numero de caracters que te la paraula sense comptar el punt son: " + cont);
        }
    }
}
