using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase="";
            char c;

            Console.WriteLine("Escriu la frase amb espais: ");
            c = Convert.ToChar(Console.Read());

            while(c != '.')
            {
                if (c != ' ')
                    frase = frase + c;

                c = Convert.ToChar(Console.Read());
            }
            Console.WriteLine(frase);

        }

    }
}
