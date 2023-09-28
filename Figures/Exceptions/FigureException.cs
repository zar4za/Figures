namespace Shapes.Exceptions;

/// <summary>
/// Base exception abstraction for Shapes
/// </summary>
public abstract class FigureException : Exception
{
    protected FigureException(string message) : base(message) { }

    protected FigureException(string message, Exception innerException) : base(message, innerException) { }
}