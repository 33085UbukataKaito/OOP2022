﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
        }

        private static void Exercise1_1(int[] numbers) {
            Console.WriteLine(numbers.Max());
        }

        private static void Exercise1_2(int[] numbers) {
            foreach(var n in numbers.Skip(numbers.Length - 2)) {
                Console.WriteLine(n);
            }


            //for(int i = numbers.Length-2; i < numbers.Length; i++) {
            //    Console.WriteLine(numbers[i]);
            //}
        }

        private static void Exercise1_3(int[] numbers) {
           var result = numbers.Select(n => n.ToString());

           foreach( var str in result){
                Console.WriteLine(str);
            }  
        }

        private static void Exercise1_4(int[] numbers) {
            Array.Sort(numbers);
            foreach (var str in numbers.Take(3)){
                Console.WriteLine(str);
            }
        }

        private static void Exercise1_5(int[] numbers) {
            var result = numbers.Distinct().Count(n => n > 10);

            Console.WriteLine(result);

        }
    }
}
