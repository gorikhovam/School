using School.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace School.Classes
{
    internal class Lesson : ILesson
    {
        int _id;
        string _subject;
        ITeacher _teacher;
        IClass _class;
        DateTime _time;
        public int Id { get { return _id; } }
        public string Subject { get { return _subject; } }
        public ITeacher Teacher { get { return _teacher; } }
        public IClass Class { get { return _class; } }
        public DateTime Time { get { return _time; } }
        public event LessonHandler OnLessonStart;
        public Lesson(int id, string subject, ITeacher teacher, IClass clas, DateTime time)
        {
            _subject = subject;
            _id = id;
            _teacher = teacher;
            _class = clas;
            _time = time;
        }
        public void Started()
        {
            OnLessonStart?.Invoke(this);
        }
        public override string ToString()
        {
            return $"[Lesson]\n" +
                   $"{_time} " +
                   $"{_subject}\n" +
                   $"{_teacher.FullName}\n" +
                   $"Class: {_class.Name}";
        }
    }
}
