using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.1
            Console.Write("文字列１：");
            var str1 = Console.ReadLine();
            Console.Write("文字列２：");
            var str2 = Console.ReadLine();
            if (String.Compare(str1,str2,true) == 0)
            {
                Console.WriteLine("等しい");
            }
            else
            {
                Console.WriteLine("等しくない");
            }

            //5.2
            Console.Write("数値文字列：");
            var line = Console.ReadLine();
            int num;    //返還後の数値格納用
            if(int.TryParse(line, out num))
            {
                Console.WriteLine(num.ToString("#,#"));
                //Console.WriteLine("{#,#}", num);  この二つでもよい
                //Console.WriteLine($"{num:#,#}");
            }
            else
            {
                Console.WriteLine("数値文字列ではありません");
            }
        }
    }
}
