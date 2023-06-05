using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMath;
namespace MyMathEgMr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Algebra.Squer(200,6092,6543));


            //Console.WriteLine(Algebra.LinUr(7, 8));
            int[] ints = { -1, -2, -3 };

            ////Console.WriteLine(Algebra.Sum(ints));

            ////Console.WriteLine(Algebra.MaxRow(ints));

            Console.WriteLine(Algebra.MiddleRow(ints));

            //Console.WriteLine(Geometry.STreangl(1,2,3));

            //Console.WriteLine(Geometry.SRectngl(1,1));

            //Console.WriteLine(Geometry.SCircle(3));

            //Console.WriteLine(Geometry.STrapezoid(3,4,5));

            Console.ReadKey();
        }

    }
}
