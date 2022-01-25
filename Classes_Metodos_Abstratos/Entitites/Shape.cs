using Classes_Metodos_Abstratos.Entitites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Metodos_Abstratos.Entitites;
internal abstract class Shape
{
    public Color Color { get; set; }

    public Shape(Color color)
    {
        Color = color;
    }

    public abstract double Area();
}
