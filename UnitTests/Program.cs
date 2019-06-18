using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.Write("Enter X: ");
            Int32.TryParse(Console.ReadLine(), out int x);

            Console.Write("Enter Y: ");
            Int32.TryParse(Console.ReadLine(), out int y);

            Console.Write("The sum = ");
            Console.WriteLine(math.Add(x, y));

            Console.Write("The subtraction = ");
            Console.WriteLine(math.Sub(x, y));

            Console.Write("The multiplication  = ");
            Console.WriteLine(math.Mult(x, y));

            Console.Write("The division  = ");
            Console.WriteLine(math.Div(x, y));

            Console.ReadKey();
        }
    }
}
