using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            //7-1
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text); //問題7.1.1

        }
        static void Exercise1_1(string text)
        {
            var dict = new Dictionary<char, int>();

            foreach (var ch in text.ToUpper())
            {
                if ('A' <= ch && ch <= 'Z')
                {
                    if (dict.ContainsKey(ch))
                    {
                        dict[ch] += 1;
                    }
                    else
                    {
                        dict[ch] = 1;
                    }
                }
            }

            foreach (var item in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0}:{1}", item.Key,item.Value);
            }
        }
    }
}
