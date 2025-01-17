using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coursemanagement.Controllers;
using Coursemanagement.Repository;
using Coursemanagement.Views;

namespace Coursemanagement.Framwork
{
    internal class Router
    {

        static CourseController _courseController = new();
        static MainController _mainController = new();
        public static void Forward(string[] args)
        {
            if (args.Length == 0)
            {
                _mainController.ShowMenu();
                return;
            }
            switch (args[0])
            {
                case "Add":
                    if (args.Length < 5)
                    {
                        Console.WriteLine("Invalid arguments. Usage: Add [Name] [Credit] [Description] [Semester]");
                        return;
                    }

                    if (!int.TryParse(args[2], out int credit) || credit <= 0)
                    {
                        Console.WriteLine("Invalid credit value. Please enter a positive integer.");
                        return;
                    }
                    _courseController.AddCourse(new()
                    {
                        Name = args[1],
                        Credit = int.Parse(args[2]),
                        Description = args[3],
                        Semester = args[4]
                    });

                    Console.WriteLine($"Course '{args[1]}' added successfully.");
                    break;
                case "Remove":
                    if (args.Length > 1)
                    {
                        string courseName = string.Join(" ", args.Skip(1));
                        _courseController.RemoveCourses(new List<string> { courseName });
                    }
                    else
                    {
                        Console.WriteLine("Please specify the course name to remove.");
                    }
                    break;

                case "Clear":
                    _courseController.ClearCourses();
                    break;
                case "List":
                    _courseController.DisplayCourses();
                    break;
                case "Help":
                    _mainController.ShowMenu();
                    break;
                case "clear":
                    _mainController.Clear();
                    break;
                case "Exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }
        }
        static Dictionary<string, string> GetParams(string query)
        {
            var keyValues = query.Split('&');
            var dictinonary = new Dictionary<string, string>();
            foreach (var pair in keyValues)
            {
                var items = pair.Split('=');
                dictinonary.Add(items[0].Trim(), items[1].Trim());
            }

            return dictinonary;
        }
    }

}