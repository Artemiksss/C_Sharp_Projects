using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engines;

public class JumpEngineGamma : JumpEngine
{
    private const string NameJumpEngineGamma = "Gamma Jump Engine";
    private const double FuelConsumptionGammaJumpEngine = 20;
    private const int JumpDistanceFuelConsumptionGammaJumpEngine = 1000;
    public JumpEngineGamma()
        : base(NameJumpEngineGamma,  FuelConsumptionGammaJumpEngine, JumpDistanceFuelConsumptionGammaJumpEngine)
    {
    }

    public override double GetShipFuelConsumption()
    {
        return Math.Pow(FuelConsumption, 2);
    }
}