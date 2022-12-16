using System;
using System.Collections.Generic;
using System.Linq;

namespace MindBoxTestTask
{
  public class Triangle : Shape
  {
    private readonly IList<double> edges;
    
    public Triangle(double edge1, double edge2, double edge3)
    {
      if (edge1 <= 0 || edge2 <= 0 || edge3 <= 0)
        throw new GeometricException();
      var edges = new List<double>() { edge1, edge2, edge3 };
      edges.Sort();
      if (edges[0] + edges[1] <= edges[2])
        throw new GeometricException();

      this.edges = edges;
    }

    public override double GetSquare()
    {
      var semiPerimeter = edges.Sum() / 2;
      return Math.Sqrt(semiPerimeter * (semiPerimeter - edges[0]) * (semiPerimeter - edges[1]) * (semiPerimeter - edges[2]));
    }

    public bool IsRectangular()
    {
      return edges[0] * edges[0] + edges[1] * edges[1] == edges[2] * edges[2];
    }
  }
}
