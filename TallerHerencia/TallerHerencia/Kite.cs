using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerHerencia;

public class Kite : Rhombus
{
    private double _b;
    private double r;

    public double B
    {
        get => _b;
        private set => _b = ValidateB(value);
    }

    public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
    {
        B = b;
    }

    public override double GetArea()
    {
        return (D1 * D2) / 2;
    }


    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    private static double ValidateB(double b)
    {
        if (b <= 0)
        {
            throw new ArgumentException("The side of the kite must be greater than zero");
        }
        return b;
    }


}
