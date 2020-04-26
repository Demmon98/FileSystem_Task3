using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input path to directory (. - current directory)");

            int res;

            do
            {
                string path = Console.ReadLine();
                res = new Finder().Find(path);
            }
            while (res != 0);

            Console.ReadKey();
        }
    }
}
