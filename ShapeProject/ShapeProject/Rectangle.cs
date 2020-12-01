using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject
{
    class Rectangle : Shape
    {
        double lenght;
        double width;

        public Rectangle(double lenght, double width)
        {
            this.lenght = lenght;
            this.width = width;
        }

        public override void CalculateArea()
        {
            area = lenght * width;
        }
    }
}
