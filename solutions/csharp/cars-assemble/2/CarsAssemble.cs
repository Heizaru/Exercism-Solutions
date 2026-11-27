static class AssemblyLine
{
    private const int CarsPerHour = 221;
    public static double SuccessRate(int speed) => speed switch
    {
            0 => 0.00,
            >= 1 and <= 4 => 1.00,
            >= 5 and <= 8 => 0.90,
            9 => 0.80,
            10 => 0.77,
            _ => throw new ArgumentOutOfRangeException(nameof(speed), speed, null)
        };
    
    public static double ProductionRatePerHour(int speed)
    {
        return SuccessRate(speed) * speed * CarsPerHour;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int) ProductionRatePerHour(speed) / 60;
    }
}
