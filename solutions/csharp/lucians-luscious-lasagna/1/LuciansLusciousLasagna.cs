public class Lasagna
{
    const int cookingTime = 40; 
    const int timePerLayerMinutes = 2;
    
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() {
        return cookingTime;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesInOven) {
        return cookingTime - minutesInOven;
    }

    
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layersAmount) {
        return timePerLayerMinutes * layersAmount ;
    }
    
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layersAmount, int minutesInOven) {
        
        return (PreparationTimeInMinutes(layersAmount)+ minutesInOven);
    }
}
