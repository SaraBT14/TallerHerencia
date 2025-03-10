using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerHerencia;
public class Parallelogram : Rectangle
{
    private double _h;

    public double H
    {
        get => _h;
        private set => _h = ValidateH(value);
    }

    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        H = h;
    }

    public override double GetArea()
    {
        return B * H;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    private static double ValidateH(double h)
    {
        if (h <= 0)
        {
            throw new ArgumentException("The height of the parallelogram must be greater than zero");
        }
        return h;
    }
}