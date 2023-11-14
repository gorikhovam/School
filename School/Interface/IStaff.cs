using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace School.Interface
{
    internal interface IStaff:IHuman
    {
        decimal Salary {  get; }
        void ChangeSalary(decimal salary);
    }
}
