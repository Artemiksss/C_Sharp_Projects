namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public interface IComputerComponent
{
    public ComponentCharacteristics AllComponentCharacteristics { get; }
    public void AddAllCharacteristicsToArray();
}