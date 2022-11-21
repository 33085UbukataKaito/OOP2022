using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WetherApp {
    
    public partial class WetherApp : Form {

        

        public WetherApp() {
            InitializeComponent();
           
        }

        string areaCode;
        int dayCode;

        private void btWetherGet_Click(object sender, EventArgs e) {


            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            if(cbPrifecture.SelectedIndex != -1) {
                Prefecture item;

                item = (Prefecture)cbPrifecture.SelectedItem;

                areaCode = item.Code; 

            }
            if (cbDay.SelectedIndex != -1) {
                Day days;

                days = (Day)cbDay.SelectedItem;

                dayCode = days.dNumber;


            }
            
            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/" + areaCode + ".json");
            var cString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/" + areaCode + ".json");
            
            var json = JsonConvert.DeserializeObject<Rootobject>(dString);
            var json2 = JsonConvert.DeserializeObject<Class1[]>(cString);
            
            tbWetherInfo.Text = json.text;
            tbDay.Text = json2[0].timeSeries[0].areas[0].weathers[dayCode];

           
            var wether = json2[0].timeSeries[0].areas[0].weatherCodes[dayCode];
            var astring = "https://www.jma.go.jp/bosai/forecast/img/" + wether +".png";
           
            pbWether.ImageLocation = astring;
        }

        public class Day {
            private string DayCode = "";
            private int DayNumber; 

            public Day(string day,int Dnumber) {
                DayCode = day;
                DayNumber = Dnumber;
            }

            public string DayName {
                get {
                    return DayCode;
                }
            }

            public int dNumber {
                get {
                    return DayNumber;
                }
            }

            public override string ToString() {
                return DayCode;
            }
        }

 
        public class Prefecture {
            private string wetherCode = "";
            private string PrefectureName = "";
             


            public Prefecture(string code, string name) {
                wetherCode = code;
                PrefectureName = name;
                
            }

            public string Code {
                get {
                    return wetherCode;
                }
            }

            public string Name {
                get {
                    return PrefectureName;
                }
            }

            

            public override string ToString() {
                return PrefectureName;
            }
        }
        private void Form1_Load(object sender, EventArgs e) {
            
            Prefecture item;

            item = new Prefecture("011000", "北海道");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("020000","青森");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("050000", "秋田");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("030000", "岩手");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("040000", "宮城");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("060000", "山形");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("070000", "福島");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("080000", "茨城");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("090000", "栃木");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("100000", "群馬");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("110000", "埼玉");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("130000", "東京");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("120000", "千葉");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("140000", "神奈川");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("200000", "長野");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("190000", "山梨");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("220000", "静岡");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("230000", "愛知");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("210000", "岐阜");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("240000", "三重");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("150000", "新潟");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("160000", "富山");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("170000", "石川");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("180000", "福井");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("250000", "滋賀");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("260000", "京都");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("270000", "大阪");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("280000", "兵庫");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("290000", "奈良");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("300000", "和歌山");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("330000", "岡山");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("340000", "広島");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("320000", "島根");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("310000", "鳥取");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("360000", "徳島");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("370000", "香川");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("380000", "愛媛");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("390000", "高知");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("350000", "山口");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("400000", "福島");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("440000", "大分");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("420000", "長崎");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("410000", "佐賀");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("430000", "熊本");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("450000", "宮崎");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("460100", "鹿児島");
            cbPrifecture.Items.Add(item);

            item = new Prefecture("471000", "沖縄");
            cbPrifecture.Items.Add(item);



            Day days;

            days = new Day("今日",0);
            cbDay.Items.Add(days);

            days = new Day("明日",1);
            cbDay.Items.Add(days);

            days = new Day("明後日",2);
            cbDay.Items.Add(days);
        }

    }
}






