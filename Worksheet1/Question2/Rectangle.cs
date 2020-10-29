using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Rectangle
    {
        public double length;
        public double width;
        
       public void CalculateArea() /* This is a method definition and a method definiton explains
        how the method will execute once it is called. If it is called the code will never be executed*/
        {
            double area = length * width; // * is multiplication

            Console.WriteLine("The area for this rectangle is " + area);
        }

        public void CalculatePerimeter()
        {
            double perimeter = (length * 2) + (width * 2);

            Console.WriteLine("The perimeter for this rectangle is " + perimeter);
        }
    }
}
