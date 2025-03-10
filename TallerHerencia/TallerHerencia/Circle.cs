using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerHerencia;

public class Circle : GeometricFigure
{

    private double _r;

    public double R
    {
        get => _r;
        set => _r = ValidateR(value);
    }

    public Circle(string name, double r) : base(name)
    {
        R = r;
    }

    public override double GetArea()
    {
        return Math.PI * R * R;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * R;
    }

    private static double ValidateR(double r)
    {
        if (r <= 0)
        {
            throw new ArgumentException("The radius of the circle must be greater than zero");
        }
        return r;
    }


}
