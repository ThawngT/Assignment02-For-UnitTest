using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_11_Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();

            Console.WriteLine($"Length: {rect.GetLength()}");
            Console.WriteLine($"Width: {rect.GetWidth()}");
            Console.WriteLine($"A Perimeter: {rect.GetPerimeter()}");
            Console.WriteLine($"An Area: {rect.GetArea()}");

            rect.SetLength( 30 );
            rect.SetWidth( 20 );

            Console.WriteLine("************** Update Rectangle***********");

            Console.WriteLine($"Update Length: {rect.GetLength()}");
            Console.WriteLine($"Update Width: {rect.GetWidth()}");
            Console.WriteLine($"Update A Perimeter: {rect.GetPerimeter()}");
            Console.WriteLine($"Update An Area: {rect.GetArea()}");
        }
    }
}
