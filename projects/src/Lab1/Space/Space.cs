using Itmo.ObjectOrientedProgramming.Lab1.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Space;

public class Space : IDefaultSpace
{
    public bool AvailableToMove(Spaceship? spaceship)
    {
        if (spaceship != null && spaceship.TypeEngine() is EngineClassC)
        {
            return true;
        }

        return false;
    }
}
