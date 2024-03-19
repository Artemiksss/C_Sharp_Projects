using Itmo.ObjectOrientedProgramming.Lab3.DisplayDriver;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.DisplayForMessage;

public class Display : IDisplay
{
    private readonly IConsoleDisplayDriver _consoleDisplayDriver;
    public Display(IConsoleDisplayDriver consoleDisplayDriver)
    {
        _consoleDisplayDriver = consoleDisplayDriver;
    }

    public void PrintMessage(IMessage message)
    {
        _consoleDisplayDriver.PrintText(message);
    }

    public void PrintColorText(ColorRGB color, IMessage message)
    {
        _consoleDisplayDriver.SetColor(color);
        _consoleDisplayDriver.ColorText(message);
    }
}