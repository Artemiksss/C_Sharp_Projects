using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.EndPointUser;
using Itmo.ObjectOrientedProgramming.Lab3.Filter;
using Itmo.ObjectOrientedProgramming.Lab3.MessageLogger;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.MessageTopic;
using NSubstitute;
using Xunit;
namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class TestCheckingLogging
{
    [Fact]
    public void MockTestMessagesNotSuitableInImportance()
    {
        IMessage message = Substitute.For<IMessage>();
        message.LevelOfImportance.Returns(1);
        var user = new User("Artem");
        var addressee = new RecipientUser(user);
        IRecipient logger = Substitute.For<ConsoleLogger>(addressee);
        var filer = new FilterProxy(logger, 1);
        var topic = new Topic(logger, filer);
        topic.Send(message);
        logger.Received(1).SendMessage(message);
    }
}