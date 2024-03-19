using System.Collections.Generic;
using System.Collections.Immutable;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories;

namespace Itmo.ObjectOrientedProgramming.Lab2;

public class ListComponents : IListComponents
{
    private readonly ICollection<IComputerComponent> _componentCharacteristics;

    public ListComponents()
    {
        _componentCharacteristics = new List<IComputerComponent>();
    }

    public bool CheckContains(IComputerComponent component)
    {
        return _componentCharacteristics.Contains(component);
    }

    public IReadOnlyCollection<IComputerComponent> GetAll()
    {
        return _componentCharacteristics.ToImmutableList();
    }

    public void Add(IComputerComponent component)
    {
        _componentCharacteristics.Add(component);
    }

    public void Delete(IComputerComponent component)
    {
        _componentCharacteristics.Remove(component);
    }
}