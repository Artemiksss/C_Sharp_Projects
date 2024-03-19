using System;
using Itmo.ObjectOrientedProgramming.Lab1.CaseStrength;
using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

public abstract class Spaceship : ISpaceShip
{
    protected Spaceship()
    {
        IsLaunched = false;
        IsAlive = true;
        IsAvailabilityPhotonicDeflectors = true;
        IsCrewAvailability = true;
    }

    public bool IsAlive { get; protected set; }
    public bool IsLaunched { get; protected set; }
    public bool IsCrewAvailability { get; protected set; }
    public bool IsAvailabilityPhotonicDeflectors { get;  protected set; }
    public double FuelTankCapacity { get;  protected set; }
    public int LimitAntimatterFlares { get;  protected set; }
    public PhotonicDeflectors? PhotonicDeflector { get; protected set; }
    protected Engine? Engine { get;  init; }
    protected JumpEngine? JumpEngine { get; init; }
    protected IDeflector? Deflector { get; init; }
    protected ICaseStrength? CaseStrength { get; init; }
    protected ShipHitPoints? HitPoints { get; init; }
    protected string? Name { get; init; }
    protected double Expenditure { get; init; }
    protected Engine? EngineType => Engine;
    public double TheCostOfTheFlight(int lenRoute)
    {
        return lenRoute / Expenditure;
    }

    public void InstallPhotonDeflector()
    {
        PhotonicDeflector = new PhotonicDeflectors();
        LimitAntimatterFlares = PhotonicDeflector.GetLimitAntimatterFlares(Deflector);
    }

    public Engine? TypeEngine()
    {
        return Engine;
    }

    public JumpEngine? TypeJumpEngine()
    {
        return JumpEngine;
    }

    public double FlightRange()
    {
        return FuelTankCapacity / (Expenditure / 100);
    }

    public bool StatusAvailabilityPhotonicDeflector() => IsAvailabilityPhotonicDeflectors;

    public void SetAvailabilityPhotonicDeflector()
    {
        IsAvailabilityPhotonicDeflectors = false;
    }

    public void StartTheEngine(Engine engine)
    {
        if (engine == null)
        {
            throw new ArgumentNullException(nameof(engine), "Engine cannot be null");
        }

        engine.EngineStart();
        if (Engine != null) FuelTankCapacity -= (Engine.GetShipFuelConsumption() - 10) * 100;
        IsLaunched = true;
    }

    public void StopTheEngine(Engine engine)
    {
        if (engine == null)
        {
            throw new ArgumentNullException(nameof(engine), "Engine cannot be null");
        }

        engine.EngineStop();
        IsLaunched = false;
    }

    public abstract void Damage(IObstacle? obstacle);
    public abstract int Movement(int lenRoute, bool aliveStatusShip, bool lifeStatusOfTheCrew);
    public void SetLifeStatusOfTheCrew()
    {
        IsCrewAvailability = false;
    }

    public bool LifeStatusOfTheCrew() => IsCrewAvailability;

    public bool AliveStatus() => IsAlive;
}