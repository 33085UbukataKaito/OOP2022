using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execise3{
    class Program {
        static void Main(string[] args) {
            int select = 0;
            var sales = new Counter("sales.csv");
            IDictionary<string, int> amountPerStore = null;

            while (true) {
                Console.WriteLine("売上高の表示選択");
                Console.WriteLine("1.店舗別");
                Console.WriteLine("2.商品カテゴリー別");
                Console.WriteLine(">");

                select = int.Parse(Console.ReadLine());

                switch (select) {
                    case 1:
                        Output(sales.GetPerStoreSales());
                        amountPerStore = sales.GetPerStoreSales();
                        break;

                    case 2:
                        Output(sales.GetPerProductSales());
                        amountPerStore = sales.GetPerProductSales();
                        break;

                    case 999:
                        return;

                }
            }
        }
                //var sales = new Counter("sales.csv");
                //var amountPerStore = sales.GetPerStoreSales();

            private static void Output(IDictionary<string, int> amountPerStore) {
                foreach (var obj in amountPerStore) {
                    Console.WriteLine("{0} {1}", obj.Key, obj.Value);
                }

            }
            // ReadSales("sales.csv")
        }
    }

