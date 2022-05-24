using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execise {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            Execise02_1(names);
            Console.WriteLine();
            Execise02_2(names);
            Console.WriteLine();
            Execise02_3(names);
            Console.WriteLine();
            Execise02_4(names);
            Console.WriteLine();
        }

        private static void Execise02_1(List<string> names) {
            Console.WriteLine("都市名を入力。空行で終了");
            do {
                var line = Console.ReadLine();//入力取り込み
                if (string.IsNullOrEmpty(line))
                    break;

                var index =  names.FindIndex(s => s == line);
                Console.WriteLine(index);
                /*処理*/

            } while (true);//無限ループ
        }

        private static void Execise02_2(List<string> names) {
            var find = names.Count(s => s.Contains("o"));
            Console.WriteLine(find);
        }

        private static void Execise02_3(List<string> names) {
            var query = names.Where(s => s.Contains("o"));
            foreach (var n in query) {
                Console.Write(n);
            }

       // private static void Execise02_4(List<string> names) {
                throw new NotImplementedException();
            }
        }
    }
}
