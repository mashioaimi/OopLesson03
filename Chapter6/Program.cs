using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6-1
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            //6.1.1
            Console.Write(numbers.Max());

            //6.1.2
            Console.WriteLine("\n--------------------");
            int pos = numbers.Length - 2;
            foreach (var number in numbers.Skip(pos))
            {
                Console.Write(number + " ");
            }

            //6.1.3
            Console.WriteLine("\n--------------------");
            var strNums = numbers.Select(n => n.ToString());
            foreach (var str in strNums)
            {
                Console.Write(str + " ");
            }

            //6.1.4
            Console.WriteLine("\n--------------------");
            var num = numbers.OrderBy(x => x).Take(3);
            foreach (var item in num)
            {
                Console.Write(item + " ");
            }

            //6.1.5
            Console.WriteLine("\n--------------------");
            var result = numbers.Distinct();
            Console.WriteLine(numbers.Count(n => n > 10));
        }
    }
}
