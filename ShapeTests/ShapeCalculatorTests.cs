using FluentAssertions;
using MindBoxTestTask;
using NUnit.Framework;

namespace ShapeTests
{
  [TestFixture]
  internal class ShapeSquareCalculatorTests
  {
    [Test]
    public void CalculatorShouldReturnTriangleSquare()
    {
      var triangle = new Triangle(3, 4, 5);
      var triangleSquare = triangle.GetSquare();
      triangleSquare.Should().Be(ShapeSquareCalculator.GetSquare(triangle));
    }

    [Test]
    public void CalculatorShouldReturnCircleSquare()
    {
      var circle = new Circle(42);
      var circleSquare = circle.GetSquare();
      circleSquare.Should().Be(ShapeSquareCalculator.GetSquare(circle));
    }
  }
}
