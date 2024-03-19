using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.DisplayDriver;

public interface IConsoleDisplayDriver
{
    public void SetColor(ColorRGB color);
    public void PrintText(IMessage message);
    public void ColorText(IMessage message);
}