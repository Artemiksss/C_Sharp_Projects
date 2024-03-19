using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public class ComponentCharacteristics
{
    private readonly ICollection<object> _componentCharacteristics;

    public ComponentCharacteristics()
    {
        _componentCharacteristics = new List<object>();
    }

    public void Add(object value)
    {
        _componentCharacteristics.Add(value);
    }

    public IEnumerable<object> PrintAll()
    {
        return _componentCharacteristics;
    }

    public bool CheckingContains(object value)
    {
        return _componentCharacteristics.Contains(value);
    }

    public void Delete(object value)
    {
        _componentCharacteristics.Remove(value);
    }
}