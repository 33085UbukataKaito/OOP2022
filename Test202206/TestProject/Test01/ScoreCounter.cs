﻿using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);



        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            //テストデータを読み込み、Studentオブジェクトのリストを返す
            List<Student> student = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Student sale = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                student.Add(sale);
            }
            return student;




        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            //科目別の点数を求める
            var dict = new Dictionary<string, int>();
            foreach (Student student in _score) {
                if (dict.ContainsKey(student.Subject))
                    dict[student.Subject] += student.Score;
                else
                    dict[student.Subject] = student.Score;
            }

            return dict;
        }

    }
}
