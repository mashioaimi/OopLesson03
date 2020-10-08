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
            //整数の例
            var numbers = new List<int> { 19, 17, 15, 24, 12, 25, 14, 20, 12, 28, 19, 30, 24 };

            //numbers.Select(n => n.ToString("0000")).Distinct().ToList().ForEach(s => Console.WriteLine(s + " "));

            var strings = numbers.Distinct().ToArray();
            foreach (var str in strings)
            {
                Console.Write(str + " ");
            }

            //並べ替え
            Console.WriteLine();    //改行
            var sortedNumbers = numbers.OrderBy(n => n).Distinct();
            foreach (var nums in sortedNumbers)
            {
                Console.Write(nums + " ");
            }


            //文字列の例
            Console.WriteLine("\n\n--------------------");
            var words = new List<string> { "Microsoft", "Apple", "Google", "Oracle", "Facebook", };

            var lower = words.Select(name => name.ToLower()).ToArray();

            //オブジェクトの例
            Console.WriteLine("\n\n--------------------");
            var books = Books.GetBooks();
            //タイトルリスト
            var titles = books.Select(name => name.Title);
            foreach (var title in titles)
            {
                Console.Write(title + " ");
            }

            Console.WriteLine("\n--------------------");
            //ページの多い順に並び替え（または金額の高い順）
            var sortedBooks = books.OrderByDescending(book => book.Pages);
            foreach (var book in sortedBooks)
            {
                Console.WriteLine(book.Title + " " + book.Pages);
            }
        }
    }
}
