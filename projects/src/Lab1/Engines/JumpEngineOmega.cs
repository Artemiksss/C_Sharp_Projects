namespace Itmo.ObjectOrientedProgramming.Lab1.Engines;

public class JumpEngineOmega : JumpEngine
{
    private const string NameJumpEngineOmega = "Omega Jump Engine";
    private const double FuelConsumptionOmegaJumpEngine = 20;
    private const int JumpDistanceFuelConsumptionOmegaJumpEngine = 1000;
    public JumpEngineOmega()
        : base(NameJumpEngineOmega,  FuelConsumptionOmegaJumpEngine, JumpDistanceFuelConsumptionOmegaJumpEngine)
    {
    }

    public override double GetShipFuelConsumption()
    {
        return double.Log2(FuelConsumption);
    }
}