namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public class Asteroids : IObstacle
{
    private const int Damage = 500;
    public int ObstacleDamage => Damage;
}