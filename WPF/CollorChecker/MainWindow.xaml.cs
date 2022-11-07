using System;
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
        List<MyColor> myColors = new List<MyColor>(); 
        MyColor mycolor = new MyColor();

        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            SetColor();
        }

        private void SetColor() {
            var r = byte.Parse(R.Text);
            var g = byte.Parse(G.Text);
            var b = byte.Parse(B.Text);

            tarou.Background = new SolidColorBrush(Color.FromRgb(r,g,b));


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
            mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            SliderR.Value = color.R;
            SliderG.Value = color.G;
            SliderB.Value = color.B;
            tarou.Background = new SolidColorBrush(Color.FromRgb((byte)SliderR.Value,(byte)SliderG.Value,(byte)SliderB.Value));

            
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            Nobita.Items.Add("R =" + R.Text + "G =" + G.Text + "B =" + B.Text);
            MyColor myColor = new MyColor();
            var r = byte.Parse(R.Text);
            var g = byte.Parse(G.Text);
            var b = byte.Parse(B.Text);
            myColor.Color = Color.FromRgb(r, g, b);
            myColors.Add(myColor);

        }

        private void Nobita_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            SliderR.Value = myColors[Nobita.SelectedIndex].Color.R;
            SliderG.Value = myColors[Nobita.SelectedIndex].Color.G;
            SliderB.Value = myColors[Nobita.SelectedIndex].Color.B;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            SetColor();
        }
    }
}
