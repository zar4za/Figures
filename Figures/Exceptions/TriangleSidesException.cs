namespace Shapes.Exceptions;

/// <summary>
/// This exception is thrown when a <see cref="Triangle"/> cannot be created with given sides.
/// </summary>
public class TriangleSidesException : FigureException
{
    public TriangleSidesException() : base("The triangle has impossible sides.") {}

    /// <summary>
    /// A helper method used to shorten guard statement validation.
    /// </summary>
    /// <param name="longest">The longest side of a triangle.</param>
    /// <param name="leg1">The first of the two left sides.</param>
    /// <param name="leg2">The second of the two left sides.</param>
    /// <exception cref="TriangleSidesException"></exception>
    public static void ThrowIfImpossible(decimal longest, decimal leg1, decimal leg2)
    {
        if (longest > leg1 + leg2)
        {
            throw new TriangleSidesException();
        }
    }
}