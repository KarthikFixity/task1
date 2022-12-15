using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Twonumbersinfloat
    {
        static void main(string[] args)
        {
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            float firstnumber = Convert.ToSingle(x);
            float secondnumber = Convert.ToSingle(y);
            float result = (firstnumber * secondnumber);
            Console.WriteLine(result);
        }
    }
}
