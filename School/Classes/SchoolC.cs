using School.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Classes
{
    internal class SchoolC : ISchool
    {
        int _id;
        string _name;
        string _address;
        List<IClass> _classes;
        List<IStaff> _staff;
        List<IPupil> _pupils;
        List<ILesson> _schedule;
        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
        public string Address { get { return _address; } }
        public List<IClass> Classes { get { return _classes; } }
        public List<IStaff> Staff { get { return _staff; } }
        public List<IPupil> Pupils { get { return _pupils; } }
        public List<ILesson> Schedule { get { return _schedule; } }
        public SchoolC(int id, string name, string address, List<IClass> classes, List<IStaff> staff, List<IPupil> pupils, List<ILesson> schedule)
        {
            _id = id;
            _name = name;
            _address = address;
            _classes = classes;
            _staff = staff;
            _pupils = pupils;
            _schedule = schedule;
        }
    }
}
