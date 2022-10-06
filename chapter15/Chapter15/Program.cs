using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
    class Program {
        static void Main(string[] args) {

            var years = new List<int>();
            Console.WriteLine("西暦を入力してください");

            int ce;
            ce = int.Parse(Console.ReadLine());

            while (ce != -1) {
                years.Add(ce);
                ce = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("昇順、降順を選択してください　0/1");
            var check = int.Parse(Console.ReadLine());
            IEnumerable<Book> books;
            if (check == 0) {
                 books = Library.Books
                                   .Where(b => years.Contains(b.PublishedYear))
                                   .OrderBy(b => b.PublishedYear);
            } else  {
                 books = Library.Books
                                   .Where(b => years.Contains(b.PublishedYear))
                                   .OrderByDescending(b => b.PublishedYear);                  
            
            }foreach (var book in books) {
            Console.WriteLine(book);
            }

            Console.WriteLine();
            var groups = Library.Books
                .Where(b => years.Contains(b.PublishedYear))
                .GroupBy(b => b.PublishedYear)
                .OrderBy(g => g.Key);
            foreach (var g in groups) {
                foreach (var book in g) {

                }
                var category = Library.Categories.Where(b => b.Id == book.CategoryId).First();
                Console.WriteLine($"タイトル:{book.Title},価格:{book.Price},カテゴリ:{category.Name}");
            }
        } 
    }
}
