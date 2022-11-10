using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WetherApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btWetherGet_Click(object sender, EventArgs e) {


            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            var a = 011000;

            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/" + &a + ".json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

           
            tbWetherInfo.Text = json.text;
        }
    }
}
