﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607 {
    public partial class Form1 : Form {
        Random r = new Random();
        

        public Form1() {
            InitializeComponent();
        }

        private void btRandom_Click(object sender, EventArgs e) {


            number.Value = r.Next(minValue:(int)number2.Value,maxValue:(int)number3.Value);
    
                
        }
    }
}
