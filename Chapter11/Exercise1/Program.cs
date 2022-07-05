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

            var text = File.ReadAllText(newfile);
            Console.WriteLine(text);

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
                                . Select(x => new {
                                   Name = x.Element("name").Value,
                                   FirstPlayed = x.Element("firstplayed").Value
                                })
                                .OrderBy(x => int.Parse(x.FirstPlayed));
            foreach (var playyear in playYears) {
                Console.WriteLine("{0} {1}人", playyear.Name, playyear.FirstPlayed);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load("Sample.xml");
            var memberNumbers = xdoc.Root.Elements()
                                            .Select(x => new {
                                                Name = x.Element("name").Value,
                                                Teammembers = x.Element("Teammembers").Value
                                            })
                                            .OrderByDescending(x => int.Parse(x.Teammembers)).FirstOrDefault();
            
                Console.WriteLine("{0}",memberNumbers.Name,memberNumbers.Teammembers);
            
        }
        private static void Exercise1_4(string file, string newfile) {
            var xdoc = XDocument.Load("Sports.xml");
            var elememt = new XElement("ballsport",
                              new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                              new XElement("Teammembers", "11"),
                              new XElement("firstplayed", "1863"));
            
            xdoc.Root.Add(elememt);
            xdoc.Save(newfile);

            //foreach(var sport in xdoc.Root.Elements()) {
            //    var xname = sport.Element("name");
            //    var Teammember = sport.Element("Teammember");
            //    Console.WriteLine("{0} {1}", xname.Value, Teammember.Value);
            //}
        }
    }
}
