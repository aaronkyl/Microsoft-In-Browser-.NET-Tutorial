using System;
using System.Collections.Generic;

namespace Lesson13
{
    public class Course
    {
        //Constructor
        public Course(string name)
        {
            this.Name = name;
        }

        //Properties
        public string Name { get; private set; }
        private List<Student> roster = new List<Student>();

        // Methods
        public void AddStudent(Student student) 
        {
            roster.Add(student);
            return;
        }

        public void PrintName()
        {
            Console.WriteLine(this.Name);
            return;
        }

        public void Rename(string newname)
        {
            this.Name = newname;
            return;
        }

        public void PrintRoster()
        {
            PrintName();
            Console.WriteLine("=======================");
            foreach (var enrollee in roster)
            {
                Console.WriteLine(enrollee.RosterName);
            }
            return;
        }

    }
}
