using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coursemanagement.Models;

namespace Coursemanagement.Repository
{
    internal class CourseRepository
    {
        private List<Course> _courses = new List<Course>
        {

            new Course{ Name = "Data Structures and Algorithms",Credit = 4,Description = "Computer.",Semester = "Spring"},

            new Course{ Name = "Database Management Systems",Credit = 3,Description = "Computer.",Semester = "Fall"},

            new Course{ Name = "Web Development",Credit = 3,Description = "Computer.",Semester = "Spring"},

            new Course{ Name = "Software Engineering",Credit = 3,Description = "Computer",Semester = "Fall"},

            new Course{ Name = "Computer Networks",Credit = 3,Description = "Computer.",Semester = "Spring"},

            new Course { Name = "English", Credit = 3, Description = "English", Semester = "Spring" },

            new Course { Name = "Mathematics", Credit = 3, Description = "Mathematics", Semester = "Fall" },

            new Course { Name = "Physics", Credit = 3, Description = "Physics", Semester = "Spring" },
        };
        public void AddCourse(Course course)
        {
            _courses.Add(course);
        }
        public List<Course> GetCourses()
        {
            return _courses;
        }
        public void ClearCourses()
        {
            _courses.Clear();
        }
        public void RemoveCourses(List<string> courseNames)
        {
            _courses.RemoveAll(c => courseNames.Contains(c.Name));
        }
    }
}
