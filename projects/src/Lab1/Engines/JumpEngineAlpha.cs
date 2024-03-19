namespace Itmo.ObjectOrientedProgramming.Lab1.Engines;

public class JumpEngineAlpha : JumpEngine
{
    private const string NameJumpEngineAlpha = "Alpha Jump Engine";
    private const double FuelConsumptionAlphaJumpEngine = 50.0;
    private const int JumpDistanceFuelConsumptionAlphaJumpEngine = 1000;
    public JumpEngineAlpha()
        : base(NameJumpEngineAlpha,  FuelConsumptionAlphaJumpEngine, JumpDistanceFuelConsumptionAlphaJumpEngine)
    {
    }

    public override double GetShipFuelConsumption()
    {
        return FuelConsumption;
    }
}