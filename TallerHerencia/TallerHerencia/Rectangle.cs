using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerHerencia;

public class Rectangle : Square
{

    private double _b;

    public double B
    {
        get => _b;
        private set => _b = ValidateB(value);
    }


    public Rectangle(string name, double a, double b) : base(name, a)
    {
        B = b;
    }

    public override double GetArea()
    {
        return A * B;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }


    private static double ValidateB(double b)
    {
        if (b <= 0)
        {
            throw new ArgumentException("The side of the rectangle must be greater than zero");
        }
        return b;
    }

}
