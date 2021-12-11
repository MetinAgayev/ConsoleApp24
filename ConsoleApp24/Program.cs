using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Metin", 2, "Muhendis", "UNEC", "metin@mail.ru", 55465145);
            Console.WriteLine(s.StudentMelumatlari());
        }
    }
}
