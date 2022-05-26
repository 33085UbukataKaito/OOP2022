using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise01 {
    class Program {
        static void Main(string[] args) {

            Console.Write("一つ目：");
            string str1 = Console.ReadLine();
            Console.Write("二つ目：");
            string str2 = Console.ReadLine();

           if(str1 == str2) {
                Console.WriteLine("一致");
            }else {
                Console.WriteLine("不一致");
            }
        }
    }
}
