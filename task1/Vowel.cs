using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Vowel
    {
        public static void main()
        {
            int result = 0;
            Console.WriteLine("enter string ;");//karthik
            string str = Console.ReadLine();
            int l = str.Length;
            for (int i = 0; i<l; i++)
            {
                if (str[i].Equals("a")|| str[i].Equals("e")|| str[i].Equals("i")|| str[i].Equals("o")|| str[i].Equals("u")) {
                    result = result + 1;
                } else
                {
                    result = result + 2;
                }
            }

            Console.WriteLine(result);

            
        }
            }
}
