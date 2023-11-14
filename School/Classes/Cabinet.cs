using School.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Classes
{
    internal class Cabinet : ICabinet
    {
        int _number;
        int _capacity;
        public int Number { get { return _number; } }
        public int Capacity { get { return _capacity; } }
#nullable enable
        IClass? _class;
        public IClass? Class { get { return _class; } set { _class = value; } }
        public Cabinet(int number, int capacity, IClass? clas)
        {
            _number = number;
            _capacity = capacity;
            _class = clas;
        }
#nullable disable
        public override string ToString()
        {
            return $"[Cabinet]\n" +
                   $"{_number}\n";
        }
    }
}
