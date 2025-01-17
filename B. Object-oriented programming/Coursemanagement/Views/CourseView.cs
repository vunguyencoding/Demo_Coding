using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coursemanagement.Models;

namespace Coursemanagement.Views
{
    internal class CourseView
    {
        /*public static Course GetCourseDetails()
        {
            Console.Write("Enter course name: ");
            string name = Console.ReadLine();

            Console.Write("Enter course credit: ");
            int credit = int.TryParse(Console.ReadLine(), out int result) ? result : 0;

            Console.Write("Enter course description: ");
            string description = Console.ReadLine();

            Console.Write("Enter semester: ");
            string semester = Console.ReadLine();

            return new Course { Name = name, Credit = credit, Description = description, Semester = semester };
        }*/

        public void DisplayCourses(List<Course> courses)
        {
            foreach (var course in courses)
            {
                Console.WriteLine($"Name: {course.Name}, Credit: {course.Credit}, Description: {course.Description}, Semester: {course.Semester}");
            }
        }
    }
}