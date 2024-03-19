namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public class Meteorites : IObstacle
{
    private const int Damage = 1000;
    public int ObstacleDamage => Damage;
}