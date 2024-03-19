using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.EndPointUser;
using Itmo.ObjectOrientedProgramming.Lab3.Filter;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.MessageTopic;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class TestChangingStatusMessage
{
    [Fact]
    public void TestMessageStatus()
    {
        var message = new Message("Test", "Text for test", 1);
        var user = new User("Artem");
        var addressee = new RecipientUser(user);
        var filer = new FilterProxy(addressee, 1);
        var topic = new Topic(addressee, filer);
        topic.Send(message);
        bool result = false;
        bool expectedStatusTheMessage = true;
        user.Read(message);
        if (user.Messages[0].GetMessageStatus == MessageStatus.Read)
        {
            result = true;
        }

        Assert.Equal(result, expectedStatusTheMessage);
    }
}