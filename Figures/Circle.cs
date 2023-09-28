using Figures.Exceptions;

namespace Figures;

public class Circle : IFigure
{
    // sqrt from max decimal area divided by PI, otherwise we get decimal overflow in Area calculation
    private const decimal MaxRadius = 1.588052498894994084082740687305337748448310574923476560599e+14m;

    private readonly decimal _radius;

    public Circle(decimal radius)
    {
        CircleRadiusException.ThrowIfOutOfRange(0, MaxRadius, radius); 
        
        _radius = radius;
    }

    public decimal Area => _radius * _radius * (decimal)Math.PI;
}