using School.Classes;
using School.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    internal class Application
    {
        public static void Run()
        {
            List<IPupil> pupils = new List<IPupil>()
            {
                new Pupil(0,"Ivan Petrovych","address 1",new DateTime(2013,1,9),2019,null),
                new Pupil(1,"Valentyna Hrushch","address 2",new DateTime(2013,2,10),2019,null),
                new Pupil(2,"Viktor Tymoshenko","address 3",new DateTime(2013,3,13),2019,null),
                new Pupil(3,"Alina Usovych","address 4",new DateTime(2013,4,15),2019,null)
            };
            List<IStaff> staff = new List<IStaff>()
            {
                new Teacher(0,"Larysa Vasylivna","address 11",5000,"math",null),
                new Teacher(1,"Oksana Borysivna","address 12",6000,"language",null),
                new Teacher(2,"Volodymyr Anatolievych","address 13",7000,"science",null),
                new Teacher(0,"Liudmila Grygorievna","address 14",8000,"english",null),
            };
            List<ITeacher> teachers = staff.OfType<ITeacher>().ToList();
            List<ICabinet> cabinets = new List<ICabinet>()
            {
                new Cabinet(10,15,null),
                new Cabinet(11,18,null),
                new Cabinet(12,20,null)
            };
            List<IClass> classes = new List<IClass>()
            {
                new Class(2019,"A",cabinets[2],pupils,teachers[2])
            };
            foreach(Pupil pupil in pupils)
            {
                pupil.Class = classes[0];
            }
            teachers[2].Class = classes[0];
            cabinets[2].Class = classes[0];
            List<ILesson> lessons = new List<ILesson>() 
            {
                new Lesson(0,"Math",teachers[0],classes[0],new DateTime(2023,10,30,8,30,00)),
                new Lesson(1,"Language",teachers[1],classes[0],new DateTime(2023,10,30,9,20,00)),
                new Lesson(2,"Science",teachers[2],classes[0],new DateTime(2023,10,30,10,20,00)),
                new Lesson(3,"English",teachers[3],classes[0],new DateTime(2023,10,30,11,10,00)),
            };
            ISchool school = new SchoolC(0,"Specialized School 1","Dovga 37",classes,staff,pupils,lessons);
            string temp;
            do
            {
                Console.Clear();
                Console.Write("Enter pupil Full Name:");
                temp = Console.ReadLine();
            }
            while (!pupils.Exists(p => p.FullName == temp));
            while (true)
            {
                IPupil pupil = pupils.Where(p => p.FullName == temp).FirstOrDefault();
                Menu();
                switch (Select())
                {
                    case 0:
                        do
                        {
                            Console.Clear();
                            ShowSchedule(pupil, school);
                        }
                        while (Console.ReadKey(intercept: true).KeyChar != '0');
                        break;
                    case 1:
                        foreach(ILesson lesson in school.Schedule.Where(l => l.Class == pupil.Class).OrderBy(l => l.Time))
                        {
                            lesson.OnLessonStart += pupil.LessonNotify;
                        }
                        Console.Clear();
                        Console.WriteLine("Subscribed!!!\nPress any button...");
                        Console.ReadKey();
                        break;
                    case 2:
                        school.Schedule.Where(l => l.Class == pupil.Class).OrderBy(l => l.Time).First().Started();
                        break;
                    case 3:
                        return;
                }
            }
        }
        static void ShowSchedule(IPupil pupil,ISchool school)
        {
            Console.Clear();
            Console.WriteLine("0.Return");
            foreach(ILesson lesson in school.Schedule.Where(l=>l.Class==pupil.Class).OrderBy(l=>l.Time))
            {
                
                Console.WriteLine(lesson);
            }
        }
        static int Select()
        {
            while (true)
            {
                if (uint.TryParse(Console.ReadKey(intercept: true).KeyChar.ToString(), out uint choose))
                {
                    return (int)choose;
                }
            }
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Select option:\n" +
                              "0.See schedule.\n" +
                              "1.Subscribe to notification.\n" +
                              "2.Start lesson.\n" +
                              "3.Exit.");
        }
    }
}
