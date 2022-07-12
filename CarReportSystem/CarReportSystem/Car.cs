using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {

    [Serializable]
    class Car {
        [System.ComponentModel.DisplayName("記録者")]
        public string Reporter { get; set; }

        [System.ComponentModel.DisplayName("車名")]
        public string CarName { get; set; }

        [System.ComponentModel.DisplayName("レポート")]
        public string Report { get; set; }
        public List<GroupType> listGroup { get; set; }

        [System.ComponentModel.DisplayName("メーカー")]
        public string Group {
            get {
                string groups = "";
                foreach (GroupType group in listGroup) {
                    groups += "[" + group + "]";

                }
                return groups;
            }
        }
    }
}

        public enum GroupType {
            トヨタ,
            日産,
            ホンダ,
            スバル,
            外国車,
            その他,
        }

[System.ComponentModel.DisplayName("画像")]
    public Image Picture { get; set; }
    
}
