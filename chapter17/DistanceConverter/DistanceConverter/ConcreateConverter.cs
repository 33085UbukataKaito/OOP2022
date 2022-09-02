using DistanceConverter.FrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {


    public class MeterConverter : ConverterBase {
        public override string UnitName => "メートル"; 
        protected override double Ratio => 1;

        public override bool IsMyUnit(string name) {
            return name.ToLower() == "meter" || name == UnitName;
        }
    }

    public class FeetConverter : ConverterBase {
        public override string UnitName =>"フィート";
        protected override double Ratio => 0.3048;

        public override bool IsMyUnit(string name) {
            return name.ToLower() == "feet" || name == UnitName;
        }
    }

    public class InchConverter : ConverterBase {
        public override string UnitName =>"インチ";
        protected override double Ratio => 0.0254;

        public override bool IsMyUnit(string name) {
            return name.ToLower() == "inch" || name == UnitName;
        }
    }

    public class YardConverter : ConverterBase {
        public override string UnitName =>"ヤード";
        protected override double Ratio => 0.9144;

        public override bool IsMyUnit(string name) {
            return name.ToLower() == "yard" || name == UnitName;
        }
    }

    public class MileConverter : ConverterBase {
        public override string UnitName => "マイル";
        protected override double Ratio => 1609.344;

        public override bool IsMyUnit(string name) {
            return name.ToLower() == "Mile" || name == UnitName;
        }
    }

    public class KiloConverter : ConverterBase {
        public override string UnitName => "キロ";
        protected override double Ratio => 1000;

        public override bool IsMyUnit(string name) {
            return name.ToLower() == "Kilo" || name == UnitName;
        }
    }
}
