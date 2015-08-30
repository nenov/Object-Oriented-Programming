using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
    public class Display
    {
        //size and number of colors
        private double? size;
        private long? numberOfColors;

        public double? Size
        {
            get
            {
                return size;
            }
            set
            {
                try
                {
                    size = value;
                }
                catch (Exception me)
                {
                    Console.WriteLine(me.Message);
                }
            }
        }
        public long? NumberOfColors
        {
            get
            {
                return numberOfColors;
            }
            set
            {
                try
                {
                    numberOfColors = value;
                }
                catch (Exception me)
                {
                    Console.WriteLine(me.Message);
                }
            }
        }
        public Display()
        {
            this.size = null;
            this.numberOfColors = null;
        }
        public Display(double? size, long? number)
        {
            this.size = size;
            this.numberOfColors = number;
        }
    }
}
