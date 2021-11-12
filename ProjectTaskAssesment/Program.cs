using System;
using System.IO;
using System.Text;

namespace ProjectTaskAssesment
{
    class Program
    {
       static string fileName = "C:\\Users\\madhu_saha\\Downloads\\FSD_training\\TeacherData.txt";

        public static void fileCreate(string CreateFile)
        {

            if (CreateFile == "yes")
            {
                string data;
                if (File.Exists(fileName))
                {
                    Console.WriteLine("File already exists!!");
                }
                else
                {
                    FileStream FS = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    Console.WriteLine("file created successfully");
                    FS.Close();
                }
            }
        }
        public static void writeFile(string WriteFile)
        {
            string Id = "";
            string Name = "";
            string ClassSection = "";
            if (WriteFile == "yes")
            {
                var length = new System.IO.FileInfo(fileName).Length;
                if (length == 0)
                {
                    using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Write))
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        Console.WriteLine("Enter teacher id : " + Id);
                        Id = Console.ReadLine();
                        Console.WriteLine("Enter teacher name : " + Name);
                        Name = Console.ReadLine();
                        Console.WriteLine("Enter teacher class&section : " + ClassSection);
                        ClassSection = Console.ReadLine();
                        string fullText = ("Id : " + Id + " Name : " + Name + " Class&Section : " + ClassSection);
                        sw.WriteLine(fullText);
                        //File.AppendAllText("C:\\Users\\madhu_saha\\Downloads\\FSD_training\\TeacherData.txt", Id + Environment.NewLine+ Name+ Environment.NewLine + ClassSection + Environment.NewLine);//can't get this way working, even after switching "\"s to "/"s. It says that the file is being used by another process.
                        Console.WriteLine("Write Content successfully");
                        Console.ReadLine();
                    }
                }
                else
                {
                    using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        Console.WriteLine("Enter teacher id : " + Id);
                        Id = Console.ReadLine();
                        Console.WriteLine("Enter teacher name : " + Name);
                        Name = Console.ReadLine();
                        Console.WriteLine("Enter teacher class&section : " + ClassSection);
                        ClassSection = Console.ReadLine();
                        string fullText = ("Id : " + Id + " Name : " + Name + " Class&Section : " + ClassSection);
                        sw.WriteLine(fullText);
                        Console.WriteLine("Data appended successfully");
                        Console.ReadLine();
                    }
                }
            }
        }
        public static void RetrieveFile(string retrieveFile)
        {
            
            if (retrieveFile == "yes")
            {
                var length = new System.IO.FileInfo(fileName).Length;
                if (length != 0)
                {
                    using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string content = sr.ReadToEnd();
                        Console.WriteLine("retrieve Content successfully:\n" + content);
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("File is empty");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to create file ? ");
            string CreateFile = Console.ReadLine();
            fileCreate(CreateFile);
            Console.WriteLine("Do you want to write to file ? ");
            string WriteFile = Console.ReadLine();
            writeFile(WriteFile);
            Console.WriteLine("Do you want to retrieve teacher data ? ");
            string retrieveFile = Console.ReadLine();
            RetrieveFile(retrieveFile);

        }
    }
}
