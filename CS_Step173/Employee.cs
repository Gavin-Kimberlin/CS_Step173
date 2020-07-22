using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step173
{
    public class Employee : IQuittable
    {
        public string X { get; set; }
        public string Y { get; set; }

        public void Quit(string Name, string IsQuitting)
        {
            if (IsQuitting == "y")
            {
                Console.WriteLine("\n" + Name + " is quitting.");
                Console.ReadLine();
            }
            else if (IsQuitting == "n")
            {
                Console.WriteLine("\n" + Name + " is not quitting.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n" + "Please close the program " + Name + " and try again. Next time enter either y or n.");
                Console.ReadLine();
            }
        }
    }
}
