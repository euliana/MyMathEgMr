using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyMath;

namespace yMathTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SquerTest1()
        {
            double a = 1;
            double b = 2;
            double c = 0;
            string roots = $"{0} {-2}";
            string result = MyMath.Algebra.Squer(a, b, c);
            Assert.AreEqual(roots, result);
        }

        [TestMethod]
        public void SquerTest2()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            string roots = "нет корней";
            string result = MyMath.Algebra.Squer(a, b, c);
            Assert.AreEqual(roots, result);
        }

        [TestMethod]
        public void SquerTest3()
        {
            double a = 200;
            double b = 6092;
            double c = 6543;
            string roots = $"{-1.11483439700405} {- 29.3451656029959}";
            string result = MyMath.Algebra.Squer(a, b, c);
            Assert.AreEqual(roots, result);
        }

        [TestMethod]
        public void SquerTest4()
        {
            double a = -1;
            double b = -2;
            double c = 0;
            string roots = $"{-2} {0}";
            string result = MyMath.Algebra.Squer(a, b, c);
            Assert.AreEqual(roots, result);

        }
        //[TestMethod]
        //public void SquerTest5()
        //{
        //    double a = 4;
        //    double b = 4;
        //    double c = 4;
        //    string roots = "x1 = 0; x2 = -2";
        //    string result = MyMath.Algebra.Squer(a, b, c);
        //    Assert.AreEqual(roots, result);

        //}

        [TestMethod]
        public void LinUrTest1()
        {
            double a = 4;
            double b = -4;
            
           double roots = 1;
           double result = MyMath.Algebra.LinUr(a, b);
            Assert.AreEqual(roots, result);

        }



        [TestMethod]
        public void LinUrTest2()
        {
            double a = 1;
            double b = 0;

            double roots = 0;
            double result = MyMath.Algebra.LinUr(a, b);
            Assert.AreEqual(roots, result);
        }
        [TestMethod]
        public void LinUrTest3()
        {
            double a = 4;
            double b = -2;

            double roots =0.5;
            double result = MyMath.Algebra.LinUr(a, b);
            Assert.AreEqual(roots, result);
        }
        [TestMethod]
        public void LinUrTest4()
        {
            double a = -12;
            double b = 6;

            double roots = 0.5;
            double result = MyMath.Algebra.LinUr(a, b);
            Assert.AreEqual(roots, result);
        }
        [TestMethod]
        public void LinUrTest5()
        {
            double a = -12;
            double b = -6;

            double roots = -0.5;
            double result = MyMath.Algebra.LinUr(a, b);
            Assert.AreEqual(roots, result);
        }
        [TestMethod]
        public void SumTest1()
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 11 };

            double roots = 56;
            double result = MyMath.Algebra.Sum(ints);
            Assert.AreEqual(roots, result);
        }
        [TestMethod]
        public void SumTest2()
        {
            int[] ints = { 0, 0, 0, 0, 0, 0, 0, 0, 0,0,0 ,0, 0 };

            double roots = 0;
            double result = MyMath.Algebra.Sum(ints);
            Assert.AreEqual(roots, result);
        }

        [TestMethod]
        public void SumTest3()
        {
            int[] ints = { -1, -2, -3, -4, -5, -6, -7, -8, -10 };

            double roots = -46;
            double result = MyMath.Algebra.Sum(ints);
            Assert.AreEqual(roots, result);
        }
        [TestMethod]
        public void SumTest4()
        {
            int[] ints = { 9};

            double roots = 9;
            double result = MyMath.Algebra.Sum(ints);
            Assert.AreEqual(roots, result);
        }
        [TestMethod]
        public void SumTest5()
        {
            int[] ints = { -10 };

            double roots = -10;
            double result = MyMath.Algebra.Sum(ints);
            Assert.AreEqual(roots, result);
        }
        [TestMethod]
        public void MaxRow1()
        {
            int[] ints = { 9 };

            int roots = 9;
            int result = MyMath.Algebra.MaxRow(ints);
            Assert.AreEqual(roots, result);
        }
        [TestMethod]
        public void MaxRow2()
        {
            int[] ints = { 9,8,7 };

            int roots = 9;
            int result = MyMath.Algebra.MaxRow(ints);
            Assert.AreEqual(roots, result);
        }
        [TestMethod]
        public void MaxRow3()
        {
            int[] ints = { 7, 12, 9 };

            int roots = 12;
            int result = MyMath.Algebra.MaxRow(ints);
            Assert.AreEqual(roots, result);
        }
        [TestMethod]
        public void MaxRow4()
        {
            int[] ints = { 1, 5, 3, 4, 5 };

            double roots = 5;
            double result = MyMath.Algebra.MaxRow(ints);
            Assert.AreEqual(roots, result);
        }
        [TestMethod]
        public void MaxRow5()
        {
            int[] ints = { -1, -2, -3 };

            double roots = -1;
            double result = MyMath.Algebra.MaxRow(ints);
            Assert.AreEqual(roots, result);
        }

        //MiddleRow
        [TestMethod]
        public void MiddleRow1()
        {
            int[] ints = { -1, -2, -3 };

            double roots = -2;
            double result = MyMath.Algebra.MiddleRow(ints);
            Assert.AreEqual(roots, result);
        }

        [TestMethod]
        public void STreangl1()
        {
            double a = 3;
            double b = 4;
            double c = 5;

            double roots = 6;
            double result = MyMath.Geometry.STreangl(a,b,c);
            Assert.AreEqual(roots, result);
        }

        [TestMethod]
        public void STreangl2()
        {
            double a = -4;
            double b = 4;
            double c = 4;

            double roots = 0;
            double result = MyMath.Geometry.STreangl(a, b, c);
            Assert.AreEqual(roots, result);
        }

        [TestMethod]
        public void STreangl3()
        {
            double a = 0;
            double b = 0;
            double c = 0;

            double roots = 0;
            double result = MyMath.Geometry.STreangl(a, b, c);
            Assert.AreEqual(roots, result);
        }

        [TestMethod]
        public void STreangl4()
        {
            double a = 8;
            double b = -1;
            double c = 0;

            double roots = 0;
            double result = MyMath.Geometry.STreangl(a, b, c);
            Assert.AreEqual(roots, result);
        }

        [TestMethod]
        public void STreangl5()
        {
            double a = 1;
            double b = 2;
            double c = 3;

            double roots = 0;
            double result = MyMath.Geometry.STreangl(a, b, c);
            Assert.AreEqual(roots, result);
        }

        //[TestMethod]
        //public void SRightTreangl1()
        //{
        //    double a = 1;
        //    double b = 1;

        //    double roots = 1;
        //    double result = MyMath.Geometry.STreangl(a, b, c);
        //    Assert.AreEqual(roots, result);
        //}
        //[TestMethod]
        //public void SRightTreangl2()
        //{
        //    double a = 1;
        //    double b = 1;

        //    double roots = 1;
        //    double result = MyMath.Geometry.STreangl(a, b, c);
        //    Assert.AreEqual(roots, result);
        //}
    }
}
