namespace Figures;

public class Triangle : IFigure
{
    private decimal _sideA;
    private decimal _sideB;
    private decimal _sideC;


    public Triangle(decimal sideA, decimal sideB, decimal sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public decimal Area { get; }
}