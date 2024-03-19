namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public class WiFiAdapter : IWiFiAdapter
{
    private readonly ComponentCharacteristics _componentCharacteristics = new ComponentCharacteristics();
    public WiFiAdapter(int wiFiStandardVersion, bool bluetoothModule, int pciEVersion, int powerConsumption)
    {
        WiFiStandardVersion = wiFiStandardVersion;
        BluetoothModule = bluetoothModule;
        PciEVersion = pciEVersion;
        PowerConsumption = powerConsumption;
        AddAllCharacteristicsToArray();
    }

    public int WiFiStandardVersion { get; init; }
    public bool BluetoothModule { get; init; }
    public int PciEVersion { get; init; }
    public int PowerConsumption { get; init; }
    public ComponentCharacteristics AllComponentCharacteristics => _componentCharacteristics;
    public void AddAllCharacteristicsToArray()
    {
        _componentCharacteristics.Add(WiFiStandardVersion);
        _componentCharacteristics.Add(BluetoothModule);
        _componentCharacteristics.Add(PciEVersion);
        _componentCharacteristics.Add(PowerConsumption);
    }

    public WiFiAdapterBuilder DeBuilder()
    {
        var builder = new WiFiAdapterBuilder();
        return builder.SetWiFiStandardVersion(WiFiStandardVersion)
            .SetBluetoothModule(BluetoothModule)
            .SetPciEVersion(PciEVersion)
            .SetPowerConsumption(PowerConsumption);
    }
}