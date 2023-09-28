namespace Figures;

public class Circle : IFigure
{
    private readonly decimal _radius;

    public Circle(decimal radius)
    {
        _radius = radius;
    }

    public decimal Area => (decimal)Math.PI * _radius * _radius;
}