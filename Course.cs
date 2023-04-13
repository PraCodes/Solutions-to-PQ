using System;

namespace COURSE
{
    class Course 
    {   public string CourseName { get; set; }
        
        public Course(string name)
        {
            CourseName = name;
        }

        public void CourseTitle()
        {
            Console.WriteLine("Welcome to {0}", CourseName);
        }
    }
}
