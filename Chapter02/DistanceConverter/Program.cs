using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class Program {
       // FeetConverter MeterToFeet = new FeetConverter();
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                //フィートからメートルへの対応表を出力
                printFeetToMeterList(1,10);
            }
            else {
                //メートルからフィートへの対応表を出力
                printMeterToFeetList(1,10);
            }
        }

        //メートルからフィートへの対応表を出力
        private static void printMeterToFeetList(int start, int stop) {
           // FeetConverter fc = new FeetConverter();
            for (int meter = 1; meter <= 10; meter++) {
                double feet = FeetConverter.ToMeter( meter);
                Console.WriteLine("{10} m = {1:0.0000} ft", meter, feet);
            }
        }

        //フィートからメートルへの対応表を出力
        private static void printFeetToMeterList(int start, int stop) {
            //FeetConverter fc = new FeetConverter();
            for (int feet = 1; feet <= 10; feet++) {
                double meter = FeetConverter.FromMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        } 
    }
}
