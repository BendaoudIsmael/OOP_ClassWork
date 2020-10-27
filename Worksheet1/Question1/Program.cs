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

            /*
             * To access fields and methods from an object we need to use the following format:
             * 
             * 
             */

            myObject.getRadius();

            Console.ReadKey();
        }
    }
}
