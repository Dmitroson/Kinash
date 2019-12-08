using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinash_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string CheckArr;
            for(var i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]);
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
