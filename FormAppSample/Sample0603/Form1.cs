using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0603 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            //tbAns.Text = (int.Parse(tbSuu1.Text) + int.Parse(tbSuu2.Text)).ToString();

            //int value1 = int.Parse(tbSuu1.Text);
            //int value2 = int.Parse(tbSuu2.Text);

            // int ValueAnswer = value1+value2;

            // tbAns.Text = ValueAnswer.ToString();

            nudAns.Value = nudSuu1.Value + nudSuu2.Value;

        }
    }
}
