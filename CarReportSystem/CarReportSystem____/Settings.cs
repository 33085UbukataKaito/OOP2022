using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {

    //設定情報
    public class Settings {
        private static Settings settings;
        
        public static Settings getInstance() {
            if (settings == null) {
            settings = new Settings();
        }
            return settings;
        }

        private Settings() {

        }
        
        public int MainFormColor { get; set; }
        
        

    
    }

}
