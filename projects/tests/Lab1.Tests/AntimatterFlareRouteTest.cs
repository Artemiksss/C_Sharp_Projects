using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships;
using Xunit;
namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class AntimatterFlareRouteTest
{
    [Theory]
    [InlineData(5000)]
    public void StartAntimatterFlareRouteReturnTheResultOfTheRouteVaclasWhenTheShipIsTransferred(int lenRoute)
    {
        var vaclas = new Vaclas();
        var route = new AntimatterFlareRoute(lenRoute, new List<IObstacle>() { new AntimatterFlares() });
        bool result = route.StartAntimatterFlare(vaclas);
        bool expectedResult = false;
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(5000)]
    public void StartAntimatterFlareRouteReturnTheResultOfTheRouteVaclasWithPhotonicDeflectorWhenTheShipIsTransferred(int lenRoute)
    {
        var vaclas = new Vaclas();
        vaclas.InstallPhotonDeflector();
        var route = new AntimatterFlareRoute(lenRoute, new List<IObstacle>() { new AntimatterFlares() });
        bool result = route.StartAntimatterFlare(vaclas);
        bool expectedResult = true;
        Assert.Equal(expectedResult, result);
    }
}