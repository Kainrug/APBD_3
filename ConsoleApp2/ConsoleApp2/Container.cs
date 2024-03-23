
namespace ConsoleApp2;

public class Container
{
    

    public double CargoWeight { get; protected set; } 
    public double Height { get; private set; } 
    public double Weight { get; protected set; } 
    public double Depth { get; private set; } 
    public double MaxCargoCapacity { get; private set; } 
    public string SerialNumber { get; private set; } 
    public bool IsHazardous { get; private set; } 

    
    public Container(double cargoWeight, double height, double weight, double depth, double maxCargoCapacity, bool isHazardous, string type)
    {
        CargoWeight = cargoWeight;
        Height = height;
        Weight = weight;
        Depth = depth;
        MaxCargoCapacity = maxCargoCapacity;
        IsHazardous = isHazardous;
        SerialNumber = GenerateSerialNumber(type);
    }

    
    private string GenerateSerialNumber(string type)
    {
        string serialNumber = $"KON-{type}-{Guid.NewGuid().ToString().Substring(0, 4)}";
        return serialNumber;
    }

    
    public  void LoadCargo(double weight)
    {
        CargoWeight += weight;
        Console.WriteLine($"Cargo loaded into container. Cargo weight: {CargoWeight} kg");
    }
    
    public void UnloadCargo()
    {
        CargoWeight = 0;
        Console.WriteLine("Container unloaded.");
    }

}