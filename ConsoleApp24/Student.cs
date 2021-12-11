using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
    class Student
    {
        public string FullName;
        public int Course;
        public string Subject;
        public string University;
        public string Email;
        public int PhoneNumber;
        public Student(string fullname, int course, string subject, string university, string email, int phoneNumber)
        {
            FullName = fullname;
            Course = course;
            Subject = subject;
            University = university;
            Email = email;
            PhoneNumber = phoneNumber;
        }


        public string StudentMelumatlari()
        {
            return $"{FullName} {Course} {Subject} {University} {Email} {PhoneNumber}";

        }
    }
}
