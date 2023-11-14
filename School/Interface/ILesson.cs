using System;
using System.Collections.Generic;
using System.Text;

namespace School.Interface
{
    delegate void LessonHandler(ILesson lesson);
    internal interface ILesson
    {
        int Id {  get; }
        string Subject { get; }
        ITeacher Teacher { get; }
        IClass Class { get; }
        DateTime Time { get; }
        event LessonHandler OnLessonStart;
        void Started();
    }
}
