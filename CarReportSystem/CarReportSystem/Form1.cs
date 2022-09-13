﻿using System;
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

        //
        Settings settings = Settings.getInstance();

        BindingList<CarReport> listCar = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCar;
        }

        private void btExit_Click(object sender, EventArgs e) {

            //アプリケーションの終了
            Application.Exit();
        }

        

        private void btAdd_Click(object sender, EventArgs e) {

            DataRow newRow = infosys202207DataSet.CarReportDB.NewRow();
            newRow[1] = dtpDate.Text;
            newRow[2] = cbAuther.Text;
            //newRow[3] = tbTell.Text;
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
            listCar.Add(newCar);
            dgvCarReport.Rows[dgvCarReport.RowCount - 1].Selected = true;
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

        private CarReport.MakerGroup getradioboxgroup() {
            var selectMakerGroup = CarReport.MakerGroup.トヨタ;

            if (rbToyota.Checked) {
                selectMakerGroup = CarReport.MakerGroup.トヨタ;
            }
            if (rbHonda.Checked) {
                selectMakerGroup = CarReport.MakerGroup.日産;
            }
            if (rbNissan.Checked) {
                selectMakerGroup = CarReport.MakerGroup.ホンダ;
            }
            if (rbNissan.Checked) {
                selectMakerGroup = CarReport.MakerGroup.スバル;
            }
            if (rbNissan.Checked) {
                selectMakerGroup = CarReport.MakerGroup.外国車;
            }
            if (rbSubaru.Checked) {
                selectMakerGroup = CarReport.MakerGroup.その他;
            }
            return selectMakerGroup;
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

        private void dgvCarReport_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvCarReport.CurrentRow == null) return;

            int id = dgvCarReport.CurrentRow.Index;

            cbCarName.Text = listCar[id].CarName;
            cbAuther.Text = listCar[id].Auther;
            tbReport.Text = listCar[id].Report;
            pbCarPicture.Image = listCar[id].Picture;
            dtpDate.Value = listCar[id].Date.Year > 1900 ? listCar[id].Date : DateTime.Today; ;
        }

        private void btDelete_Click(object sender, EventArgs e) {
            int id = dgvCarReport.CurrentRow.Index;
            listCar.Remove(listCar[id]);

            if (listCar.Count() == 0) {
                //listPerson.RemoveAT(dgvPersons.CurrentRow.Index);
                EnabledCheck();
            }
        }
        private void EnabledCheck() {

            btUpdate.Enabled = btDelete.Enabled = listCar.Count() > 0 ? true : false;
        }

        private void btOpen_Click(object sender, EventArgs e) {

            this.carReportDBTableAdapter.Fill(this.infosys202207DataSet.CarReportDB);

            //if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
            //    try {
            //        //バイナリー形式でシリアル化
            //        var bf = new BinaryFormatter();

            //        using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {
            //            //逆シリアル化して読み込む
            //            listCar = (BindingList<CarReport>)bf.Deserialize(fs);
            //            dgvCarReport.DataSource = null;
            //            dgvCarReport.DataSource = listCar;
            //        }
            //    }
            //    catch (Exception ex) {
            //        MessageBox.Show(ex.Message);
            //    }
            //    cbCarName.Items.Clear();
            //    foreach (var item in listCar) {

            //        setCbCarName(item.CarName);
            //    }
            //    cbAuther.Items.Clear();
            //    foreach (var item in listCar) {

            //        setCbAuther(item.Auther);
            //    }
            //}
            //EnabledCheck();
        }

        private void btSave_Click(object sender, EventArgs e) {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリー形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCar);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btUpdate_Click(object sender, EventArgs e) {

            //carReportDBDataGridView.CurrentRow.Cells[1].Value = 

            //int id = dgvCarReport.CurrentRow.Index;

            //listCar[id].CarName = cbCarName.Text;
            //listCar[id].Auther = cbAuther.Text;
            //listCar[id].Report = tbReport.Text;
            //listCar[id].Picture = pbCarPicture.Image;
            //dgvCarReport.Refresh();
        }

        private void CarReportSystem_Load(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202207DataSet.CarReportDB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202207DataSet.CarReportDB);
            // TODO: このコード行はデータを 'infosys202207DataSet.CarReportDB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202207DataSet.CarReportDB);

            //逆シリアル化

            EnabledCheck();
            //if (File.Exists("setting.xml")) {
            try {
                using (var reader = XmlReader.Create("setting.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFormColor);
                }
            }
            catch (Exception) {

            }
        }

        private void CarReportSystem_FormClosed(object sender, FormClosedEventArgs e) {            

            //var backcolor = new Settings();

            using (var writer = XmlWriter.Create("setting.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);                                
            }
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
    }
}
  
