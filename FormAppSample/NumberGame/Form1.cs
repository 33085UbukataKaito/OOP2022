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
        private Random random = new Random();
        public Form1() {
            InitializeComponent();
            
        }

        private void bt1_Click(object sender, EventArgs e) {
            int rand = new Random().Next(1,100);
            int seikai = rand;

            if (seikai == nud1.Value) {
                tb1.Text = "正解!";
            }
            else if (seikai >= nud1.Value) {
                tb1.Text = "もっと大きい数です";
            }
            else if (seikai <= nud1.Value) {
                tb1.Text = "もっと小さい数です";
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            
        }
    } 
}
