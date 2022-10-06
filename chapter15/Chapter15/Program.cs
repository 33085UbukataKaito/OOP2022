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

            //Console.WriteLine("昇順、降順を選択してください　0/1");
            //var check = int.Parse(Console.ReadLine());

            //IEnumerable<Book> books;
            //if (check == 0) {
            //    //昇順
            //    books = Library.Books
            //                      .Where(b => years.Contains(b.PublishedYear))
            //                      .OrderBy(b => b.PublishedYear);
            //}
            //else {
            //    //降順
            //    books = Library.Books
            //                      .Where(b => years.Contains(b.PublishedYear))
            //                      .OrderByDescending(b => b.PublishedYear);

            //}
            //foreach (var book in books) {
            //    Console.WriteLine(book);
            //}

            Console.WriteLine();
            var selected = Library.Books
                .Where(b => years.Contains(b.PublishedYear))
                //.GroupBy(b => b.PublishedYear)
                //.Select(group => group.OrderByDescending(b => b.Price).First())
                .OrderByDescending(b => b.PublishedYear)
                .ThenBy(b => b.CategoryId)
                .Join(Library.Categories,      //結合する2番目のシーケンス
                      book => book.CategoryId, //対象シーケンスの結合キー
                      category => category.Id, //２番目のシーケンスの結合キー
                      (book, category) => new {
                          Title = book.Title,
                          Category = category.Name,
                          PublishedYear = book.PublishedYear,
                          Price = book.Price,
                          Name = category.Name,
                      }
                      );
            
            //.OrderBy(g => g.Key);
            foreach (var book in selected) {
                Console.WriteLine($"{book.PublishedYear}年");
                //foreach (var book in g) {
                //var category = Library.Categories.Where(b => b.Id == book.CategoryId).First();
                Console.WriteLine($"タイトル:{book.Title},価格:{book.Price}円,カテゴリ:{book.Name}");
            }
                Console.WriteLine($"書籍の合計金額は{selected.Sum(b => b.Price)}円")
        }
    }
}

