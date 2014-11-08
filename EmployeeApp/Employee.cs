using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        // Field data
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;

        // Properties
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name must be less than 16 characters!");
                }
                else
                {
                    empName = value;
                }
            }
        }

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }


        // Constructors
        public Employee() { }
        public Employee(string name, int id, float pay) : this(name, 0, id, pay) { }
        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
        }

        //// Accessor (get method)
        //public string GetName()
        //{
        //    return empName;
        //}

        //// Mutator (set method)
        //public void SetName(string name)
        //{
        //    // Do a check on incoming value before making assignment
        //    if (name.Length > 15)
        //    {
        //        Console.WriteLine("Error! Name must be less than 16 characters!");
        //    }
        //    else
        //    {
        //        empName = name;
        //    }
        //}

        // Methods
        public void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Pay: {0}", Pay);
        }
    }
}
