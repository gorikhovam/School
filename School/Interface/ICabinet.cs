using System;
using System.Collections.Generic;
using System.Text;

namespace School.Interface
{
    internal interface ICabinet
    {
        int Number {  get; }
        int Capacity {  get; }
        IClass Class { get; set; }
    }
}
