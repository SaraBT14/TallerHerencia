using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerHerencia;

public class Square : GeometricFigure
{

    private double _a;

    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }


    public Square(string name, double a) : base(name)
    {
        A = a;
    }

    public override double GetArea()
    {
        return A * A;
    }

    public override double GetPerimeter()
    {
        return 4 * A;
    }
    private static double ValidateA(double a)
    {
        if (a <= 0)
        {
            throw new ArgumentException("The side of the square must be greater than zero");
        }
        return a;
    }


}
