namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public interface IWiFiAdapterBuilder
{
    public WiFiAdapterBuilder SetWiFiStandardVersion(int wiFiStandardVersion);
    public WiFiAdapterBuilder SetBluetoothModule(bool bluetoothModule);
    public WiFiAdapterBuilder SetPciEVersion(int pciEVersion);
    public WiFiAdapterBuilder SetPowerConsumption(int powerConsumption);
    public WiFiAdapter Build();
}