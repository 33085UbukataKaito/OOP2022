using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace XmlSample {
    class Program {
        static void Main(string[] args) {

            var wc = new WebClient();
            var stream = new WebClient().OpenRead("https://news.yahoo.co.jp/rss/media/anmanmv/all.xml");

            var xdoc = XDocument.Load(stream);
            var xnews = xdoc.Root.Descendants("title");
            foreach(var data in xnews) {
                Console.WriteLine(data);
            }
        }
    }
}
