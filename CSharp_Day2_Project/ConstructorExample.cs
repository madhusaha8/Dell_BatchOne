using System;

namespace CSharp_Day2_Project
{
    //class Student:ICloneable
    //{
    //    //Data Members
    //   int StudentId;
    //   string StudentName;
    //   int StudentAge;
    //   public static string UniversityName;

    //    //Static Constructor
    //    static Student()
    //    {
    //        UniversityName = "Amity University";
    //    }

    //    // Default Constructor(Parameterless Constructor
    //    public Student()
    //    {
    //        this.StudentId = 1001;
    //        this.StudentName = "Kartik";
    //        this.StudentAge = 22;
    //    }

    //    //Parameterized Constructor
    //    public Student(int StudentId, string StudentName, int StudentAge)
    //    {
    //        this.StudentId = StudentId;
    //        this.StudentName = StudentName;
    //        this.StudentAge = StudentAge;
    //    }

    //    //Copy Constructor
    //    public Student(Student st)
    //    {
    //        this.StudentId = st.StudentId;
    //        this.StudentName = st.StudentName;
    //        this.StudentAge = st.StudentAge;
    //    }

    //    //Member Function
    //    public void DisplayDetails()
    //    {
    //        Console.WriteLine("Student Details : ");
    //        Console.WriteLine("Student Id : {0}", this.StudentId);
    //        Console.WriteLine("Student Name : {0}", this.StudentName);
    //        Console.WriteLine("Student Age : {0}", this.StudentAge);
    //        Console.WriteLine("University Name : {0}", Student.UniversityName);
    //    }

    //    //Alternatively, Use Clone Instead of Copy Constructor
    //    public object Clone()
    //    {
    //        return this.MemberwiseClone();
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student std = new Student();
    //        //std.StudentId = 1001;
    //        //std.StudentName = "King Kochhar";
    //        //std.StudentAge = 23;

            
    //        std.DisplayDetails();
    //        Student.UniversityName = "Madurai University";
    //        Console.WriteLine(Student.UniversityName);
    //        Student std1 = new Student(1002, "Gautam", 27);
    //        //std1.StudentId = 1002;
    //        //std1.StudentName = "Gautam Bhalla";
    //        //std1.StudentAge = 33;
    //        std1.DisplayDetails();
    //        //Console.WriteLine("{0} : {1} : {2}", std.StudentId, std.StudentName, std.StudentAge);
    //        //std.DisplayDetails();

    //        Student std2 = new Student(std1);
    //        std2.DisplayDetails();

    //        Student std3 = std1.Clone() as Student;
    //        std3.DisplayDetails();

    //        Console.ReadKey();
    //    }
    //}
}
