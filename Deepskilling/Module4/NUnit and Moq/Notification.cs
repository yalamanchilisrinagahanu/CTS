public class Notification
{
    private readonly IMessageService service;

    public Notification(IMessageService service)
    {
        this.service = service;
    }

    public void Notify()
    {
        service.Send();
    }
}
