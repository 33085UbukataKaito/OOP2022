using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class CarReportSystem : Form {
        BindingList<Car> listCar = new BindingList<Car>();

        public CarReportSystem() {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e) {

            //アプリケーションの終了
            Application.Exit();
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbCar.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }

        private void btAdd_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(cbReporter.Text)) {
                MessageBox.Show("氏名が入力されていません");
                return;
            }
        }
        private List<Car.GroupType> getcheckboxgroup() {
            var listgroup = new List<Car.GroupType>();

            if (rbToyota.Checked) {
                listgroup.Add(Car.GroupType.トヨタ);
            }
            if (rbHonda.Checked) {
                listgroup.Add(Car.GroupType.友人);
            }
            if (rbNissan.Checked) {
                listgroup.Add(Car.GroupType.仕事);
            }
            if (rbSubaru.Checked) {
                listgroup.Add(Car.GroupType.その他);
            }
            return listgroup;
        }
    
            Car newPerson = new Car {
                Reporter = cbReporter.Text
            };
        
    }
}
