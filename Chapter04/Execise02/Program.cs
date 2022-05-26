using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            //4.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1990,1),
                new YearMonth(2000,2),
                new YearMonth(2000,7),
                new YearMonth(2010,8),
                new YearMonth(2020,9),
            };
            

            //4.2.2
            Exercise2_2(ymCollection);
            Console.WriteLine("----");

            //4.2.4
            Exercise2_4(ymCollection);
            Console.WriteLine("----");
            //4.2.5
            Exercise2_5(ymCollection);
            Console.WriteLine("----");
            Exercise2_6(ymCollection);
        }
        //=> ym.Year
        private static void Exercise2_6(YearMonth[] ymCollection) {
            
            foreach(var ym in ymCollection.Where(ym => DateTime.IsLeapYear(ym.Year)))
            {
                Console.WriteLine(ym);
            }

            var data = ymCollection.Max(ym => ym.Month);
            Console.WriteLine(data);
        }


        //4.2.3
        static YearMonth FindFirst21C(YearMonth[] yms) {
            foreach (var ym in yms) {
                if (ym.Is21Century) { 
                    return ym;
                }
            }
                    return null;
        }

        private static void Exercise2_2(YearMonth[] ymCollection) {
            foreach(var yearMonth in ymCollection ){
                Console.WriteLine(ymCollection); }
        }

        private static void Exercise2_4(YearMonth[] ymCollection) {
            var yearm = FindFirst21C(ymCollection);

            if (yearm != null) {
                Console.WriteLine(yearm);
            }
            else {
                Console.WriteLine("21世紀のデータはありません");
            }
        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            var array = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach(var ym in array) {
                Console.WriteLine(ym);
            }


        }
    }
}
