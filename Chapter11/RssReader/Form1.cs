﻿using System;
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
        List<string> linklist = new List<string>();
           


        private void btRSSget_Click(object sender, EventArgs e) {

            using (var wc = new WebClient()) {
                var stream = wc.OpenRead(cbRSSURL.Text);

                var xdoc = XDocument.Load(stream);
                var xnews = xdoc.Root.Descendants("item").Select(x => x.Element("title"));
                var xlink = xdoc.Root.Descendants("item").Select(x => x.Element("link"));

                

                foreach (var data in xnews) {
                    lbRSSTitle.Items.Add(data);
                    
                }

                foreach (var data in xlink) {
                    linklist.Add((string)data);
                    
                }
               

            }
        }

        private void lbRSSTitle_Click(object sender, EventArgs e) {
            int id = lbRSSTitle.Index;
        }
    }
}
