using NUnit.Framework;
using Moq;

[TestFixture]
public class NotificationTests
{
    [Test]
    public void Notify_CallsSendMethod()
    {
        var mock =
            new Mock<IMessageService>();

        Notification notification =
            new Notification(mock.Object);

        notification.Notify();

        mock.Verify(
            x => x.Send(),
            Times.Once
        );
    }
}
