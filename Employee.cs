using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnListEmployee
{
    internal class Employee
    {
        public string _fullName;
        public double _salary;
        public int _department;
        public int _id;

        public Employee(string fullName, int id, int department, double salary)
        {
            _fullName = fullName;
            _id = id;
            _department = department;
            _department = department;
            _salary = salary;
        }

        public string FullName
        {
            get => _fullName;
            set => _fullName = value;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public int Department
        {
            get => _department;
            set => _department = value;
        }

        public double Salary
        {
            get => _salary;
            set => _salary = value;
        }
    }
}
