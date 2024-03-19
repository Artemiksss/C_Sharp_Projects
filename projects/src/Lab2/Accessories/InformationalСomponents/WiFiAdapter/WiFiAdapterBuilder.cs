namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public class WiFiAdapterBuilder : IWiFiAdapterBuilder
{
    private int _wiFiStandardVersion;
    private bool _bluetoothModule;
    private int _pciEVersion;
    private int _powerConsumption;

    public WiFiAdapterBuilder SetWiFiStandardVersion(int wiFiStandardVersion)
    {
        _wiFiStandardVersion = wiFiStandardVersion;
        return this;
    }

    public WiFiAdapterBuilder SetBluetoothModule(bool bluetoothModule)
    {
        _bluetoothModule = bluetoothModule;
        return this;
    }

    public WiFiAdapterBuilder SetPciEVersion(int pciEVersion)
    {
        _pciEVersion = pciEVersion;
        return this;
    }

    public WiFiAdapterBuilder SetPowerConsumption(int powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public WiFiAdapter Build()
    {
        return new WiFiAdapter(_wiFiStandardVersion, _bluetoothModule, _pciEVersion, _powerConsumption);
    }
}