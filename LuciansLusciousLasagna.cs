class Lasagna
{
    private const int TimeInOven = 40;
    private const int TimePerLayer = 2;

    public int ExpectedMinutesInOven()
    {
        return TimeInOven;
    }

    public int RemainingMinutesInOven(int cookingTime)
    {
        return TimeInOven - cookingTime;
    }

    public int PreparationTimeInMinutes(int layerCount)
    {
        return layerCount * TimePerLayer;
    }

    public int ElapsedTimeInMinutes(int layerCount, int cookingTime)
    {
        var preparationTime = this.PreparationTimeInMinutes(layerCount);
        return preparationTime + cookingTime;
    }
}
