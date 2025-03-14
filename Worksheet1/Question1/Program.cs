﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Question 1
                Circle circle1 = new Circle(); // creating an instance of Circle thus, circle1 is a new and actual
                // circle which will have its own particular values

                Circle circle2 = new Circle();
             */
            /*
             * To access fields and methods from an object we need to use the following format:
             * 
             * objectName.fieldName
             * objectName.MethodName()
             */
            /*
                Console.WriteLine("Circle 1:");
                circle1.radius = 2.5;
                // option 1 handling a return
                string c1RadiusDisp = circle1.GetRadius();
                Console.WriteLine(c1RadiusDisp);

                Console.WriteLine("Circle 2:");
                circle2.radius = 4.8;
                // option 2 handling a return
                Console.WriteLine(circle2.GetRadius());
            */

            // Question 2
            Circle c1 = new Circle(2.4);
            Circle c2 = new Circle(5.6);
            Circle c3 = new Circle(1.6);
            Circle c4 = new Circle();

           // Console.WriteLine(c1.GetRadius());
            Console.WriteLine("The area for circle 1 is " + c1.GetArea());
            Console.WriteLine("The circumference for circle 1 is " + c1.GetCircumference());

           // Console.WriteLine(c2.GetRadius());
            Console.WriteLine("The area for circle 2 is " + c2.GetArea());
            Console.WriteLine("The circumference for circle 2 is " + c2.GetCircumference());

           // Console.WriteLine(c3.GetRadius());
            Console.WriteLine("The area for circle 3 is " + c3.GetArea());
            Console.WriteLine("The circumference for circle 3 is " + c3.GetCircumference());

            Console.ReadKey(); //method call
        }
    }
}
