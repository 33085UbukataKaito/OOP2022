﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace 卒業制作 {
    /// <summary>
    /// Window1.xaml の相互作用ロジック
    /// </summary>
    public partial class Window1 : Window {

        MainWindow main = new MainWindow();
        

        public Window1() {
            InitializeComponent();
            
        }

        private void browser1_Loaded(object sender, RoutedEventArgs e) {
            browser1.Navigate("https://www.nicovideo.jp/watch/" + main.id);
        }
    }
}
