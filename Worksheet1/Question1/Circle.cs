using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Circle
    {
        double radius; //radius is a field for the Circle type

        /*
         * GetRadius() is a method called for cirlce objects to display the circle's radius on the console
         * it has no retrun type (void means no return type) and no parameters (no vlaues between brackets)
         */

        public void getRadius() // method definition --> {} (Creating our method)
        {
            Console.WriteLine("The radius for this circle is " + radius);
        }
    }
}
