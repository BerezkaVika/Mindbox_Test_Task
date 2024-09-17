using HHTaskLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryFigures
{
    public class Triangle : Figure
    {
        private double triangle_a;
        private double triangle_b;
        private double triangle_c;



        public double Triangle_a
        {
            get { return triangle_a; }
            set { triangle_a = value; }
        }

        public double Triangle_b
        {
            get { return triangle_b; }
            set { triangle_b = value; }
        }

        public double Triangle_c
        {
            get { return triangle_c; }
            set { triangle_c = value; }
        }

        public Triangle(string name, double a, double b, double c) : base(name)
        {
            if (a <= 0 || b <= 0 || c <= 0) throw new ArgumentException("Все 3 стороны треугольника должны быть больше 0!");
            if (a + b > c && a + c > b && b + c > a)
            {
                triangle_a = a;
                triangle_b = b;
                triangle_c = c;
            }
            else
            {
                throw new ArgumentException("Такого треугольника не существует! Одна сторона больше суммы двух других");
            }
        }

        public override double AreaOfFigure()
        {
            double p = (triangle_a + triangle_b + triangle_c) / 2;
            return Math.Round(Math.Sqrt(p*(p-triangle_a)*(p-triangle_b)*(p-triangle_c)), 2);
        }

        public bool IsRightTriangle()
        {
            return (triangle_a == Math.Sqrt(Math.Pow(triangle_b, 2) + Math.Pow(triangle_c, 2))
                   || triangle_b == Math.Sqrt(Math.Pow(triangle_a, 2) + Math.Pow(triangle_c, 2))
                   || triangle_c == Math.Sqrt(Math.Pow(triangle_a, 2) + Math.Pow(triangle_b, 2)));

        }
    }
}

