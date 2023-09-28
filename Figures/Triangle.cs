using Shapes.Exceptions;

namespace Shapes;

/// <summary>
/// Represents a triangle and provides properties specific for triangles.
/// </summary>
public class Triangle : IShape
{
    private readonly decimal[] _sides;

    /// <summary>
    /// Creates a new instance of <see cref="Triangle"/> from 3 sides where order of them does not matter.
    /// </summary>
    /// <param name="sideA">First side.</param>
    /// <param name="sideB">Second side.</param>
    /// <param name="sideC">Third side.</param>
    /// <remarks>Note: all sides must be in the same units.</remarks>
    /// <exception cref="TriangleSidesException"></exception>
    public Triangle(decimal sideA, decimal sideB, decimal sideC)
    {
        _sides = new[]
        {
            sideA,
            sideB,
            sideC
        };

        Array.Sort(_sides);
        TriangleSidesException.ThrowIfImpossible(_sides[2], _sides[0], _sides[1]);
    }

    private decimal SemiPerimeter => _sides.Sum() / 2m;

    private decimal HeronsArea => DecimalMath.Sqrt(SemiPerimeter * (SemiPerimeter - _sides[0]) * (SemiPerimeter - _sides[1]) * (SemiPerimeter - _sides[2]));

    public decimal Area => IsRight ? _sides[0] * _sides[1] / 2m : HeronsArea;

    /// <summary>
    /// Checks if the triangle has a 90-degree angle.
    /// </summary>
    public bool IsRight => _sides[2] * _sides[2] == _sides[0] * _sides[0] + _sides[1] * _sides[1];
}