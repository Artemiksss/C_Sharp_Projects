using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Routes;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;
using Xunit;
namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class ComparisonOfPleasureShuttleAndVaclasTest
{
    [Theory]
    [MemberData(nameof(DataForRouteInTheNitrideParticleNebulaTest.TestData), MemberType = typeof(DataForRouteInTheNitrideParticleNebulaTest))]
    public void TheCostOfTheFlightComparisonOfPleasureShuttleAndVaclas(PleasureShuttle pleasureShuttle, Vaclas vaclas, int lenghtRoute)
    {
        var routeForVaclas = new MediumRoute(lenghtRoute, new List<IObstacle>() { new Asteroids(), new Asteroids() });
        var routeForPleasureShuttle = new MediumRoute(lenghtRoute, new List<IObstacle>() { new Asteroids(), new Asteroids() });
        bool resultVaclasRoute = routeForVaclas.StartMediumRoute(vaclas);
        bool resultPleasureShuttleRoute = routeForPleasureShuttle.StartMediumRoute(pleasureShuttle);
        if (vaclas != null && pleasureShuttle != null)
        {
            double costRouteVaclas = vaclas.TheCostOfTheFlight(lenghtRoute);
            double costRoutePleasureShuttle = pleasureShuttle.TheCostOfTheFlight(lenghtRoute);
            bool result;
            if (resultVaclasRoute && resultPleasureShuttleRoute && (costRouteVaclas > costRoutePleasureShuttle))
            {
                result = false;
            }
            else
            {
                result = true;
            }

            bool expectedResult = true;
            Assert.Equal(expectedResult, result);
        }
    }
}