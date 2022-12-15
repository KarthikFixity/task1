using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Dollerstocent
    {
        static void main(string[] args)
        {
            string x = Console.ReadLine();
            int doller = Convert.ToInt32(x);
            int cents = doller * 100;
            Console.WriteLine(doller + "is equal to" + cents);
        }
    }
}
