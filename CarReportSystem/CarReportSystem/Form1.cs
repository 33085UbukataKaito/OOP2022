using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }


        Settings settings = Settings.getInstance();

        private void btExit_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202207DataSet);
            //アプリケーションの終了
            Application.Exit();
        }

        

        private void btAdd_Click(object sender, EventArgs e) {

            DataRow newRow = infosys202207DataSet.CarReportDB.NewRow();
            newRow[1] = dtpDate.Text;
            newRow[2] = cbAuther.Text;
            newRow[3] = getradioboxgroup();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = ImageToByteArray(pbCarPicture.Image);
            //データセットに新しいレコードを追加
            infosys202207DataSet.CarReportDB.Rows.Add(newRow);
            //データベース更新
            this.carReportDBTableAdapter.Update(this.infosys202207DataSet);

            if (String.IsNullOrWhiteSpace(cbAuther.Text)) {
                MessageBox.Show("氏名が入力されていません");
                return;
            }

            CarReport newCar = new CarReport {
                CarName = cbCarName.Text,
                Auther = cbAuther.Text,
                Report = tbReport.Text,
                Picture = pbCarPicture.Image,
                Date = dtpDate.Value,
                
            };
            
        }

        private void setCbCarName(string carname) {

            if (!cbCarName.Items.Contains(carname)) {
                //まだ登録されていなければ登録
                cbCarName.Items.Add(carname);
            }
        }

        private void setCbAuther(string auther) {

            if (!cbAuther.Items.Contains(auther)) {
                //まだ登録されていなければ登録
                cbAuther.Items.Add(auther);
            }
        }

        private string getradioboxgroup() {
            //var selectMakerGroup = CarReport.MakerGroup.トヨタ;

            if (rbToyota.Checked) {
                return"トヨタ";
            }
            if (rbHonda.Checked) {
                return "ホンダ";
            }
            if (rbNissan.Checked) {
                return "日産";
            }
            if (rbForeignCar.Checked) {
                return "外国車";
            }
            if (rbSubaru.Checked) {
                return "スバル";
            }
            return "その他";
        }

        

        private void btPictureOpen_Click(object sender, EventArgs e) {
            ofdImage.Filter = "画像ファイル(*.jpg; *.png; *.bmp)| *.jpg; *.png; *.bmp";
            if (ofdImage.ShowDialog() == DialogResult.OK) {
                pbCarPicture.Image = Image.FromFile(ofdImage.FileName);
            }
        }

        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbCarPicture.Image = null;
        }

        private void btDelete_Click(object sender, EventArgs e) {

            carReportDBDataGridView.Rows.RemoveAt(carReportDBDataGridView.CurrentRow.Index);

        }

        private void btUpdate_Click(object sender, EventArgs e) {

            carReportDBDataGridView.CurrentRow.Cells[1].Value = dtpDate.Text;
            carReportDBDataGridView.CurrentRow.Cells[2].Value = cbAuther.Text;
            carReportDBDataGridView.CurrentRow.Cells[3].Value = getradioboxgroup();
            carReportDBDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
            carReportDBDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;
            carReportDBDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbCarPicture.Image);

            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202207DataSet);
        }

        private void Form1_Load(object sender, EventArgs e) {

            pbCarPicture.SizeMode = PictureBoxSizeMode.StretchImage;   
        }

        private void ColorToolStripMenuItem(object sender, EventArgs e) {
            if(cdColorSelect.ShowDialog() == DialogResult.OK) {
                BackColor = cdColorSelect.Color;
                settings.MainFormColor = cdColorSelect.Color.ToArgb();
            }
        }

        private void carReportDBBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202207DataSet);

        }
        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e) {
            this.carReportDBTableAdapter.Fill(this.infosys202207DataSet.CarReportDB);
        }

        private void carReportDBDataGridView_Click(object sender, EventArgs e) {
            if (carReportDBDataGridView.CurrentRow == null)
                return;

            dtpDate.Text = carReportDBDataGridView.CurrentRow.Cells[1].Value.ToString();
            cbAuther.Text = carReportDBDataGridView.CurrentRow.Cells[2].Value.ToString();
            setMeker();
            cbCarName.Text = carReportDBDataGridView.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = carReportDBDataGridView.CurrentRow.Cells[5].Value.ToString();
            if (!(carReportDBDataGridView.CurrentRow.Cells[6].Value is DBNull))
                pbCarPicture.Image = ByteArrayToImage((byte[])carReportDBDataGridView.CurrentRow.Cells[6].Value);
            else {
                pbCarPicture.Image = null;
            }
        }

        private void btNameSearch_Click(object sender, EventArgs e) {
            this.carReportDBTableAdapter.FillByName(this.infosys202207DataSet.CarReportDB, btNameSearch.Text);
        }

        private void setMeker() {
            switch (carReportDBDataGridView.CurrentRow.Cells[3].Value.ToString()) {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "外国車":
                    rbForeignCar.Checked = true;
                    break;
                case "その他":
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }
    }
}
  
