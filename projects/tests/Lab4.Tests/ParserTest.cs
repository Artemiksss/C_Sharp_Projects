using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser;
using Xunit;
namespace Itmo.ObjectOrientedProgramming.Lab4.Tests;

public class ParserTest
{
    [Theory]
    [MemberData(nameof(DataForParser.TestData), MemberType = typeof(DataForParser))]
    public void TestingParsingCommand(string commandOne, string commandTwo, string commandThree, string commandFour, string commandFive, string commandSix)
    {
        bool result = false;
        bool extendedResult = true;
        var parser = new Parser(1);
        parser.Parsing(commandOne);
        parser.Parsing(commandOne);
        if (CommandHandler.Commands.First() == "Connected")
        {
            CommandHandler.Commands.Remove(CommandHandler.Commands.First());
            result = true;
        }

        parser.Parsing(commandTwo);
        if (CommandHandler.Commands.First() == "/Users/artemzovnir/Lab4/Fold2/FileTwo.txt")
        {
            CommandHandler.Commands.Remove(CommandHandler.Commands.First());
            result = true;
        }

        parser.Parsing(commandThree);
        if (CommandHandler.Commands.First() == "/Users/artemzovnir/Lab4/Fold2/FileTwo.txt /Users/artemzovnir/Lab4/Fold1/FileTwo.txt")
        {
            CommandHandler.Commands.Remove(CommandHandler.Commands.First());
            result = true;
        }

        parser.Parsing(commandFour);
        if (CommandHandler.Commands.First() == "/Users/artemzovnir/Lab4/Fold1/FileOne.txt /Users/artemzovnir/Lab4/Fold2/FileOne.txt")
        {
            CommandHandler.Commands.Remove(CommandHandler.Commands.First());
            result = true;
        }

        parser.Parsing(commandFive);
        if (CommandHandler.Commands.First() == "/Users/artemzovnir/Lab4/Fold2/FileOne.txt")
        {
            CommandHandler.Commands.Remove(CommandHandler.Commands.First());
            result = true;
        }

        parser.Parsing(commandSix);
        if (CommandHandler.Commands.First() == "/Users/artemzovnir/Lab4/Fold2/FileTwo.txt NewFileTwo.txt")
        {
            CommandHandler.Commands.Remove(CommandHandler.Commands.First());
            result = true;
        }

        Assert.Equal(extendedResult, result);
    }
}