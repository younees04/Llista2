using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool trobat = false;

            Console.WriteLine("Entra els valors que acabi en 0 per finalitzar: ");
            num = Convert.ToInt32(Console.ReadLine());

            try
            {
                while (num != 0)
                {
                    if (num < 0)
                    {
                        trobat = true;

                    }
                    num = Convert.ToInt32(Console.ReadLine());
                }


                if (trobat)
                    Console.WriteLine("Hi ha numeros negatius");

                else Console.WriteLine("Nomes hi han numeros positius");
            }

            catch (FormatException)
            {
                Console.WriteLine("No has posat un 0 per finalitzar");
            }

        }
    }
}
