using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;
using Xunit;
namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public static class RouteInTheNitrideParticleNebulaTest
{
    [Theory]
    [MemberData(nameof(DataForRouteInTheNitrideParticleNebulaTest.TestData), MemberType = typeof(DataForRouteInTheNitrideParticleNebulaTest))]
    public static void ComparingThePassageOfTheRouteByShipsTheRes4UltShouldBeThatTheVaclasIsDressed(PleasureShuttle pleasureShuttle, Vaclas vaclas, int lenghtRoute)
    {
        var routeForVaclas = new RouteInTheNitrideParticleNebula(lenghtRoute, new List<IObstacle>() { new Asteroids() });
        var routeForPleasureShuttle = new RouteInTheNitrideParticleNebula(lenghtRoute, new List<IObstacle>() { new Asteroids() });
        bool resultVaclasRoute = routeForVaclas.StartRouteInTheNitrideParticleNebula(vaclas);
        bool resultPleasureShuttleRoute = routeForPleasureShuttle.StartRouteInTheNitrideParticleNebula(pleasureShuttle);
        bool result;
        bool expectedResult = true;
        if ((resultVaclasRoute && resultPleasureShuttleRoute) || resultPleasureShuttleRoute)
        {
            result = false;
        }
        else
        {
            result = true;
        }

        Assert.Equal(expectedResult, result);
    }
}
