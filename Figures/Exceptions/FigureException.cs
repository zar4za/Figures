namespace Shapes.Exceptions;

public abstract class FigureException : Exception
{
    protected FigureException(string message) : base(message) { }

    protected FigureException(string message, Exception innerException) : base(message, innerException) { }
}