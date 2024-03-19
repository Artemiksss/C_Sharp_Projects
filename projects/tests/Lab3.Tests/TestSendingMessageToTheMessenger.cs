using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.ConsoleMessenger;
using Itmo.ObjectOrientedProgramming.Lab3.Filter;
using Itmo.ObjectOrientedProgramming.Lab3.MessageLogger;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.MessageTopic;
using NSubstitute;
using Xunit;
namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class TestSendingMessageToTheMessenger
{
    [Fact]
    public void MockTestMessagesNotSuitableInImportance()
    {
        IMessage message = Substitute.For<IMessage>();
        message.LevelOfImportance.Returns(1);
        var messenger = new Messenger();
        var addressee = new RecipientMessenger(messenger);
        IRecipient logger = Substitute.For<ConsoleLogger>(addressee);
        var filer = new FilterProxy(logger, 1);
        var topic = new Topic(logger, filer);
        topic.Send(message);
        logger.Received(1).SendMessage(message);
    }
}