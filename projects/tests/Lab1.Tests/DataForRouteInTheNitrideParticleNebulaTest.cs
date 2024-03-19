using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public static class DataForRouteInTheNitrideParticleNebulaTest
{
    public static IEnumerable<object[]> TestData()
    {
        return new List<object[]>
        {
            new object[] { new PleasureShuttle(), new Vaclas(), 400 },
        };
    }
}