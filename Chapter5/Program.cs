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
            var text = "Jackdaws love my big sphinx of quartz";
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;born=1886";

            #region 5.1
            //5.1
            //Console.WriteLine("----5.1----");
            //Console.Write("文字列１：");
            //var str1 = Console.ReadLine();
            //Console.Write("文字列２：");
            //var str2 = Console.ReadLine();
            //if (String.Compare(str1,str2,true) == 0)
            //{
            //    Console.WriteLine("等しい");
            //}
            //else
            //{
            //    Console.WriteLine("等しくない");
            //}
            #endregion

            #region 5.2
            //5.2
            //Console.WriteLine("----5.2----");
            //Console.Write("数値文字列：");
            //var line = Console.ReadLine();
            //int num;    //返還後の数値格納用
            //if(int.TryParse(line, out num))
            //{
            //    Console.WriteLine(num.ToString("#,#"));
            //    //Console.WriteLine("{#,#}", num);  この二つでもよい
            //    //Console.WriteLine($"{num:#,#}");
            //}
            //else
            //{
            //    Console.WriteLine("数値文字列ではありません");
            //}
            #endregion

            #region 5.3
            ////5.3
            //var text = "Jackdaws love my big sphinx of quartz";
            ////5.3.1
            //Console.WriteLine("----5.3.1----");
            //Console.WriteLine(text.Count(s => s == ' '));
            //
            ////5.3.2
            //Console.WriteLine("----5.3.2----");
            //var replaced = text.Replace("big", "small");
            //Console.WriteLine(replaced);
            //
            ////5.3.3
            //Console.WriteLine("----5.3.3----");
            //var count = text.Split(' ').Count();
            //Console.WriteLine(count);
            //
            ////5.3.4
            //Console.WriteLine("----5.3.4----");
            //var words = text.Split(' ').Where(s => s.Length <= 4);
            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}
            //
            ////5.3.5
            //Console.WriteLine("----5.3.5----");
            //var array = text.Split(' ').ToArray();
            //if (array.Length >= 0)
            //{
            //    var sb = new StringBuilder(array[0]);
            //    foreach (var word in array.Skip(1))
            //    {
            //        sb.Append(' ');
            //        sb.Append(word);
            //    }
            //    Console.WriteLine(sb);
            //}
            #endregion

            #region
            //5.4
                Console.WriteLine("----5.4----");
                foreach (var item in line.Split(';'))
                {
                    var word = item.Split('=');
                    Console.WriteLine("{0}:{1}", ToJapanese(word[0]), word[1]);
                }
            }
            static string ToJapanese(string key)
            {
                switch (key)
                {
                    case "Novelist":
                        return "作家　";
                    case "BestWork":
                        return "代表作";
                    case "Born":
                        return "誕生年";
                    default:
                        return "　　　";
                }
            #endregion

        }
    }
}
