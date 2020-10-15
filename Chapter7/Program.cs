using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 辞書登録プログラム

            Console.WriteLine("**********************");
            Console.WriteLine("* 辞書登録プログラム *");
            Console.WriteLine("**********************");

            DuplicateKeySample();
        }
        static public void DuplicateKeySample()
        {
            // ディクショナリの初期化
            var dict = new Dictionary<string, List<string>>();

            while (true)
            {
                Console.WriteLine("1.登録 2.内容を表示 3.終了");
                Console.Write(">");
                var select = Console.ReadLine();
                if (select == "1")
                {
                    Console.Write("KEY入力：");
                    var key = Console.ReadLine();
                    Console.Write("VALUEを入力：");
                    var value = Console.ReadLine();
                    // ディクショナリに追加
                    if (dict.ContainsKey(key))
                    {
                        dict[key].Add(value);
                    }
                    else
                    {
                        dict[key] = new List<string> { value };
                    }
                    Console.WriteLine("登録しました！");
                    Console.WriteLine(" ");
                }
                else if (select == "2")
                {
                    // ディクショナリの内容を列挙
                    foreach (var item in dict)
                    {
                        foreach (var term in item.Value)
                        {
                            Console.WriteLine("{0} : {1}", item.Key, term);
                        }
                    }
                    Console.WriteLine(" ");
                }
                else if (select == "3")
                {
                    break;
                }
            }
        }
    }
#endregion
}
