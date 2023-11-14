using System;
using System.Collections.Generic;
using System.Text;

namespace School.Interface
{
    internal interface IPupil:IHuman
    {
        DateTime BirthDate { get; }
        int EntryYear { get; }
        IClass Class { get; set; }
        void LessonNotify(ILesson lesson);
    }
}
