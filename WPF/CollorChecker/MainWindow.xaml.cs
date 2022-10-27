﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CollorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            tarou.Background = new SolidColorBrush(Color.FromRgb((byte)int.Parse(R.Text), (byte)int.Parse(G.Text), (byte)int.Parse(B.Text)));
        }

        private void SetColor() {
            var r = byte.Parse(R.Text);
            var g = byte.Parse(G.Text);
            var b = byte.Parse(B.Text);
            
        }


        private MyColor[] GetColorList() {

            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            SliderR.Value = color.R;
            SliderG.Value = color.G;
            SliderB.Value = color.B;
            tarou.Background = new SolidColorBrush(color);

            
        }
    }
}
