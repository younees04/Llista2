using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    internal class Program
    {
            static void Main(string[] args)
            {
                int num;

                Console.WriteLine("Escriu un numero: ");
                num = Convert.ToInt32(Console.ReadLine());

                bool esprimer = true;

                if (num <= 1)
                {
                    esprimer = false;
                }
                else
                {
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            esprimer = false;
                            break;
                        }
                    }
                }

                if (esprimer)
                {
                    Console.WriteLine("Es un numero primer");
                }
                else
                {
                    Console.WriteLine("No es un numero primer");
                }
            }
    }
}
