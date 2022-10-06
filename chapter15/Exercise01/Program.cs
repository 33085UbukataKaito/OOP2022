using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books.Max(b => b.Price);
            var book = Library.Books.Where(b => b.Price == max).First();
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var years = new List<int>();
            var selected = Library.Books
                .GroupBy(b => b.PublishedYear)
                .Count();
            Console.WriteLine();
        }

        private static void Exercise1_4() {
            var years = new List<int>();
            var selected = Library.Books
                .OrderByDescending(b => b.PublishedYear)
                .ThenByDescending(b => b.Price)
                .Join(Library.Categories,
                      book => book.CategoryId, 
                      category => category.Id,
                      (book, category) => new {
                          Title = book.Title,
                          PublishedYear = book.PublishedYear,
                          Price = book.Price,
                          Name = category.Name,
                      }
                      );
            foreach (var book in selected) {
                Console.WriteLine($"{book.PublishedYear}年,{book.Price}円,{book.Title},({book.Name})");
            }
        }
        private static void Exercise1_5() {
            var selected = Library.Books
                .Where(b => b.PublishedYear == 2016)
                .Join(Library.Categories,      
                      book => book.CategoryId, 
                      category => category.Id, 
                      (book, category) => category.Name)
                      .Distinct();
            foreach (var book in selected) {
                Console.WriteLine(book);
            }
        }
        private static void Exercise1_6() {
            var selected = Library.Books
                .OrderByDescending(b => b.PublishedYear)
                .ThenByDescending(b => b.Price)
                .Join(Library.Categories,
                      book => book.CategoryId,
                      category => category.Id,
                      (book, category) => new {
                          Title = book.Title,
                          Category = category.Name,
                          PublishedYear = book.PublishedYear,
                          Price = book.Price,
                          Name = category.Name,
                      }
                      )
                .GroupBy(b => b.Category)
                .OrderBy(b => b.Key);
            foreach (var book in selected) {
                Console.WriteLine($"#{book.Key}");
            }
        }

        private static void Exercise1_7() {

        }

        private static void Exercise1_8() {

        }
    }
}
