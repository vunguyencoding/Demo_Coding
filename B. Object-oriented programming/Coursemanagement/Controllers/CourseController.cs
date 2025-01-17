using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Coursemanagement.Models;
using Coursemanagement.Repository;
using Coursemanagement.Views;

namespace Coursemanagement.Controllers
{
    internal class CourseController
    {

        CourseRepository _courseRepository = new CourseRepository();
        CourseView _courseView = new CourseView();

        public void AddCourse(Course course)
        {
            _courseRepository.AddCourse(course);
            Console.WriteLine($"Course '{course.Name}' added to the system.");
        }
        public void RemoveCourses(List<string> courseNames)
        {
            foreach (var courseName in courseNames)
            {
                var courseToRemove = _courseRepository.GetCourses().FirstOrDefault(c => c.Name.Equals(courseName, StringComparison.OrdinalIgnoreCase));

                if (courseToRemove != null)
                {
                    _courseRepository.RemoveCourses(new List<string> { courseName });
                    Console.WriteLine($"Course '{courseName}' removed successfully.");
                }
                else
                {
                    Console.WriteLine($"Course '{courseName}' not found.");
                }
            }
        }
        public void ClearCourses()
        {
            _courseRepository.ClearCourses();
        }
        public void DisplayCourses()
        {
            var courses = _courseRepository.GetCourses();
            _courseView.DisplayCourses(courses);
        }
    }
}
