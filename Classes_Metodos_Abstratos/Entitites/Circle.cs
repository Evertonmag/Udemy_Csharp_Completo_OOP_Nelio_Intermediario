using Classes_Metodos_Abstratos.Entitites.Enums;

namespace Classes_Metodos_Abstratos.Entitites;
internal class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius, Color color)
        : base(color) => Radius = radius;

    public override double Area()
    {
        return Radius * Radius * Math.PI;
    }
}
