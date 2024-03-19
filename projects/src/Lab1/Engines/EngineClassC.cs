namespace Itmo.ObjectOrientedProgramming.Lab1.Engines;

public class EngineClassC : Engine
{
    private const double EngineClassCFuelConsumption = 10.0;
    private const int PowerEngineClassC = 1000;

    public EngineClassC()
    {
        Name = "Standard pulse Engine class C";
        FuelConsumption = EngineClassCFuelConsumption;
        Power = PowerEngineClassC;
    }

    public override double GetShipFuelConsumption()
    {
        return FuelConsumption;
    }
}