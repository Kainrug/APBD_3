using ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        

        
        var liquidContainer = new LiquidContainer(1000, 200, 300, 150, 2000, true);
        Console.WriteLine($"Liquid Container Number: {liquidContainer.SerialNumber}");

        
        liquidContainer.LoadCargo(1500);

        
        liquidContainer.UnloadCargo();

        
        var gasContainer = new GasContainer(800, 200, 300, 150, 2.5, true);
        Console.WriteLine($"Gas Container Number: {gasContainer.SerialNumber}");

        
        gasContainer.LoadCargo(700);

        
        gasContainer.UnloadCargo();

        
        var refrigeratedContainer = new RefrigeratedContainer(1200, 200, 300, 150, "Fruit", 4.0);
        Console.WriteLine($"Refrigerated Container Number: {refrigeratedContainer.SerialNumber}");

        
        var containerShip = new ContainerShip(25.0, 100, 500); // Max weight capacity set to 500 tons
        containerShip.PrepareForVoyage();

        
        containerShip.LoadContainer(liquidContainer);
        containerShip.LoadContainer(gasContainer);
        containerShip.LoadContainer(refrigeratedContainer);

        
        containerShip.PrintShipInfo();
    }
}