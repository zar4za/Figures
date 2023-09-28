namespace Figures;

internal class DecimalMath
{
    public static decimal Sqrt(decimal x, decimal? guess = null)
    {
        var ourGuess = guess.GetValueOrDefault(x / 2m);
        var result = x / ourGuess;
        var average = (ourGuess + result) / 2m;

        return average == ourGuess ? average : Sqrt(x, average);
    }
}