using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice03
{
    class PointProgram
    {
        public struct Point1
        {
            double _x, _y;
            public Point1(double x, double y)
            {
                _x = x;
                _y = y;
            }
            public double Distance(Point1 Z)
            {
                return Math.Sqrt(Math.Pow(_x - Z._x, 2) + Math.Pow(_y - Z._y,
                2));
            }
        }

        public static void Do1()
        {
            Point1 C;
            Point1 A = new Point1(0, 0);
            Point1 B = new Point1(2, 2);
            Console.WriteLine(A.Distance(B));
        }

        //====================================================

        public class Point2
        {
            double _x, _y;
            public Point2()
            {
                _x = _y = 0;
            }
            public Point2(double x, double y)
            {
                _x = x;
                _y = y;
            }
            public void SetX(double value)
            {
                _x = value;
            }
            public double GetX()
            {
                return _x;
            }
            public double X
            {
                get { return _x; }
                set
                {
                    if (value > 0) _x = value;
                    else _x = -value;
                }
            }
            public double Distance(Point2 Z)
            {
                return Math.Sqrt(Math.Pow(_x - Z._x, 2) + Math.Pow(_y - Z._y, 2));
            }
            public override string ToString()
            {
                return _x + "," + _y;
            }
        }

        public static void Do2()
        {
            Point2 C = new Point2();
            C.SetX(10);
            Console.WriteLine(C.GetX());
            Console.WriteLine(C.X);
            C.X = 10;
            Console.WriteLine(C);
            Point2 A = new Point2();
            Point2 B = new Point2(2, 2);
            Console.WriteLine(A.Distance(B));
            Console.ReadKey();
        }



    }
}
