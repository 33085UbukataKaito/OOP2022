using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise02 {
    class Program {
        static void Main(string[] args) {
            var books = new List<Book> {
       new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
       new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
       new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
       new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
       new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
       new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
       new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
    };

            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);

            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Exercise2_6(books);

            Console.WriteLine("-----");

            Exercise2_7(books);

            Console.WriteLine("-----");

            Exercise2_8(books);
        }

        private static void Exercise2_8(List<Book> books) {
            foreach(var result in books.Select((value,index) => new { value, index })) {
                Console.WriteLine("{0}冊目:{1}", result.index+1, result.value.Title);
            }
        }

        private static void Exercise2_1(List<Book> books) {
            var result = books.FirstOrDefault(s => s.Title == "ワンダフル・C#ライフ");
            if(result != null)
                Console.WriteLine("{0},{1}",result.Price,result.Pages);
            
        }

        private static void Exercise2_2(List<Book> books) {
            var count = books.Count(b => b.Title.Contains("C#"));
            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<Book> books) {
            var count = books.Where(b => b.Title.Contains("C#")).Average(b => b.Pages);
            Console.WriteLine(count);
        }

        private static void Exercise2_4(List<Book> books) {
            var count = books.FirstOrDefault(b => b.Price >= 4000);
            Console.WriteLine(count.Title);

        }

        private static void Exercise2_5(List<Book> books) {
            var count = books.Where(b => b.Price < 4000).Max(n => n.Pages);
            Console.WriteLine(count);
        }
        private static void Exercise2_6(List<Book> books) {
            foreach(var count in books.Where(b => b.Pages >= 400).OrderBy(n => n.Price)) {
                Console.WriteLine("{0} {1}",count.Title,count.Price);
            }
        }

        private static void Exercise2_7(List<Book> books) {
           foreach( var count in books.Where(b => b.Title.Contains("C#") && b.Pages <= 500)) {
                Console.WriteLine("{0}", count.Title);
            }
        }




        class Book {
            public string Title { get; set; }
            public int Price { get; set; }
            public int Pages { get; set; }
        }
    }
}
