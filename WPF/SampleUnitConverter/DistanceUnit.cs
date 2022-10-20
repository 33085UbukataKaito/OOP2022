using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    public class DistanceUnit {
        public string Name { get; set; }        //単位の名称
        public double Coefficient { get; set; }//係数
        public override string ToString() {
            return this.Name;
        }
    }

    //メートル単位を表すクラス
    public class MetricUnit : DistanceUnit {
        private static List<MetricUnit> units = new List<MetricUnit> {
            new MetricUnit{Name = "mm",Coefficient = 1},
            new MetricUnit{Name = "cm",Coefficient = 10},
            new MetricUnit{Name = "m",Coefficient = 10*100},
            new MetricUnit{Name = "km",Coefficient = 10*100*1000},
        };
    }

    public class ImperialUnit : DistanceUnit {

    }
}
