using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.EndPointUser;
using Itmo.ObjectOrientedProgramming.Lab3.Filter;
using Itmo.ObjectOrientedProgramming.Lab3.MessageLogger;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.MessageTopic;
using NSubstitute;
using Xunit;
namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class TestMessagesNotSuitableInImportance
{
    [Fact]
    public void MockTestMessagesNotSuitableInImportance()
    {
        IMessage message = Substitute.For<IMessage>();
        message.LevelOfImportance.Returns(2);
        var user = new User("Artem");
        var addressee = new RecipientUser(user);
        var filer = new FilterProxy(addressee, 1);
        IRecipient logger = Substitute.For<ConsoleLogger>(addressee);
        var topic = new Topic(logger, filer);
        topic.Send(message);
        logger.Received(0).SendMessage(message);
    }
}