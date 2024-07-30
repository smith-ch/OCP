using ProyectoCursos.Models;
using System;

namespace ProyectoCursos.Subscriptions
{
    public class OnlineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            // write code to subscribe to an online course
            Console.WriteLine($"Student {std.Name} Se a suscrito al curso online de: {Title}");
        }
    }
}
