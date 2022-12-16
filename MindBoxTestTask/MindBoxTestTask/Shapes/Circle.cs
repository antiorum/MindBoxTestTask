using System;

namespace MindBoxTestTask
{
  public class Circle : Shape
  {
    public double Radius { get; }

    public Circle(double radius)
    {
      if (radius <= 0)
        throw new GeometricException();
      this.Radius = radius;
    }

    public override double GetSquare()
    {
      return this.Radius * this.Radius * Math.PI;
    }
  }
}
