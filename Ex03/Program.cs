using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sig = 9999;
            bool trobat = false;

            Console.WriteLine("Escriu un numero acabat en 0: ");
            num = Convert.ToInt32(Console.ReadLine());          

            while(sig !=0)
            {
                if(num < sig) trobat = true;

                num = sig;
                sig = Convert.ToInt32(Console.ReadLine());
            }

            if (trobat) Console.WriteLine("Es creixent");

            else Console.WriteLine("No es creixent");
        }
    }
}
