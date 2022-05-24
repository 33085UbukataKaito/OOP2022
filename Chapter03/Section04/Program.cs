using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section04 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            var query = names.Where(s => s.Length <= 50);
            foreach(var n in query) {
                Console.Write("{0}",n);
            }
        }
    }
}
