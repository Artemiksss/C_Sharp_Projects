using Itmo.ObjectOrientedProgramming.Lab2.Accessories;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.InformationalСomponents;
using Xunit;
namespace Itmo.ObjectOrientedProgramming.Lab2.Tests;

public class ComputerAssemblyTestWithIncreasedVoltageRequirement
{
    [Theory]
    [MemberData(nameof(DataForTestingTheWrongComputer.TestData), MemberType = typeof(DataForTestingTheWrongComputer))]
    public void TestAttemptToBuildFromAnExactlyCompatibleComponent(Cpu cpu, Motherboard motherboard, GraphicsAdapter graphicsAdapter, Hdd hdd, PowerUnit powerUnit, ProcessorCoolingSystem processorCoolingSystem, Ram ram, Ssd ssd, SystemBlock systemBlock, Bios bios, WiFiAdapter wiFiAdapter, XmpProfile xmpProfile)
    {
        var computer = new ComputerAssembler.ComputerAssembler(cpu, motherboard, graphicsAdapter, hdd, powerUnit, processorCoolingSystem, ram, ssd, systemBlock, bios, wiFiAdapter, xmpProfile);
        computer.Direct().Build();
        var inspector = new Inspector.Inspector();
        bool result;
        if (inspector.CheckingBios(computer.CurrentBios, computer.CurrentMotherboard) &&
            inspector.CheckingSockets(computer.CurrentCpu, computer.CurrentMotherboard) &&
            inspector.CheckingTheHeatRelease(computer.CurrentProcessorCoolingSystem, computer.CurrentCpu) &&
            inspector.VoltageCheck(computer.CurrentPowerUnit, computer.CurrentCpu, computer.CurrentRam, computer.CurrentGraphicAdapter, computer.CurrentSsd, computer.CurrentHdd, computer.CurrentWiFiAdapter) &&
            inspector.CheckingTheQuantity(computer.CurrentMotherboard, computer.CurrentSsd, computer.CurrentGraphicAdapter) &&
            inspector.CheckingSize(computer.CurrentMotherboard, computer.CurrentProcessorCoolingSystem, computer.CurrentGraphicAdapter, computer.CurrentSystemBlock))
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