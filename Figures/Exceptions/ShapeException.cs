namespace Shapes.Exceptions;

/// <summary>
/// Base exception abstraction for Shapes
/// </summary>
public abstract class ShapeException : Exception
{
    protected ShapeException(string message) : base(message) { }

    protected ShapeException(string message, Exception innerException) : base(message, innerException) { }
}