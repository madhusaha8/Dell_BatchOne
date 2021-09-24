﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThree_Project
{
    class Person
    {
        private int _personId;
        private string _personName;

        public Person(int personId, string personName)
        {
            this._personId = personId;
            this._personName = personName;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Id : {0}, Name : {1}", this._personId, this._personName);
        }
    }

    class Employee:Person
    {
        private float _salary;
        private string _designation;

        public Employee(int personId, string personName, float salary, string designmation):
            base(personId,personName)
        {
            this._salary = salary;
            this._designation = designmation;
        }
        public new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Salary : {0}, Designation : {1}", this._salary, this._designation);

        }
    }
    //class OverridingExample
    //{
    //    static void Main(string[] srgs)
    //    {
    //        Employee emp = new Employee(1001, "Madhu", 10000, "Manager");
    //        emp.DisplayDetails();

    //        Person person = new Employee(1001, "Madhu", 10000, "Manager");
    //        person.DisplayDetails();

    //        Console.ReadKey();
    //    }
    //}
}
