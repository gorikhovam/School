using System;
using System.Collections.Generic;
using System.Text;

namespace School.Interface
{
    internal interface IClass
    {
        int EntryYear {  get; }
        string Name { get; }
        ICabinet Cabinet { get; }
        List<IPupil> Pupils {  get; }
        ITeacher Teacher { get; }
    }
}
