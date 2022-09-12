using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void addressTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.addressTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202207DataSet);

        }

        private void Form1_Load(object sender, EventArgs e) {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void addressTableDataGridView_Click(object sender, EventArgs e) {
            if (addressTableDataGridView.CurrentRow == null)
                return;

            tbName.Text = addressTableDataGridView.CurrentRow.Cells[1].Value.ToString();
            tbAddress.Text = addressTableDataGridView.CurrentRow.Cells[2].Value.ToString();
            tbTell.Text = addressTableDataGridView.CurrentRow.Cells[3].Value.ToString();
            tbMail.Text = addressTableDataGridView.CurrentRow.Cells[4].Value.ToString();
            tbMemo.Text = addressTableDataGridView.CurrentRow.Cells[5].Value.ToString();
            if(!(addressTableDataGridView.CurrentRow.Cells[6].Value is DBNull))
                pbImage.Image = ByteArrayToImage((byte[])addressTableDataGridView.CurrentRow.Cells[6].Value);
            else {
                pbImage.Image = null;
            }
        }

        private void btUpdate_Click(object sender, EventArgs e) {
            addressTableDataGridView.CurrentRow.Cells[1].Value = tbName.Text ;
            addressTableDataGridView.CurrentRow.Cells[2].Value = tbAddress.Text;
            addressTableDataGridView.CurrentRow.Cells[3].Value = tbTell.Text;
            addressTableDataGridView.CurrentRow.Cells[4].Value = tbMail.Text;
            addressTableDataGridView.CurrentRow.Cells[5].Value = tbMemo.Text;
            addressTableDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbImage.Image);


            this.Validate();
            this.addressTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202207DataSet);
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdImage.Filter = "画像ファイル(*.jpg; *.png; *.bmp)| *.jpg; *.png; *.bmp";
            if (ofdImage.ShowDialog() == DialogResult.OK) {
                pbImage.Image = System.Drawing.Image.FromFile(ofdImage.FileName);
            }
        }

        private void btImageDelete_Click(object sender, EventArgs e) {
            pbImage.Image = null;
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

        private void btAdd_Click(object sender, EventArgs e) {
            DataRow newRow = infosys202207DataSet.AddressTable.NewRow();
            newRow[1] = tbName.Text;
            newRow[2] = tbAddress.Text;
            newRow[3] = tbTell.Text;
            newRow[4] = tbMail.Text;
            newRow[5] = tbMemo.Text;
            newRow[6] = ImageToByteArray(pbImage.Image);
            //データセットに新しいレコードを追加
            infosys202207DataSet.AddressTable.Rows.Add(newRow);
            //データベース更新
            this.addressTableTableAdapter.Update(this.infosys202207DataSet);

            //this.Validate();
            //this.addressTableBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.infosys202207DataSet);
        }

        private void btNameSearch_Click(object sender, EventArgs e) {
            this.addressTableTableAdapter.FillByName(this.infosys202207DataSet.AddressTable, tbNameSearch.Text);
        }

        private void btClear_Click(object sender, EventArgs e) {
            tbName.Text = null;
            tbAddress.Text = null;
            tbTell.Text = null;
            tbMail.Text = null;
            tbMemo.Text = null;
            pbImage.Image = null;
        }

        private void btNameDelete_Click(object sender, EventArgs e) {
            tbNameSearch.Text = null;
        }

        private void tismDatabaseConect_Click(object sender, EventArgs e) {
            this.addressTableTableAdapter.Fill(this.infosys202207DataSet.AddressTable);
        }

        private void tismVersionData_Click(object sender, EventArgs e) {
            new Version().ShowDialog();
        }
    }
}
