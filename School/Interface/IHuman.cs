using System;
using System.Collections.Generic;
using System.Text;

namespace School.Interface
{
    internal interface IHuman
    {
        int Id {  get; }
        string FullName {  get; }
        string Address {  get; }
        string Phone {  get; }
    }
}
