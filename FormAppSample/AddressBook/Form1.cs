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
        BindingList<Person> listPerson = new BindingList<Person>();
        public Form1() {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if(ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }

        private void btAddPerson_Click(object sender, EventArgs e) {
            Person newPerson = new Person {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = getcheckboxgroup(),
            };

            listPerson.Add(newPerson);
        }

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

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //データグリッドビューをクリックしたときのイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e) {
            
            int id = dgvPersons.CurrentRow.Index;
            tbName.Text = listPerson[id].Name;
            tbAddress.Text = listPerson[id].Address;
            tbCompany.Text = listPerson[id].Company;
            tbMailAddress.Text = listPerson[id].MailAddress;
            pbPicture.Image = listPerson[id].Picture;



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
            }

        }
    }
}
