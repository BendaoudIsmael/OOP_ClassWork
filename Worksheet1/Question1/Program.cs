using System;
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
            Circle myObject = new Circle(); // creating instance of circel thus, myObject is a new and acutal 
            // cirlce which will have its own particualr values

            Circle myObject2 = new Circle();

            /*
             * To access fields and methods from an object we need to use the following format:
             * 
             * objectName.firldName
             * objectName.MethodName()
             */

            Console.WriteLine("Cirlce 1: ");
            myObject.radius = 360;
            myObject.getRadius();
            

            Console.WriteLine("Circle 2: ");
            myObject2.radius = 10;
            myObject2.getRadius();
           

            Console.ReadKey();
        }
    }
}
