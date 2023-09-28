using Shapes.Exceptions;

namespace Shapes;

/// <summary>
/// Represents a Circle.
/// </summary>
public class Circle : IShape
{
    // sqrt from max decimal area divided by PI, otherwise we get decimal overflow in Area calculation
    private const decimal MaxRadius = 1.588052498894994084082740687305337748448310574923476560599e+14m;

    private readonly decimal _radius;

    /// <summary>
    /// Creates a new instance of <see cref="Circle"/> with given radius.
    /// </summary>
    /// <param name="radius">Radius used to set a circle.</param>
    /// <exception cref="CircleRadiusException"></exception>
    public Circle(decimal radius)
    {
        CircleRadiusException.ThrowIfOutOfRange(0, MaxRadius, radius); 
        
        _radius = radius;
    }

    public decimal Area => _radius * _radius * (decimal)Math.PI;
}