using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication40
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter the salery");
            a = Convert.ToInt32(Console.ReadLine());
            if (a <= 50000)
            {
                Console.WriteLine("maliat shoma" + a / 10 + "tooman ast");
            }
            else if ((50000 <= a) && (a <= 100000)) {
                Console.WriteLine("maliat shoma" + a / 5 + " tooman ast");
            }
            else if ((100000 <= a) && (a <= 200000))
            {
                Console.WriteLine("maliat shoma" + (a / 3.5) + "ast");
            }
            else if ((200000 <= a) && (a <= 500000))
            {
                Console.WriteLine("maliat shoma" + a / 3 + "ast");
            }
            else if (500000 <= a) { Console.WriteLine("maliat shoma" +( a / 2.5) + "ast"); }
            else { Console.WriteLine("invalid format"); }
            Console.ReadKey();
        }
    }
}
