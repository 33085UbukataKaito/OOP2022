using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            var novelist = Exercise2_1("sample.xml");
            Exercise2_2(novelist, "novelist.json");

            // これは確認のためのコード 12.2.1
            Console.WriteLine("{0} {1}", novelist.Name, novelist.Birth);
            foreach (var title in novelist.Masterpieces) {
                Console.WriteLine(title);
            }
            Console.WriteLine();

            // これは確認のためのコード 12.2.2
            //Console.WriteLine(File.ReadAllText("novelist.json"));
            Console.WriteLine();
        }

        private static Novelist Exercise2_1(string file) {

            //引数で受け取ったファイルを逆シリアル化しNovelistクラスのオブジェクトにセットする
            using (var reader = XmlReader.Create("novels.xml")) {
                var serializer = new XmlSerializer(typeof(Novelist));
                var novelist = serializer.Deserialize(reader) as Novelist;

                //Novelistクラスのオブジェクトを返却
                return novelist;
            }

            Display("novels.xml");
            //Novelistクラスのオブジェクトを返却
            
        }

        public static void Deserialize() {
            using (var reader = XmlReader.Create("novels.xml")) {
                var serializer = new XmlSerializer(typeof(Novelist));
                var novels = serializer.Deserialize(reader) as Novelist;
                // 以下、内容を確認するコード
                //Console.WriteLine(novel);
                foreach (var novel in novels.) {
                    Console.WriteLine(novel);
                }

            }
        }

        private static void Exercise2_2(Novelist novelist, string v) {

        }
        private static void Display(string filename) {
            var lines = File.ReadLines(filename);
            foreach (var line in lines)
                Console.WriteLine(line);

        }
    }
}
