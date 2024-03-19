using Itmo.ObjectOrientedProgramming.Lab2.Accessories;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.BasicСomponents.CPU;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.InformationalСomponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAssembler;

public class ComputerAssemblerBuilder : IComputerAssemblerBuilder
{
    private readonly ListComponents _components = new ListComponents();
    private ICpu? _currentCpu;
    private IMotherboard? _currentMotherboard;
    private IGraphicAdapter? _currentGraphicAdapter;
    private IHdd? _currentHdd;
    private IPowerUnit? _currentPowerUnit;
    private IProcessorCoolingSystem? _currentProcessorCoolingSystem;
    private IRam? _currentRam;
    private ISsd? _currentSsd;
    private ISystemBlock? _currentSystemBlock;
    private Bios? _currentBios;
    private IWiFiAdapter? _currentWiFiAdapter;
    private IXmpProfile? _currentXmpProfile;

    public ComputerAssemblerBuilder SetCpu(ICpu currentCpu)
    {
        if (currentCpu is null) throw new ComputerComponentNullException();
        _currentCpu = currentCpu.DeBuilder().Build();
        _components.Add(_currentCpu);
        return this;
    }

    public ComputerAssemblerBuilder SetMotherboard(IMotherboard currentMotherboard)
    {
        if (currentMotherboard is null) throw new ComputerComponentNullException();
        _currentMotherboard = currentMotherboard.DeBuilder().Build();
        _components.Add(_currentMotherboard);
        return this;
    }

    public ComputerAssemblerBuilder SetGraphicsAdapter(IGraphicAdapter? currentGraphicAdapter)
    {
        if (currentGraphicAdapter is null) throw new ComputerComponentNullException();
        _currentGraphicAdapter = currentGraphicAdapter.DeBuilder().Build();
        _components.Add(_currentGraphicAdapter);
        return this;
    }

    public ComputerAssemblerBuilder SetHdd(IHdd? currentHdd)
    {
        if (currentHdd is null) throw new ComputerComponentNullException();
        _currentHdd = currentHdd.DeBuilder().Build();
        _components.Add(_currentHdd);
        return this;
    }

    public ComputerAssemblerBuilder SetProcessorCoolingSystem(IProcessorCoolingSystem currentProcessorCoolingSystem)
    {
        if (currentProcessorCoolingSystem is null) throw new ComputerComponentNullException();
        _currentProcessorCoolingSystem = currentProcessorCoolingSystem.DeBuilder().Build();
        _components.Add(_currentProcessorCoolingSystem);
        return this;
    }

    public ComputerAssemblerBuilder SetPowerUnit(IPowerUnit currentPowerUnit)
    {
        if (currentPowerUnit is null) throw new ComputerComponentNullException();
        _currentPowerUnit = currentPowerUnit.DeBuilder().Build();
        _components.Add(_currentPowerUnit);
        return this;
    }

    public ComputerAssemblerBuilder SetRam(IRam currentRam)
    {
        if (currentRam is null) throw new ComputerComponentNullException();
        _currentRam = currentRam.DeBuilder().Build();
        _components.Add(_currentRam);
        return this;
    }

    public ComputerAssemblerBuilder SetSsd(ISsd? currentSsd)
    {
        if (currentSsd is null) throw new ComputerComponentNullException();
        _currentSsd = currentSsd.DeBuilder().Build();
        _components.Add(_currentSsd);
        return this;
    }

    public ComputerAssemblerBuilder SetSystemBlock(ISystemBlock currentSystemBlock)
    {
        if (currentSystemBlock is null) throw new ComputerComponentNullException();
        _currentSystemBlock = currentSystemBlock.DeBuilder().Build();
        _components.Add(_currentSystemBlock);
        return this;
    }

    public ComputerAssemblerBuilder SetBios(Bios currentBios)
    {
        if (currentBios is null) throw new ComputerComponentNullException();
        _currentBios = currentBios.DeBuilder().Build();
        _components.Add(_currentBios);
        return this;
    }

    public ComputerAssemblerBuilder SetWiFiAdapter(IWiFiAdapter? currentWiFiAdapter)
    {
        if (currentWiFiAdapter is null) throw new ComputerComponentNullException();
        _currentWiFiAdapter = currentWiFiAdapter.DeBuilder().Build();
        _components.Add(_currentWiFiAdapter);
        return this;
    }

    public ComputerAssemblerBuilder SetCXmpProfile(IXmpProfile? currentXmpProfile)
    {
        if (currentXmpProfile is null) throw new ComputerComponentNullException();
        _currentXmpProfile = currentXmpProfile.DeBuilder().Build();
        _components.Add(_currentXmpProfile);
        return this;
    }

    public ComputerAssembler Build()
    {
        return new ComputerAssembler(
            _currentCpu ?? throw new ComputerComponentNullException(),
            _currentMotherboard ?? throw new ComputerComponentNullException(),
            _currentGraphicAdapter ?? throw new ComputerComponentNullException(),
            _currentHdd ?? throw new ComputerComponentNullException(),
            _currentPowerUnit ?? throw new ComputerComponentNullException(),
            _currentProcessorCoolingSystem ?? throw new ComputerComponentNullException(),
            _currentRam ?? throw new ComputerComponentNullException(),
            _currentSsd ?? throw new ComputerComponentNullException(),
            _currentSystemBlock ?? throw new ComputerComponentNullException(),
            _currentBios ?? throw new ComputerComponentNullException(),
            _currentWiFiAdapter ?? throw new ComputerComponentNullException(),
            _currentXmpProfile ?? throw new ComputerComponentNullException());
    }
}