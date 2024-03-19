using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Routes;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;
using Xunit;
namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class MediumLengthRouteNebulaOfIncreasedSpaceDensityTest
{
    [Theory]
    [InlineData(10000)]
    public void StartMediumLengthRouteNebulaOfIncreasedSpaceDensityTest(int lenghtRoute)
    {
        var augur = new Augur();
        var stella = new Stella();
        double num1 = stella.FlightRange();
        double num2 = augur.FlightRange();
        var routeForAugur = new MediumRoute(lenghtRoute, new List<IObstacle>() { new Asteroids(), new Asteroids() });
        var routeForStella = new MediumRoute(lenghtRoute, new List<IObstacle>() { new Asteroids(), new Asteroids() });
        bool resultAugurRoute = routeForAugur.StartMediumRoute(augur);
        bool resultStellaRoute = routeForStella.StartMediumRoute(stella);
        bool result;
        if (resultAugurRoute && resultStellaRoute && (num1 > num2))
        {
            result = true;
        }
        else
        {
            result = false;
        }

        bool expectedResult = true;
        Assert.Equal(expectedResult, result);
    }
}