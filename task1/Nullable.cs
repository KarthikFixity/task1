using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Nullable
    {
        static void main(string[] args)
        {
            byte? byte_ = null;
            float? float_ = null;
            int? x = null;
            short? str_ = null;
            double? D = null;
            Console.WriteLine(byte_);
            Console.WriteLine(float_);
            Console.WriteLine(x);
            Console.WriteLine(str_);
            Console.WriteLine(D);
            var x1 = 58;
            Console.WriteLine(x1);
            var x2 = 25;
            Console.WriteLine(x2);
            dynamic d = 258;
            dynamic z = 628;
            dynamic k = d - z;
            object a1 = 10;
            object a2 = 250;
            object a3 = Convert.ToInt32(a1) + Convert.ToInt32(a2);

            

        }
    }
}
