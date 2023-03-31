using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Boolean.CSharp.Main
{
    public abstract class Shape
    {
        public abstract double area();
    }


    public class Circle : Shape
    {
        public Circle()
        {
                
        }
        private double radius;
        public Circle(double r)
        {
            radius = r;
        }
        public override double area()
        {
            return (3.14 * radius * radius);
        }
    }
    public class Square : Shape
    {
        private double side;
        public Square(double s)
        {
            side = s;
        }
        public override double area()
        {
            return (side * side);
        }
    }
    public class Triangle : Shape
    {
        private double tbase;
        private double theight;
        public Triangle(double b, double h)
        {
            tbase = b;
            theight = h;
        }
        public override double area()
        {
            return (0.5 * tbase * theight);
        }
    }
    public class Core
    {

    }
}
