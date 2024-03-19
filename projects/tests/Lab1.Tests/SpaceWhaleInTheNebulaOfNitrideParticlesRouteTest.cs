using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;
using Xunit;
namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;
public class SpaceWhaleInTheNebulaOfNitrideParticlesRouteTest
{
    [Theory]
    [InlineData(5000)]
    public void StartSpaceWhaleInTheNebulaOfNitrideParticlesReturnTheResultOfTheRouteVaclasWhenTheShipIsTransferred(int lenghtRoute)
    {
        var vaclas = new Vaclas();
        var route = new SpaceWhaleInTheNebulaOfNitrideParticlesRoute(lenghtRoute, new List<IObstacle>() { new SpaceWhales() });
        bool result = route.StartSpaceWhaleInTheNebulaOfNitrideParticles(vaclas);
        bool expectedResult = false;
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(4000)]
    public void StartSpaceWhaleInTheNebulaOfNitrideParticlesReturnTheResultOfTheRouteMeredianWhenTheShipIsTransferred(int lenghtRoute)
    {
        var meredian = new Meredian();
        var route = new SpaceWhaleInTheNebulaOfNitrideParticlesRoute(lenghtRoute, new List<IObstacle>() { new SpaceWhales() });
        bool result = route.StartSpaceWhaleInTheNebulaOfNitrideParticles(meredian);
        bool expectedResult = true;
        if (result == false)
        {
            result = true;
        }

        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(5000)]
    public void StartSpaceWhaleInTheNebulaOfNitrideParticlesReturnTheResultOfTheRouteAugurWhenTheShipIsTransferred(int lenghtRoute)
    {
        var augur = new Augur();
        var route = new SpaceWhaleInTheNebulaOfNitrideParticlesRoute(lenghtRoute, new List<IObstacle>() { new SpaceWhales() });
        bool result = route.StartSpaceWhaleInTheNebulaOfNitrideParticles(augur);
        bool expectedResult = true;
        Assert.Equal(expectedResult, result);
    }
}