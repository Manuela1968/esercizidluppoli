using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScambioValore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 30;

            int backup = x;
            x = y;
            y = backup;



            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadLine();



        }
    }
}
