using School.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Classes
{
    internal class Class : IClass
    {
        int _entryYear;
        string _name;
        ICabinet _cabinet;
        List<IPupil> _pupils;
        ITeacher _teacher;
        public int EntryYear { get { return _entryYear; } }
        public string Name { get { return _name; } }
        public ICabinet Cabinet { get { return _cabinet; } }
        public List<IPupil> Pupils { get { return _pupils; } }
        public ITeacher Teacher { get { return _teacher; } }
        public Class(int entryYear, string name, ICabinet cabinet, List<IPupil> pupils, ITeacher teacher)
        {
            _entryYear = entryYear;
            _name = name;
            _cabinet = cabinet;
            _pupils = pupils;
            _teacher = teacher;
        }
        public override string ToString()
        {
            return $"[Class]\n{Name}\nTeacher:{_teacher.FullName}\nCabinet:{_cabinet.Number}";
        }
    }
}
