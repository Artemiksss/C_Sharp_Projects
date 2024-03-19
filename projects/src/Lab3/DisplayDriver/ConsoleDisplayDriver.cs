using System;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using static Crayon.Output;
namespace Itmo.ObjectOrientedProgramming.Lab3.DisplayDriver;

public class ConsoleDisplayDriver : IConsoleDisplayDriver
{
    private ColorRGB _color;

    public ConsoleDisplayDriver()
    {
        _color = new ColorRGB(0, 0, 0);
    }

    public static void ClearConsole()
    {
        Console.Clear();
    }

    public void PrintText(IMessage message)
    {
        Console.Clear();
        Console.WriteLine($"Header: {message.Header}; Body: {message.Body}");
    }

    public void SetColor(ColorRGB color)
    {
        _color = color;
    }

    public void ColorText(IMessage message)
    {
        Console.Clear();
        Console.WriteLine(Rgb(_color.Red, _color.Green, _color.Blue).Text(message.Header + message.Body));
    }
}