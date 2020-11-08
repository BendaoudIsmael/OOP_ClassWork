using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Circle
    {
        public double radius; //radius is a field for the Circle type
        Random rand = new Random();

        /*
         * GetRadius() is a method called for cirlce objects to display the circle's radius on the console
         * it has no retrun type (void means no return type) and no parameters (no vlaues between brackets)
         */

        public Circle() : this(1)
        {
            //this.radius = 1;
        }

        public Circle (double radius)
        {
            this.radius = radius;

            /*
             * the This keywoard refereces to this current circle object 
             * we are making the radius attribute for this current circle equal to the radius value which is passed as a 
             * parameter/argument
             */
        }

        public string GetRadius() // method definition --> {} (Creating our method)
        {

            radius = rand.Next(1, 31);
            string returnedText = "The radius for this circle is " + radius;

            return returnedText;

            /*
             * Simple can be done like this:
             *  return "The radius for this circle is " + radius;
             */
        }

        public double GetArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return Math.Round(area, 2);
        }

        public double GetCircumference()
        {
            double circumference = 2 * Math.PI * radius;
            return Math.Round(circumference, 2);
        }
    }
}
