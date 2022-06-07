using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame {
    public partial class Form1 : Form {
        int rand = new Random().Next(1,51);
        public Form1() {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e) {
            int seikai = rand;

            if (seikai == nud1.Value) {

            }
        }

        private void 正解(object sender, EventArgs e) {

        }
    }
}
