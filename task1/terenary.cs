using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Terenary
    {
        public static void main()
        {

            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            String result = age < 18 ? "You are minor" : "You are major";
            Console.WriteLine(result);

        }
    }
}
