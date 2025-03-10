using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TallerHerencia;

public class Trapeze : Triangle
{
    private double _d;

    public double D
    {
        get => _d;
        private set => _d = ValidateD(value);
    }

    public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
    {
        D = d;
    }

    public override double GetArea()
    {
        return ((B + D) * H) / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C + D;
    }


   private static double ValidateD(double d)
    {
        if (d <= 0)
        {
            throw new ArgumentException("The side of the trapeze must be greater than zero");
        }
        return d;
    }
}