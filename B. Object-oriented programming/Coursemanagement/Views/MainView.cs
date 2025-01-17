using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursemanagement.Views
{
    internal class MainView
    {
        public void DisplayView()
        {
            Console.WriteLine("\n-------------------Course Management System------------------");
            Console.WriteLine("Add     -  Create a new course");
            Console.WriteLine("List    -  Display all courses ");
            Console.WriteLine("Remove  -  Remove a course");
            Console.WriteLine("clear   -  Clear the console");
            Console.WriteLine("Help    -  Display menu");
            Console.WriteLine("Exit    -  Exit the program");
            Console.WriteLine("-------------------------------------------------------------");

        }
        public void Clearview()
        {
            Console.Clear();
        }
    }

}

