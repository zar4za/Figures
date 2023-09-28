namespace Figures.Tests;

public class CircleTests
{
    private const decimal Pi = (decimal)Math.PI;

    public static TheoryData<decimal, decimal> CircleData => new()
    {
        { 0.000001m, Pi * 1e-12m },
        { 2.34e-14m, Pi * 5.4756e-28m },
        { 1000000m, Pi * 1e+12m },
        { 1e+14m, Pi * 1e+28m },
        { 1m, Pi }
    };



    [Theory]
    [MemberData(nameof(CircleData))]
    public void Area_WithCloseToLimitRadius_ShouldReturnCorrectArea(decimal radius, decimal expectedArea)
    {
        var circle = new Circle(radius);

        var area = circle.Area;

        Assert.Equal(expectedArea, area);
    }
}