using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerHerencia;
public abstract class GeometricFigure
{
    public string Name { get; } = null!;

    protected GeometricFigure(string name)
    {
        Name = name;
    }


    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{Name,-15} => Area......: {GetArea(),15:N5}    Perimeter: {GetPerimeter(),15:N5}";
    }
}
