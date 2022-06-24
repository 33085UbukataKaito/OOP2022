using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Form1 : Form {
        BindingList<Person> listPerson = new BindingList<Person>();


        public Form1() {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }

        private void btAddPerson_Click(object sender, EventArgs e) {

            //if (listPerson.Count()>0) {
            //    btAddPerson.Enabled = false;
            //}

            if (String.IsNullOrWhiteSpace(tbName.Text)) {
                MessageBox.Show("氏名が入力されていません");
                return;
            }

            Person newPerson = new Person {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = cbCompany.Text,
                Picture = pbPicture.Image,
                Registration = dtpRegistDate.Value,
                KindNumber = getradioboxgroup(),
                TellNumber = tbTellNumber.Text,
                listGroup = getcheckboxgroup(),
            };

            listPerson.Add(newPerson);
            dgvPersons.Rows[dgvPersons.RowCount - 1].Selected = true;

            //if (listPerson.Count() > 0) {
            //    btDelete.Enabled = true;
            //    btUpdate.Enabled = true;
            //}
            EnabledCheck();

            setCbCompany(cbCompany.Text);
        }
        private void setCbCompany(string company) {

            if (!cbCompany.Items.Contains(company)) {
                //まだ登録されていなければ登録
                cbCompany.Items.Add(company);
            }
        }

        //コンボボックスに会社名を登録（重複なし）
        //if (cbCompany.Text != "" && cbCompany.Items.IndexOf(cbCompany.Text) == -1)
        //    cbCompany.Items.Add(cbCompany.Text);




        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> getcheckboxgroup() {
            var listgroup = new List<Person.GroupType>();

            if (cbFamily.Checked) {
                listgroup.Add(Person.GroupType.家族);
            }
            if (cbFriend.Checked) {
                listgroup.Add(Person.GroupType.友人);
            }
            if (cbWork.Checked) {
                listgroup.Add(Person.GroupType.仕事);
            }
            if (cbOther.Checked) {
                listgroup.Add(Person.GroupType.その他);
            }
            return listgroup;
        }

        private Person.KindNumberType getradioboxgroup() {
            var selectedKindNumber = Person.KindNumberType.その他;

            if (rbHome.Checked) //自宅にチェックがついている
            {
                selectedKindNumber = Person.KindNumberType.自宅;
            }
            if (rbMobile.Checked) //携帯にチェックがついている
            {
                selectedKindNumber = Person.KindNumberType.携帯;
            }
            return selectedKindNumber;
        }

        //Person.KindNumberType selectedKindNumber = Person.KindNumberType.その他;
        //if (rbHome.Checked) {
        //    return Person.KindNumberType.自宅;
        //}else{ 
        //    return Person.KindNumberType.携帯;
        //}
    

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //データグリッドビューをクリックしたときのイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e) {

            if (dgvPersons.CurrentRow == null) return;

            int id = dgvPersons.CurrentRow.Index;
            tbName.Text = listPerson[id].Name;
            tbAddress.Text = listPerson[id].Address;
            cbCompany.Text = listPerson[id].Company;
            tbMailAddress.Text = listPerson[id].MailAddress;
            pbPicture.Image = listPerson[id].Picture;
            dtpRegistDate.Value = listPerson[id].Registration.Year > 1900 ? listPerson[id].Registration : DateTime.Today;
            tbTellNumber.Text = listPerson[id].TellNumber;

            setGroupType(id);//グループを設定
            setKindNumberType(id);//番号種別を設定
        }

        private void setKindNumberType(int id) {
            if (listPerson[id].KindNumber == Person.KindNumberType.自宅) {
                rbHome.Checked = true;
            }
            if (listPerson[id].KindNumber == Person.KindNumberType.携帯) {
                rbMobile.Checked = true;
            }
        }

        private void setGroupType(int id) {
            groupCheckBoxAllClear();

            foreach (var item in listPerson[id].listGroup) {
                switch (item) {
                    case Person.GroupType.家族:
                        cbFamily.Checked = true;
                        break;
                    case Person.GroupType.友人:
                        cbFriend.Checked = true;
                        break;
                    case Person.GroupType.仕事:
                        cbWork.Checked = true;
                        break;
                    case Person.GroupType.その他:
                        cbOther.Checked = true;
                        break;
                    default:
                        break;
                }
                //番号種別チェック処理

            }
        }

        //グループのチェックボックスをすべてクリア
        private void groupCheckBoxAllClear() {
            cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
        }


        private void btUpdate_Click(object sender, EventArgs e) {
            //listPerson[dgvPersons.CurrentRow.Index].Name = tbName.Text;
           
            int id = dgvPersons.CurrentRow.Index;
           listPerson[id].Name  = tbName.Text;
           listPerson[id].Address = tbAddress.Text ;
           listPerson[id].Company = cbCompany.Text;
           listPerson[id].MailAddress  = tbMailAddress.Text;
           listPerson[id].Picture  = pbPicture.Image;
            listPerson[id].Registration = dtpRegistDate.Value;
           listPerson[id].listGroup = getcheckboxgroup();
            dgvPersons.Refresh();
               
        }

        private void btDelete_Click(object sender, EventArgs e) {
            int id = dgvPersons.CurrentRow.Index;
            listPerson.Remove(listPerson[id]);

            if (listPerson.Count() == 0)
            {
                //listPerson.RemoveAT(dgvPersons.CurrentRow.Index);
                EnabledCheck();
            }
        }

        //更新削除ボタンのマスク処理（マスク判定含む）
        private void EnabledCheck() {

            btUpdate.Enabled = btDelete.Enabled = listPerson.Count() > 0 ? true : false;
                
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            EnabledCheck();
        }

        //保存ボタンのイベントハンドラ
        private void btSave_Click(object sender, EventArgs e) {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリー形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName,FileMode.Create)) {
                        bf.Serialize(fs, listPerson);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e) {
            
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリー形式でシリアル化
                    var bf = new BinaryFormatter();

                    using(FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listPerson = (BindingList<Person>)bf.Deserialize(fs);
                        dgvPersons.DataSource = null;
                        dgvPersons.DataSource = listPerson;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                cbCompany.Items.Clear();
                foreach(var item in listPerson) {
                    
                    setCbCompany(item.Company);
                }
            }
            EnabledCheck();
        }
    }
}
