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

namespace SampleApplication {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            seasonComboBox.SelectedIndex = getSeasonIndex();
        }

        private int getSeasonIndex() {
            DateTime dtNow = DateTime.Now;
            int iMonth = dtNow.Month;

            if (iMonth == 3 || iMonth ==4 || iMonth == 5 ) {
                return 0;
            }else if(iMonth == 6 || iMonth == 7 || iMonth == 8) {
                return 1;
            }else if(iMonth == 9 || iMonth == 10 || iMonth == 11) {
                return 2;
            }else{
                return 3;
            }
        }




        private void checkBox_Checked(object sender, RoutedEventArgs e) {
            checkBoxTextBlock.Text = "チェック済み";
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e) {
            checkBoxTextBlock.Text = "未チェック";
        }

        private void radioButtom_Checked(object sender, RoutedEventArgs e) {

        }

        private void seasonComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            seasonTextBlock.Text = (string)((ComboBoxItem)seasonComboBox.SelectedItem).Content;
        }

        private void redRadioButtom_Checked(object sender, RoutedEventArgs e) {
            colorTextBox.Text = "赤";
        }

        private void yellowRadioButtom_Checked(object sender, RoutedEventArgs e) {
            colorTextBox.Text = "黄";
        }

        private void blueRadioButtom_Checked(object sender, RoutedEventArgs e) {
            colorTextBox.Text = "青";
        }
    }
}
