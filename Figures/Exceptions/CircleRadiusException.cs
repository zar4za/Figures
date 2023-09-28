namespace Shapes.Exceptions;

/// <summary>
/// This exception is thrown when a radius cannot be used for creating a <see cref="Circle"/>.
/// </summary>
public class CircleRadiusException : FigureException
{
    public CircleRadiusException(decimal min, decimal max, decimal radius) :
        base($"Radius expected to be from {min} up to {max} but was {radius}")
    {
        
    }

    /// <summary>
    /// A helper method used to shorten guard statement validation.
    /// </summary>
    /// <param name="min">Minimal length included.</param>
    /// <param name="max">Maximal length included.</param>
    /// <param name="actual">An actual length that should fit in range.</param>
    /// <exception cref="CircleRadiusException"></exception>
    public static void ThrowIfOutOfRange(decimal min, decimal max, decimal actual)
    {
        if (actual < min || actual > max)
            throw new CircleRadiusException(min, max, actual);
    }
}