namespace Itmo.ObjectOrientedProgramming.Lab1.Engines;

public class EngineClassE : Engine
{
    private const double EngineClassCFuelConsumption = 20.0;
    private const int PowerEngineClassC = 2000;
    public EngineClassE()
    {
        Name = "Standard pulse Engine class E";
        FuelConsumption = EngineClassCFuelConsumption;
        Power = PowerEngineClassC;
    }

    public override double GetShipFuelConsumption()
    {
        return FuelConsumption;
    }
}