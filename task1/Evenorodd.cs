using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Evenorodd
    {
        static void main(string[]args)
        {
            string x = Console.ReadLine();
            int number = Convert.ToInt32(x);
            if (number % 2 == 0)
            {
                Console.WriteLine("it is an even number");
            }

            else
            {
                Console.WriteLine("it is an odd number");
            }
        }
        
        
        

        
    }
}
