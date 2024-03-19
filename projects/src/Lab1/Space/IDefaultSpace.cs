using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Space;

public interface IDefaultSpace
{
    public bool AvailableToMove(Spaceship? spaceship);
}