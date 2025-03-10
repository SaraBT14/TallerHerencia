using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerHerencia;

public class Triangle : Rectangle
{
    private double _c;
    private double _h;

    public double C
    {
        get => _c;
        private set => _c = ValidateC(value);
    }

    public double H
    {
        get => _h;
        private set => _h = ValidateH(value);
    }


    public override double GetArea()
    {
        return (B * H) / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C;
    }


    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        C = c;
        H = h;
    }

    private static double ValidateC(double c)
    {
        if (c <= 0)
        {
            throw new ArgumentException("The side of the triangle must be greater than zero");
        }
        return c;
    }


    private static double ValidateH(double h)
    {
        if (h <= 0)
        {
            throw new ArgumentException("The height of the triangle must be greater than zero");
        }
        return h;
    }



}
