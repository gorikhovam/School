using System;
using System.Collections.Generic;
using System.Text;

namespace School.Interface
{
    internal interface ISchool
    {
        int Id {  get; }
        string Name { get; }
        string Address {  get; }
        List<IClass> Classes { get; }
        List<IStaff> Staff { get; }
        List<IPupil> Pupils { get; }
        List<ILesson> Schedule {  get; }
    }
}
