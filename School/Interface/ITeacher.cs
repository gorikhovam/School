using System;
using System.Collections.Generic;
using System.Text;

namespace School.Interface
{
    internal interface ITeacher:IStaff
    {
        int Experience { get; }
        string Subject { get; }
        IClass Class { get; set; }
    }
}
