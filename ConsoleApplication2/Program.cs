using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hjufveqagqf
{
    class Program
    {
        static void Main(string[] args)
        {
            //övning1
            Console.WriteLine("skriv in mönsterdjup:");
            double tal1 = double.Parse(Console.ReadLine());


            if (tal1 > 1.6)
            {
                Console.WriteLine("Lagligt däck!");
            }
            else
            {
                Console.WriteLine("du fuck up");
            }

            Console.ReadKey();
        }
    }
}




