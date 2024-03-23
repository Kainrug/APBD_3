namespace ConsoleApp2;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; private set; }

    public GasContainer(double cargoWeight, double height, double weight, double depth, double pressure, bool isHazardous)
        : base(cargoWeight, height, weight, depth, pressure, isHazardous, "G")
    {
        Pressure = pressure;
    }

    public new void LoadCargo(double weight)
    {
        CargoWeight += weight;
        Console.WriteLine($"Cargo loaded into gas container. Cargo weight: {CargoWeight} kg");
    }

    public void Notify(string message, string containerNumber)
    {
        Console.WriteLine($"Hazard notification: {message}, Container: {containerNumber}");
    }

    public  void UnloadCargo()
    {
        CargoWeight *= 0.05;
        Console.WriteLine("Gas container unloaded, 5% of cargo remaining in the container. Remains :" + CargoWeight + "kg");
    }
}