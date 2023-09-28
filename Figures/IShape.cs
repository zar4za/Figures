namespace Shapes;

/// <summary>
/// Base abstraction for working with shapes
/// </summary>
public interface IShape
{
    /// <summary>
    /// Calculated area of a shape in squared units used on instantiation
    /// </summary>
    public decimal Area { get; }
}