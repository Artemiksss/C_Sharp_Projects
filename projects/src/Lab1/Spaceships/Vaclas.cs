using Itmo.ObjectOrientedProgramming.Lab1.CaseStrength;
using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

public class Vaclas : Spaceship
{
    private const int DistanceOneSegment = 4000;
    private const double SpaceFuelTankCapacity = 7000;
    public Vaclas()
        : base()
    {
        JumpEngine = new JumpEngineGamma();
        Engine = new EngineClassE();
        CaseStrength = new StrengthOfClassSecond();
        Deflector = new DeflectorClassFirst();
        Name = "Vaclas";
        FuelTankCapacity = SpaceFuelTankCapacity;
        Expenditure = Engine.GetShipFuelConsumption();
        HitPoints = new ShipHitPoints(Deflector, CaseStrength);
    }

    public override int Movement(int lenRoute, bool aliveStatusShip, bool lifeStatusOfTheCrew)
    {
        if (Engine == null)
        {
            return -1;
        }

        StartTheEngine(Engine);
        if (lifeStatusOfTheCrew)
        {
            if (aliveStatusShip)
            {
                if (FuelTankCapacity <= 0)
                {
                    StopTheEngine(Engine);
                    IsLaunched = false;
                }
                else
                {
                    FuelTankCapacity -= (DistanceOneSegment * Expenditure) / 100;
                    lenRoute -= DistanceOneSegment;
                    if (lenRoute < 0)
                    {
                        StopTheEngine(Engine);
                        return 0;
                    }
                }
            }
            else
            {
                StopTheEngine(Engine);
                return -1;
            }
        }
        else
        {
            StopTheEngine(Engine);
            return -1;
        }

        StopTheEngine(Engine);
        return lenRoute;
    }

    public override void Damage(IObstacle? obstacle)
    {
        if (obstacle is AntimatterFlares)
        {
            if (PhotonicDeflector != null)
            {
                if (LimitAntimatterFlares <= 0)
                {
                    IsCrewAvailability = false;
                }
                else
                {
                    LimitAntimatterFlares -= obstacle.ObstacleDamage;
                }
            }
            else
            {
                IsCrewAvailability = false;
            }
        }

        if (HitPoints != null && HitPoints.HitPointsDeflector <= 0)
        {
            if (HitPoints.HitPointsCaseStrength <= 0)
            {
                IsAlive = false;
                IsLaunched = false;
            }
            else
            {
                if (obstacle != null) HitPoints.ChangeHitPointsCaseStrength(obstacle.ObstacleDamage);
            }
        }
        else
        {
            if (obstacle != null && HitPoints != null) HitPoints.ChangeHitPointsDeflector(obstacle.ObstacleDamage);
        }

        if (HitPoints != null && HitPoints.HitPointsDeflector + HitPoints.HitPointsCaseStrength <= 0)
        {
            IsAlive = false;
        }
    }
}