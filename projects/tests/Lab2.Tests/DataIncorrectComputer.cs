using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.InformationalСomponents;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.MotherboardFormFactor;

namespace Itmo.ObjectOrientedProgramming.Lab2.Tests;

public static class DataIncorrectComputer
{
    public static IEnumerable<object[]> TestData()
    {
        return new List<object[]>
        {
            new object[]
            {
                new Cpu(3.5, 6, "LGA 2011", true, 2133, 100, 105),
                new Motherboard("LGA 2011", new EATX().CountPciELanes, new EATX().CountSataPorts, "С230", "DDR4", new EATX().CountRamSlots, new EATX(), new Bios("Award Phoenix", "3.XX", "intel i5, intel i7")),
                new GraphicsAdapter(11, 25, 6, 3, 1550, 240),
                new Hdd(5, 5, 6),
                new PowerUnit(550),
                new ProcessorCoolingSystem(12, 12, "LGA 2011", 150),
                new Ram(16, 400, "XMP", "DIMM", "DDR4", 2),
                new Ssd("PCI", 1024, 550, 4),
                new SystemBlock(53, 30, "EATX",  70, 50),
                new Bios("Award Phoenix", "2.XX", "intel i5, intel i7"),
                new WiFiAdapter(6, false, 3, 2),
                new XmpProfile("16-18-18-35", 5, 1000),
            },
        };
    }
}