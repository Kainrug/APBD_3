
namespace ConsoleApp2;

public class Container
{
    

    public double CargoWeight { get; private set; } 
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

    // Metoda do ładowania kontenera
    public  void LoadCargo(double cargoWeight)
    {
        if (cargoWeight > MaxCargoCapacity)
        {
            throw new OverfillException("Attempted to load cargo exceeding container's capacity limits.");
        }

        
        Console.WriteLine($"Cargo loaded into container. Cargo weight: {cargoWeight + Weight} kg");
    }
    
    public void UnloadCargo()
    {
        Weight = 0;
        Console.WriteLine("Container unloaded.");
    }

}