﻿using Chapter06;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            #region 6-1
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
            Console.Write(numbers.Count(n => n > 10));
            #endregion

            var books = new List<Book> 
            {
                new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
                new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
                new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
                new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
                new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
                new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
                new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            //6.2.1
            Console.WriteLine("\n--------------------");
            var book = books.Where(x => x.Title == "ワンダフル・C#ライフ");
            foreach (var item in book)
            {
                Console.WriteLine($"価格{item.Price}");
                Console.Write($"ページ数{item.Pages}");
            }

            //6.2.2
            Console.WriteLine("\n--------------------");
            var title = books.Count(x => x.Title.Contains("C#"));
            Console.Write($"{title}冊");

            //6.2.3
            Console.WriteLine("\n--------------------");
            var avg = books.Where(x => x.Title.Contains("C#")).Average(x => x.Pages);
            Console.Write($"平均ページ数：{avg}ページ");

            //6.2.4
            Console.WriteLine("\n--------------------");
            var price = books.FirstOrDefault(x => x.Price >= 4000);
            Console.Write(price.Title);

            //6.2.5
            Console.WriteLine("\n--------------------");
            var max = books.Where(x => x.Price <= 4000).Max(x => x.Pages);
            Console.Write($"{max}ページ");

            //6.2.6
            Console.WriteLine("\n--------------------");
            var bok = books.Where(x => x.Pages >= 400).OrderByDescending(x => x.Price);
            foreach (var boks in bok)
            {
                Console.WriteLine($"{boks.Title} {boks.Price}");
            }

            //6.2.7
            Console.WriteLine("\n--------------------");
            var bks = books.Where(x => x.Title.Contains("C#") &&  x.Pages <= 500);
            foreach (var bk in bks)
            {
                Console.WriteLine(bk.Title);
            }
        }
    }
}
