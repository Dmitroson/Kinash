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
            string CheckArr = "aeiouy";
            var counter = 0;

            string str = s.ToLower();

            for(var i = 0; i < CheckArr.Length; i++)
            {
                for(var j = 0; j < str.Length; j++)
                {
                    if (CheckArr[i] == str[j])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
            Console.ReadKey();
        }
    }
}
