namespace ConsoleApp2;

public class RefrigeratedContainer : Container
{
    public string ProductType { get; private set; }
    public double RequiredTemperature { get; private set; }

    public RefrigeratedContainer(double cargoWeight, double height, double weight, double depth, string productType, double requiredTemperature)
        : base(cargoWeight, height, weight, depth, 0, false, "C")
    {
        ProductType = productType;
        RequiredTemperature = requiredTemperature;
    }
}