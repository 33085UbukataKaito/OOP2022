using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execise2{
    class Program {
        // FeetConverter MeterToFeet = new FeetConverter();
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                //フィートからメートルへの対応表を出力
                printInchToMeterList(1, 10);
            }
            else {
                //メートルからフィートへの対応表を出力
                printMeterToInchList(1, 10);
            }
        }

        //メートルからフィートへの対応表を出力
        private static void printMeterToInchList(int start, int stop) {
            // FeetConverter fc = new FeetConverter();
            for (int meter = 1; meter <= 10; meter++) {
                double inch = InchConverter.ToMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} in", meter, inch);
            }
        }

        //フィートからメートルへの対応表を出力
        private static void printInchToMeterList(int start, int stop) {
            //FeetConverter fc = new FeetConverter();
            for (int inch = 1; inch <= 10; inch++) {
                double meter = InchConverter.FromMeter(inch);
                Console.WriteLine("{0} in = {1:0.0000} m", inch, meter);
            }
        }
    }
}

