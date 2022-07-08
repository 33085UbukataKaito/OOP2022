using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exersice01 {

    [XmlRoot("employee")]
    public class Employee {
        [XmlElement("ElementName = id")]
        public int Id { get; set; }
        [XmlElement("ElementName = name")]
        public string Name { get; set; }
        [XmlElement("ElementName = hiredate")]
        public DateTime HireDate { get; set; }

        [XmlElement(Type = typeof(Employee), ElementName = "employee")]
        public Employee Employees { get; set; }
    }
    class Program {
        static void Main(string[] args) {

           

            //Exercise1_1("employee.xml");
            Deserialize();

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            //Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string v) {

            var emp = new Employee {
                Id = 123,
                Name = "出井　秀行",
                HireDate = new DateTime(2001, 5, 10)
            };

            var employees = new Employee {
                 Employees = emp
            };

            using (var writer = XmlWriter.Create("employee.xml")) {
                var serializer = new XmlSerializer(emp.GetType());
                serializer.Serialize(writer, emp);
            }
            Display("employee.xml");
        }
        public static void Deserialize() {
            using (var reader = XmlReader.Create("novels.xml")) {
                var serializer = new XmlSerializer(typeof(Employee));
                var emp = serializer.Deserialize(reader) as Employee;
                // 以下、内容を確認するコード
                
                    Console.WriteLine(emp);
                

            }
        }

        private static void Exercise1_2(string v) {

        }

        private static void Exercise1_3(string v) {
 
        }

        private static void Exercise1_4(string v) {

        }
        private static void Display(string filename) {
            var lines = File.ReadLines(filename);
            foreach (var line in lines)
                Console.WriteLine(line);

        }
    }
}
