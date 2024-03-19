using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engines;

public abstract class Engine
{
    public bool StatusEngine { get; protected set; }
    public string? Name { get; protected set; }
    protected double FuelConsumption { get; init; }
    protected int Power { get; init; }
    public void EngineStart()
    {
        if (StatusEngine == true)
        {
            throw new InvalidOperationException("Engine is already running.");
        }
        else
        {
            StatusEngine = true;
        }
    }

    public void EngineStop()
    {
        if (StatusEngine == false)
        {
            throw new InvalidOperationException("The engine is already installed.");
        }
        else
        {
            StatusEngine = false;
        }
    }

    public abstract double GetShipFuelConsumption();
}