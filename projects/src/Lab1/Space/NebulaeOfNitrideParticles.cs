using Itmo.ObjectOrientedProgramming.Lab1.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Space;

public class NebulaeOfNitrideParticles : IDefaultSpace
{
    public bool AvailableToMove(Spaceship? spaceship)
    {
        if (spaceship != null && spaceship.TypeEngine() is EngineClassE)
        {
            return true;
        }

        return false;
    }
}