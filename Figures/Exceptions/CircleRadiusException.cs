namespace Shapes.Exceptions;

public class CircleRadiusException : FigureException
{
    public CircleRadiusException(decimal min, decimal max, decimal radius) :
        base($"Radius expected to be from {min} up to {max} but was {radius}")
    {
        
    }

    public static void ThrowIfOutOfRange(decimal min, decimal max, decimal actual)
    {
        if (actual < min || actual > max) 
            throw new CircleRadiusException(min, max, actual);
    }
}