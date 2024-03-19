namespace Itmo.ObjectOrientedProgramming.Lab1.Engines;

public abstract class JumpEngine : Engine
{
    protected JumpEngine(string name, double fuelConsumption, double jumpDistance)
    {
        Name = name;
        FuelConsumption = fuelConsumption;
        JumpDistance = jumpDistance;
        StatusEngine = false;
    }

    public double JumpDistance { get;  private set; }
}