using Coursemanagement.Framwork;

namespace Coursemanagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Course Management System---------");
            while (true)
            {
                Console.Write(">>>> ");
                var command = Console.ReadLine();
                Router.Forward(command.Split(' '));
            }
        }
    }
    
}
