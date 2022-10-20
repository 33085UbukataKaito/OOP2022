using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    
    public partial class MainWindow : Window {

    int seikai = new Random().Next(1, 25);//正解の番号
        

        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender,RoutedEventArgs e) {
            
            Button bt = (Button)sender;

            if(seikai == int.Parse((string)bt.Content)) {
                textBlock.Text = "あたり";
                bt.Background = Brushes.Yellow;
            }else {
                bt.Background = Brushes.Red;
                textBlock.Text = int.Parse((string)bt.Content) < seikai
                    ? "もっと大きな数字です！" : "もっと小さな数字です！";

            }
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e) {
            textBlock.Text = "GAME START!";
        }
    }
}
