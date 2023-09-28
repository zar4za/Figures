using Shapes.Exceptions;

namespace Shapes;

public class Triangle : IShape
{
    private readonly decimal[] _sides;

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

    public bool IsRight => _sides[2] * _sides[2] == _sides[0] * _sides[0] + _sides[1] * _sides[1];
}