namespace ObjectOrientedDTSP.DesignPrinciples.Extensions;

public static class RandomExtensions
{
    public static bool NextBool(this Random random) => random.NextDouble() > 0.5;
}