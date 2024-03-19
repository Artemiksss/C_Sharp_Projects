namespace Itmo.ObjectOrientedProgramming.Lab3.DisplayDriver;

public class ColorRGB
{
    public ColorRGB(byte red, byte green, byte blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }

    public byte Red { get; private set; }
    public byte Green { get; private set; }
    public byte Blue { get; private set; }
}