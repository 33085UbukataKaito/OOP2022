﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersice03 {
    class Program {
        static void Main(string[] args) {

            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
        }

        private static void Exercise3_1(string text) {
            int space = text.Count(c => c == ' ');

            Console.WriteLine("空白数:{0}",space);
        }

        private static void Exercise3_2(string text) {
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3_3(string text) {
            int count = text.Split(' ').Length;
            Console.WriteLine("単語数:{0}",count);
        }

        private static void Exercise3_4(string text) {
            text.Split(' ').Where(words => words.Length <= 4)
                    .ToList().ForEach(Console.WriteLine);
        }

        private static void Exercise3_5(string text) {
            var words = text.Split(' ');
            if(words.Length > 0) {
                var sb = new StringBuilder(words[0]);

                foreach (var word in words.Skip(1)) {
                    sb.Append(word);
                    sb.Append(' ');
                }
                var texts = sb.ToString();
                Console.WriteLine(texts);
            }

        }
    }
}
