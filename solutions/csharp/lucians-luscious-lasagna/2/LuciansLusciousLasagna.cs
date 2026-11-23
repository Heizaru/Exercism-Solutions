public class Lasagna
{
    const int cookingTime = 40; 
    const int timePerLayerMinutes = 2;
    
    public int ExpectedMinutesInOven() => cookingTime;

    public int RemainingMinutesInOven(int minutesInOven) => cookingTime - minutesInOven;
    
    public int PreparationTimeInMinutes(int layersAmount) => timePerLayerMinutes * layersAmount ;
    
    public int ElapsedTimeInMinutes(int layersAmount, int minutesInOven) => (PreparationTimeInMinutes(layersAmount) + minutesInOven);
}