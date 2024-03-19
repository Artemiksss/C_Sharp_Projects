using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories;

namespace Itmo.ObjectOrientedProgramming.Lab2;

public interface IListComponents
{
    public bool CheckContains(IComputerComponent component);
    public IReadOnlyCollection<IComputerComponent> GetAll();
    public void Add(IComputerComponent component);
    public void Delete(IComputerComponent component);
}
