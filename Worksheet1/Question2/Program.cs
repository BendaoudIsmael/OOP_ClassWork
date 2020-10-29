using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rect1 = new Rectangle();
            Rectangle rect2 = new Rectangle();
            Rectangle rect3 = new Rectangle();

            /*
             *When a method returns a value the format is:
             *variable = method()
             *So method() will be converted to the returned value and the retunred value will be saved
             *in the variable
             */

            Console.Write("Please enter the length for rectangle 1: ");
            rect1.length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width for rectangle 1: ");
            rect1.width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Rectangle 1's  details");
            rect1.CalculateArea(); //method call: the compler will search for the method definiton and 
            // execute the code
            rect1.CalculatePerimeter();

            Console.Write("Please enter the length for rectangle 2: ");
            rect2.length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the width for rectangle 2: ");
            rect2.length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Rectangle 2 details: ");
            rect2.CalculateArea();
            rect2.CalculatePerimeter();

            Console.Write("Please enter the length for rectangle 3: ");
            rect3.length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enther the width for rectangle 3: ");
            rect3.width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Rectangle 3 details: ");
            rect3.CalculateArea();
            rect3.CalculatePerimeter();

            Console.ReadKey();

        }
    }
}
