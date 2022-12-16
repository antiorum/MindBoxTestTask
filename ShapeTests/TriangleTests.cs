using MindBoxTestTask;
using NUnit.Framework;
using FluentAssertions;
using System;

namespace ShapeTests
{
  [TestFixture]
  public class TriangleTests
  {
    private const string GeometricExceptionMessage = "Невозможно построить такую фигуру.";

    [Test]
    public void OneEdgeIsNegativeShouldThrowsError()
    {
      Exception error = null;
      try
      {
        var triangle = new Triangle(1, 1, -2);
      }
      catch (Exception e)
      {
        error = e;
      }
      error.Should().NotBeNull();
      error.Message.Should().Be(GeometricExceptionMessage);
    }

    [Test]
    public void OneEdgeIsZeroShouldThrowsError()
    {
      Exception error = null;
      try
      {
        var triangle = new Triangle(1, 1, 0);
      }
      catch (Exception e)
      {
        error = e;
      }
      error.Should().NotBeNull();
      error.Message.Should().Be(GeometricExceptionMessage);
    }

    [Test]
    public void ImpossibleEdgesLengthsShouldThrowsError()
    {
      Exception error = null;
      try
      {
        var triangle = new Triangle(1, 1, 6);
      }
      catch (Exception e)
      {
        error = e;
      }
      error.Should().NotBeNull();
      error.Message.Should().Be(GeometricExceptionMessage);
    }

    [Test ]
    public void NotRectangularTriangleShouldReturnsFalse()
    {
      var triangle = new Triangle(2, 2, 3);
      var result = triangle.IsRectangular();
      result.Should().BeFalse();
    }

    [Test]
    public void RectangularTriangleShouldReturnsTrue()
    {
      var triangle = new Triangle(3, 4, 5);
      var result = triangle.IsRectangular();
      result.Should().BeTrue();
    }

    [Test]
    public void NotRectangularTriangleSquareShouldBeEqualToEtalon()
    {
      var triangle = new Triangle(2, 2, 3);
      var square = triangle.GetSquare();
      square.Should().BeApproximately(2, 0.03);
    }

    [Test]
    public void RectangularTriangleSquareShouldBeEqualToEtalon()
    {
      var triangle = new Triangle(3, 4, 5);
      var square = triangle.GetSquare();
      square.Should().Be(6);
    }
  }
}