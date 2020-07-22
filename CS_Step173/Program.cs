using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step173
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("\nDo you still want to work here? (y/n)");
            string quit = Console.ReadLine();
            IQuittable iQuittable = new Employee();
            iQuittable.Quit(name, quit);
        }
    }
}
