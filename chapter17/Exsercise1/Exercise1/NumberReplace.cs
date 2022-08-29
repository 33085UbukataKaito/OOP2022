using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;
using System.Text.RegularExpressions;

namespace Exercise1 {
    class NumberReplace : TextProcessor {

        private static Dictionary<char, char> _dictionary = new Dictionary<char, char> {
            {'０','0'},{'２','2'},{'３','3'},{'４','4'},{'５','5'},{'６','6'},{'７','7'},{'８','8'},{'９','9'}
        };

        protected override void Execute(string line) {
            string s = Regex.Replace(line, "[０-９]", p => ((p.Value[0] - '０' + '0')).ToString());
            Console.WriteLine(s);
        }
    }
}
