using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {



            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);

        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load("Sample.xml");
            var sportnames = xdoc.Root.Elements()
                                .Select(x => new {
                                    Name = (string)x.Element("name"),
                                    Member = (int)x.Element("teammembers"),
                                });
            foreach (var sportname in sportnames) {
                Console.WriteLine("{0} {1}人", sportname.Name, sportname.Member);
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load("Sample.xml");
            var playYears = xdoc.Root.Elements()
                                .Select(x => new {
                                    Name = (string)x.Element("name"),
                                    year = (int)x.Element("firstplayed"),
                                });

            foreach (var playYear in playYears) {

                Console.WriteLine("{0} {1}年", playYear.Name, playYear.year);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load("Sample.xml");
            var memberNumber = xdoc.Root.Elements()
                                            .Select(x => new {
                                                max = (int)x.Element("teammembers"),
                                            });
        }
        private static void Exercise1_4(string file, string newfile) {
        }
    }
}
