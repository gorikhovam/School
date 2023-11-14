using School.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Classes.Abstract
{
    internal abstract class Staff : Human, IStaff
    {
        protected decimal _salary;
        public decimal Salary { get { return _salary; } }
        public Staff(int id, string fullName, string address, decimal salary) : base(id, fullName, address)
        {
            _salary = salary;
        }
        public void ChangeSalary(decimal salary)
        {
            _salary = salary;
        }
        public override string ToString()
        {
            return base.ToString() + $"{_salary}\n";
        }
    }
}
