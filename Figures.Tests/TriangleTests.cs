namespace Shapes.Tests;

public class TriangleTests
{
    public static TheoryData<decimal, decimal, decimal, decimal> TriangleData => new()
    {
        { 0.000001m, 0.000002m, 0.000002m, 9.682458365518542e-13m },
        { 1m, 2m, 1.5m, 0.7261843774138906659711122624m }
    };

    public static TheoryData<decimal, decimal, decimal, decimal> RightTriangleData => new()
    {
        { 3m, 4m, 5m, 6m }
    };

    public static TheoryData<decimal, decimal, decimal, decimal> OrderTriangleData => new()
    {
        { 3m, 5m, 4m, 6m },
        { 5m, 4m, 3m, 6m },
        { 4m, 5m, 3m, 6m }
    };


    [Theory]
    [MemberData(nameof(TriangleData))]
    public void Area_WithCloseToLimitSides_ShouldReturnCorrectArea(decimal sideA, decimal sideB, decimal sideC,
        decimal expectedArea)
    {
        var triangle = new Triangle(sideA, sideB, sideC);

        var area = triangle.Area;

        Assert.Equal(expectedArea, area);
    }

    [Theory]
    [MemberData(nameof(RightTriangleData))]
    public void Area_RightTriangle_ShouldReturnCorrectArea(decimal sideA, decimal sideB, decimal sideC,
        decimal expectedArea)
    {
        var triangle = new Triangle(sideA, sideB, sideC);

        var area = triangle.Area;
        
        Assert.True(triangle.IsRight);
        Assert.Equal(expectedArea, area);
    }

    [Theory]
    [MemberData(nameof(OrderTriangleData))]
    public void Area_DifferentOrderButSameSides_ShouldReturnCorrectArea(decimal sideA, decimal sideB, decimal sideC,
        decimal expectedArea)
    {
        var triangle = new Triangle(sideA, sideB, sideC);

        var area = triangle.Area;

        Assert.Equal(expectedArea, area);
    }
}