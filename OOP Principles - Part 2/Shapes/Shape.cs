using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public abstract class Shape
    {
        private double width;

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        private double height;

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public abstract double CalculateSurface();

        public Shape(double width, double heith)
        {
            this.Height = heith;
            this.Width = width;
        }
        
    }
}
