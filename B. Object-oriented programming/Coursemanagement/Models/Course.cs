using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursemanagement.Models
{
    internal class Course
    {

        // Name, Credit, Description, Semester. 
        public string Name { get; set; }
        public int Credit { get; set; }
        public string Description { get; set; }
        public string Semester { get; set; }

       /*public override string ToString()
        {
            return $"Name: {Name}, Credit: {Credit}, Description: {Description}, Semester: {Semester}";
        }*/
    }
}
