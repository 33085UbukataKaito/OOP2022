using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            int i;

            Console.Write("数列を入力してください:");
            if(int.TryParse(Console.ReadLine(),out i)) {
                var s = i.ToString("#,0");
                Console.WriteLine(s);
                Console.WriteLine("変換に成功しました");
            }
            else {
                Console.WriteLine("変換に失敗しました");
            }


        }
    }
}
