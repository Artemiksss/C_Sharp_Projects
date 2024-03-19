using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Space;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class ShortRoute
{
    private readonly ICollection<IObstacle> _obstacles;
    public ShortRoute(int length,  ICollection<IObstacle> obstacle)
    {
        LenRoute = length;
        _obstacles = obstacle;
    }

    public int LenRoute { get; private set; }
    public bool StartShortRoute(Spaceship? spaceship)
    {
        var natural = new HighDensityNebulae();
        if (spaceship == null)
        {
            return false;
        }

        if (natural.AvailableToMove(spaceship))
        {
            LenRoute = spaceship.Movement(LenRoute, spaceship.AliveStatus(), spaceship.LifeStatusOfTheCrew());
            foreach (IObstacle obstacle in _obstacles)
            {
                spaceship.Damage(obstacle);
            }

            LenRoute = spaceship.Movement(LenRoute, spaceship.AliveStatus(), spaceship.LifeStatusOfTheCrew());
        }

        if (LenRoute == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}