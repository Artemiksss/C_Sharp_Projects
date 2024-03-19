namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public interface IWiFiAdapter : IComputerComponent, IWiFiAdapterBuilderDirector
{
    public int WiFiStandardVersion { get; protected init; }
    public bool BluetoothModule { get; protected init; }
    public int PciEVersion { get; protected init; }
    public int PowerConsumption { get; protected init; }
}