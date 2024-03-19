using Itmo.ObjectOrientedProgramming.Lab1.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

public interface ISpaceShip
{
    public Engine? TypeEngine();
    public JumpEngine? TypeJumpEngine();
}