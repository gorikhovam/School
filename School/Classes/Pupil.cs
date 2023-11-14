using School.Classes.Abstract;
using School.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Classes
{
    internal class Pupil : Human, IPupil
    {
        DateTime _birthDate;
        int _entryYear;
        public DateTime BirthDate { get { return _birthDate; } }
        public int EntryYear { get { return _entryYear; } }
#nullable enable
        IClass? _class;
        public IClass? Class { get { return _class; } set { _class = value; } }
        public Pupil(int id, string fullName, string address, DateTime birthDate, int entryYear, IClass? clas) : base(id, fullName, address)
        {
            _birthDate = birthDate;
            _entryYear = entryYear;
            _class = clas;
        }
#nullable disable
        public void LessonNotify(ILesson lesson)
        {
            Console.Clear();
            Console.WriteLine($"{lesson.Subject} Lesson started!");
            Console.ReadKey();
        }
        public override string ToString()
        {
            return "[Pupil]" + base.ToString() + $"{_class.Name}";
        }
    }
}
