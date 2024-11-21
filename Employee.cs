using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Employee
    {
        private int _salary;
        private string _id;
        private string _name;
        private string _phone;
        private string _address;

        public Employee()
        {
            _name = "Omar Elsisi";
            _id = "123";
            _salary = 6000;
            _phone = "01064819492";
            _address = "Benha-qalubia";
        }
        public Employee(string name, int salary):this()
        {
            Name = name;
            Salary = salary;
        }
        public Employee(string name,int salary,string id):this(name, salary) 
        {
        Id=id;
        }
        public Employee(string name, int salary, string id,string phone) : this(name, salary, id)
        {
            Phone = phone;
        }
        public Employee(string name, int salary, string id, string phone,string address) : this(name, salary, id, phone)
        {
            Address = address;
        }


        public int Salary {
            get { return _salary; }
            set
            {
                if (value < 6000)
                {
                    Console.WriteLine("salary must be at least 6000 ");
                    _salary = 6000;
                }
                else
                {
                    _salary = value;
                }
            }
             }
    
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public string Phone
        {
            get { return _phone; }
            set {
                if (value != null && value.Length == 11 && (value.StartsWith("010") || value.StartsWith("011") || value.StartsWith("012") || value.StartsWith("015")))
                {
                    _phone = value;
                }
                else
                {
                    Console.WriteLine("please enter valide phone number ");
                }
            }
        }
    
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public void IncreaseSalary(int bounes)
        {
            _salary += bounes;
        }
        public void Display()
        {
            Console.WriteLine($"the name of employee is {Name ?? "Not Set"} \n the Id of employee is {Id} \n the salary of employee is {Salary} \n the phone of employee is {Phone ?? "Not Set"} \n the address of employee is {Address ?? "Not Set"}  ");
        }
    }
}
