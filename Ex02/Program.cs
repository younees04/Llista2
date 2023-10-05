using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c;
            int cont = 0;
            bool trobat=false;

            Console.WriteLine("Escriu una paraula acabada en punt: ");
            c = (char)Console.Read();

            
            while (c != '.')
            {
                if (c == 'a' || c== 'A') trobat = true;

                if(trobat ) cont++;

                c = (char)Console.Read();
            }
            Console.WriteLine("El numero de caracters que te la paraula sense comptar el punt son: " + cont);
        }
    }
}
