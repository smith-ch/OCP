using ProyectoCursos.Models;
using System;

namespace ProyectoCursos.Subscriptions
{
    public class HybridCourse : Course
    {
        public override void Subscribe(Student std)
        {
            // write code to subscribe to a hybrid course (combination of online and offline)
            Console.WriteLine($"Student {std.Name} Se a suscrito al curso online de: {Title}, que incluye sesiones tanto online como offline.");
        }
    }
}
