using Itmo.ObjectOrientedProgramming.Lab3.DisplayDriver;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.DisplayForMessage;

public interface IDisplay
{
    public void PrintColorText(ColorRGB color, IMessage message);
    public void PrintMessage(IMessage message);
}