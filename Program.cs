using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _312554CmdLineTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is a command line program. Isn't it cool? (y/n)");
            String answer = Console.ReadLine().Trim().ToLower();

            if (answer == "y")
                Console.WriteLine("Correct!");
            else if (answer == "n")
                Console.WriteLine("aw..");
            else
                Console.WriteLine("Ok then?");

            //Wait for any input before ending program:
            Console.ReadLine();
        }
    }
}
