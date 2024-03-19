using Itmo.ObjectOrientedProgramming.Lab1.CaseStrength;
using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class ShipHitPoints
{
    public ShipHitPoints(IDeflector? deflector, ICaseStrength? caseStrength)
    {
        if (deflector != null) HitPointsDeflector = deflector.GetCurrentHealth;
        if (caseStrength != null) HitPointsCaseStrength = caseStrength.GetCurrentHealth;
    }

    public ShipHitPoints(int deflector, ICaseStrength? caseStrength)
    {
        HitPointsDeflector = deflector;
        if (caseStrength != null) HitPointsDeflector = caseStrength.GetCurrentHealth;
    }

    public int HitPointsDeflector { get; private set; }
    public int HitPointsCaseStrength { get; private set; }

    public void ChangeHitPointsDeflector(int damage)
    {
        HitPointsDeflector -= damage;
    }

    public void ChangeHitPointsCaseStrength(int damage)
    {
        HitPointsCaseStrength -= damage;
    }
}