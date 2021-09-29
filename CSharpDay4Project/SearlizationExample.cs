using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay4Project
{
    [Serializable]
    class Employee
    {
        public string Name { get; set; }
        public float Salary { get; set; }
        public int Age { get; set; }
    }
    class SerializeDeserialize
    {
        public static void SerializeObject(Employee emp)
        {
            IFormatter fmtr = new BinaryFormatter();
            FileStream fs = new FileStream("C:\\Users\\madhu_saha\\Downloads\\FSD_training\\example2.txt", FileMode.Create, FileAccess.Write);
            fmtr.Serialize(fs, emp);
            Console.WriteLine("Employee object is searlized");
            fs.Close();
        }
        public static Employee DesearlizeObject()
        {
            IFormatter formatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("C:\\Users\\madhu_saha\\Downloads\\FSD_training\\example2.txt", FileMode.Open, FileAccess.Read);
            Employee employee = (Employee)formatter.Deserialize(fileStream);
            Console.WriteLine("Employee Object is desearlized.");
            fileStream.Close();
            return employee;
        }
    }
    class SearlizationExample
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Name = "Gautam",
                Salary = 12000,
                Age = 23
            };
            SerializeDeserialize.SerializeObject(employee);
            Console.WriteLine("****************");
            var empObj = SerializeDeserialize.DesearlizeObject();
            Console.WriteLine("{0} : {1} : {2}", empObj.Name, empObj.Salary, empObj.Age);

        }
    }
}
