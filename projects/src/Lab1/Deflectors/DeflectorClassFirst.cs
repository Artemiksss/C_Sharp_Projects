namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public class DeflectorClassFirst : IDeflector
{
    private const int Health = 1000;
    public int GetCurrentHealth => Health;
}