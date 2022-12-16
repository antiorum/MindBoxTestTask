using System;

namespace MindBoxTestTask
{
  public class GeometricException : Exception
  {
    private const string ImpossibleShapeMessage = "Невозможно построить такую фигуру.";

    public GeometricException() : this(ImpossibleShapeMessage)
    {
    }

    private GeometricException(string message) : base(message)
    {
    }
  }
}
