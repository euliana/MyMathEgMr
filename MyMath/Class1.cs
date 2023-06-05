using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public static class Algebra
    {
        public static string Squer(double a, double b, double c)
        {
            string final;
            double x1=0;
            double x2=0;
            double d = (b * b) - (4 * a * c);
            if (d < 0)
            {
                final = "нет корней";
            }
           
            else
            {
                x1 = ((-1 * b) + Math.Sqrt(d)) / (2 * a);
                x2 = ((-1*b) - Math.Sqrt(d)) / (2 * a);
                //final = Convert.ToString("x1 = " + x1 + ";");
                //final += " " + Convert.ToString("x2 = " + x2);
                final = $"{x1} {x2}";
            }
             

            return final;

        }

        public static double LinUr(double a, double b)
        {
            Double x = -(b / a);
            return x;
        }

        public static int Sum(int [] ints)
        {
            
            int a = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                a += ints[i];
            }
            return a;
            
        }
        public static int MaxRow(int[] ints)
        {
            int a = ints[0];

            for (int i = 0; i < ints.Length -1; i++)
            {

                if (ints[i] > ints[ i + 1] && ints[i] > a)
                {
                    a = ints[i];

                }
               
            }
            
                return a;

        }

       
        public static int MiddleRow(int[] ints)
        {
            int a = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                a += ints[i];
            }
            a /= ints.Length;
            return a;

        }

    }
    public static class Geometry
    {
        public static double STreangl(double a, double b , double c)
        {
            if (a>0 && b>0 && c>0)
            {
                double p = (a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s;
            }
            else
            {
                return 0;
            }
           

        }

        public static double SRightTreangl(double a, double b)
        {
            if (a > 0 && b > 0 )
            {
                double s = (a * b) / 2;
                return s;
            }
            else
            {
                return 0;
            }
                 

        }


        public static double SRectngl(double a, double b)
        {

            double s = (a * b);
            return s;

        }
        public static double SCircle(double r)
        {
            
            double s = (3.14 * (r * r));
            return s;

        }
        public static double STrapezoid(double a, double b, double c)
        {
         
            double s = 0.5 * (a + b) * Math.Sqrt((c * c) - ((a - b) / 2) * ((a - b) / 2));         
            return s;

        }
    }
}
