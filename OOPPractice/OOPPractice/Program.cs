using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Program
    {
        static void Main(string[] args)
        {


            Rectangle rect = new Rectangle(4, 6);
            Console.WriteLine("Height: {0}", rect.Height);
            Console.WriteLine("Width: {0}", rect.Width);

            Rectangle square = new Rectangle(5);
            Console.WriteLine("Height: {0}", square.Height);
            Console.WriteLine("Width: {0}", square.Width);

        }
    }
}
