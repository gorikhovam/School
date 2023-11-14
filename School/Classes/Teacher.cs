using School.Classes.Abstract;
using School.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Classes
{
    internal class Teacher : Staff, ITeacher
    {
        int _experience;
        string _subject;

        public int Experience { get { return _experience; } }
        public string Subject { get { return _subject; } }
#nullable enable
        IClass? _class;
        public IClass? Class { get { return _class; } set { _class = value; } }
        public Teacher(int id, string fullName, string address, decimal salary, string subject, IClass? clas) : base(id, fullName, address, salary)
        {
            Random random = new Random();
            _experience = random.Next(0, 31);
            _subject = subject;
            _class = clas;
        }
#nullable disable
        public override string ToString()
        {
            return "[Teacher]\n" + base.ToString() + $"{_subject}";
        }
    }
}
    

