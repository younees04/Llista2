using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nums, n;
            int n1=0, n2=0;

            Console.WriteLine("Entra els numeros que hi haura: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriu els numeros: ");

            for (int i = 0;  i < n; i++) 
            {
                nums = Convert.ToInt32(Console.ReadLine());

                if (nums % 3 == 0)
                {
                    n1++;
                }

                if(nums >= 5)
                {
                    n2++;
                }
            }
            if (n1 > 0 )
                Console.WriteLine("Multiples de 3: " + n1);

            else
                Console.WriteLine("No hi ha cap");

            if (n2 > 0)
                Console.WriteLine("Mes grans o iguals a 5: " + n2);

            else
                Console.WriteLine("No hi ha cap");

        }
    }
}
