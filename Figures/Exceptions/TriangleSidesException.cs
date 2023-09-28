namespace Shapes.Exceptions;

public class TriangleSidesException : FigureException
{
    public TriangleSidesException() : base("The triangle has impossible sides.") {}

    public static void ThrowIfImpossible(decimal longest, decimal leg1, decimal leg2)
    {
        if (longest > leg1 + leg2)
        {
            throw new TriangleSidesException();
        }
    }
}