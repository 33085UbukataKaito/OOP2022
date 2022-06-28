using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace RssReader {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            
            }



        private void btRSSget_Click(object sender, EventArgs e) {

            using (var wc = new WebClient()) {
                var stream = wc.OpenRead(cbRSSURL.Text);

                var xdoc = XDocument.Load(stream);
                var xnews = xdoc.Root.Descendants("item").Select(x => x.Element("title"));;

                foreach (var data in xnews) {
                    lbRSSTitle.Items.Add(data);
                    
                }


            }
        }
    }
}
