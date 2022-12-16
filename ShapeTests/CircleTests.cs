using FluentAssertions;
using MindBoxTestTask;
using NUnit.Framework;
using System;

namespace ShapeTests
{
  [TestFixture]
  public class CircleTests
  {
    private const string GeometricExceptionMessage = "Невозможно построить такую фигуру.";

    [Test]
    public void RadiusIsNegativeShouldThrowsError()
    {
      Exception error = null;
      try
      {
        var circle = new Circle(-2);
      }
      catch (Exception e)
      {
        error = e;
      }
      error.Should().NotBeNull();
      error.Message.Should().Be(GeometricExceptionMessage);
    }

    [Test]
    public void RadiusIsZeroShouldThrowsError()
    {
      Exception error = null;
      try
      {
        var circle = new Circle(0);
      }
      catch (Exception e)
      {
        error = e;
      }
      error.Should().NotBeNull();
      error.Message.Should().Be(GeometricExceptionMessage);
    }

    [Test]
    public void CircleSquareShouldBeEqualToEtalon()
    {
      var circle = new Circle(42);
      var square = circle.GetSquare();
      square.Should().BeApproximately(5542, 0.3);
    }
  }
}
