namespace ConsoleApp2;

public class LiquidContainer : Container, IHazardNotifier
{
    public double Capacity { get; private set; }

    public LiquidContainer(double cargoWeight, double height, double weight, double depth, double capacity, bool isHazardous)
        : base(cargoWeight, height, weight, depth, capacity, isHazardous, "L")
    {
        Capacity = capacity;
    }

    public new void LoadCargo(double cargoWeight)
    {
        double maxCapacityPercentage = IsHazardous ? 0.5 : 0.9; 

        if (cargoWeight > MaxCargoCapacity * maxCapacityPercentage)
        {
            throw new OverfillException("Attempted to load cargo exceeding container's capacity limits.");
        }
        Console.WriteLine($"Cargo loaded into liquid container. Cargo weight: {cargoWeight} kg");
    }

    public void Notify(string message, string containerNumber)
    {
        Console.WriteLine($"Hazard notification: {message}, Container: {containerNumber}");
    }
}