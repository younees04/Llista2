using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nums, n, petit = int.MaxValue;
            int pos = 0;

            Console.WriteLine("Entra cuants numeros posaras: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entra els numeros: ");

            for(int i = 0; i < n; i++) 
            {
                nums = Convert.ToInt32(Console.ReadLine());

                if (nums < petit)
                {
                    petit = nums;
                    pos = i +1;
                }                 
            }
            Console.WriteLine("El numero mes petit és: " + petit);
            Console.WriteLine("Esta en la posicio " + pos);
        }
    }
}
