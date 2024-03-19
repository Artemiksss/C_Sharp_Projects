using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Routes;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;
using Xunit;
namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class MediumRoutTest
{
    [Theory]
    [InlineData(15000)]
    public void StartMediumRouteReturnTheResultOfTheRouteAugurWhenTheShipIsTransferred(int lenghtRoute)
    {
        var augur = new Augur();
        var route = new MediumRoute(lenghtRoute, new List<IObstacle>() { new Asteroids(), new Asteroids() });
        bool result = route.StartMediumRoute(augur);

        bool expectedResult = false;
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(15000)]
    public void StartMediumRouteReturnTheResultOfTheRoutePleasureShattleWhenTheShipIsTransferred(int lenghtRoute)
    {
        var augur = new PleasureShuttle();
        var route = new MediumRoute(lenghtRoute, new List<IObstacle>() { new Asteroids(), new Asteroids() });
        bool result = route.StartMediumRoute(augur);

        bool expectedResult = false;
        Assert.Equal(expectedResult, result);
    }
}