using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Space;

public class HighDensityNebulae : IDefaultSpace
{
    public bool AvailableToMove(Spaceship? spaceship)
    {
        if (spaceship != null && (spaceship.TypeJumpEngine() is not null))
        {
            return true;
        }

        return false;
    }
}