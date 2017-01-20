using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Rectangle
    {
        public int Height { get; }
        public int Width { get; }

        public Rectangle(int height, int width)
        {
            if (height <= 0) throw new ArgumentException("height");
            if (width <= 0) throw new ArgumentException("width");

            Height = height;
            Width = width;

            Console.WriteLine("Rectangle Constructor Called");
        }

        //public Rectangle(int size)
        //{
        //    if (size <= 0) throw new ArgumentException("height");

        //    Height = Width = size;

        //    Console.WriteLine("Square Constructor Called");
        //}


        public Rectangle(int size) : this(size, size)
        {
            Console.WriteLine("Square Constructor Called");
        }
    }
}
