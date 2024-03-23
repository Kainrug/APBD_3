namespace ConsoleApp2;

public class LiquidContainer : Container, IHazardNotifier
{
    public double Capacity { get; private set; }

    public LiquidContainer(double cargoWeight, double height, double weight, double depth, double capacity, bool isHazardous)
        : base(cargoWeight, height, weight, depth, capacity, isHazardous, "L")
    {
        Capacity = capacity;
    }

    public new void LoadCargo(double weight)
    {
        if (IsHazardous)
        {
            if (CargoWeight + weight > MaxCargoCapacity * 0.5)
            {
                Console.WriteLine("Loaded dangerous cargo that is 50% more than payload");
            }
            else
            {
                if (CargoWeight + weight > MaxCargoCapacity * 0.9)
                {
                    Console.WriteLine("Loaded liquid to more than 90% of the payload");
                }
            }
        }
        base.LoadCargo(weight);
    }

    public void Notify(string message, string containerNumber)
    {
        Console.WriteLine($"Hazard notification: {message}, Container: {containerNumber}");
    }
}