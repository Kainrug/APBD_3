namespace ConsoleApp2;

public class ContainerShip
{
    public List<Container> Containers { get; private set; }
    public double MaxSpeed { get; private set; }
    public int MaxContainers { get; private set; }
    public double MaxWeightCapacity { get; private set; }

    public ContainerShip(double maxSpeed, int maxContainers, double maxWeightCapacity)
    {
        MaxSpeed = maxSpeed;
        MaxContainers = maxContainers;
        MaxWeightCapacity = maxWeightCapacity;
        Containers = new List<Container>();
    }

    public void PrepareForVoyage()
    {
        
        Console.WriteLine("Container ship prepared for voyage.");
    }

    
    public void LoadContainer(Container container)
    {
        if (Containers.Count >= MaxContainers)
        {
            throw new Exception("Cannot load more containers. Maximum capacity reached.");
        }

        Containers.Add(container);
        Console.WriteLine($"Container {container.SerialNumber} loaded onto the ship.");
    }

    
    public void UnloadContainer(Container container)
    {
        if (Containers.Contains(container))
        {
            Containers.Remove(container);
            Console.WriteLine($"Container {container.SerialNumber} unloaded from the ship.");
        }
        else
        {
            throw new Exception($"Container {container.SerialNumber} not found on the ship.");
        }
    }

    
    public void PrintShipInfo()
    {
        Console.WriteLine($"Container ship information: Max Speed: {MaxSpeed} knots, Max Containers: {MaxContainers}, Max Weight Capacity: {MaxWeightCapacity} tons.");
        Console.WriteLine("Containers on the ship:");
        foreach (var container in Containers)
        {
            Console.WriteLine($"- Container: {container.SerialNumber}, Cargo Weight: {container.CargoWeight} kg, Height: {container.Height} cm, Weight: {container.Weight} kg, Depth: {container.Depth} cm");
        }
    }
}