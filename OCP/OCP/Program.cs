using System;
using ProyectoCursos.Models;
using ProyectoCursos.Subscriptions;

namespace ProyectoCursos
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Smith Rodriguez", 1);

            Course onlineCourse = new OnlineCourse { CourseId = 101, Title = "C# Programming" };
            Course offlineCourse = new OfflineCourse { CourseId = 102, Title = "Java Programming" };
            Course hybridCourse = new HybridCourse { CourseId = 103, Title = "Full Stack Development" };

            onlineCourse.Subscribe(student);
            offlineCourse.Subscribe(student);
            hybridCourse.Subscribe(student);
        }
    }
}
