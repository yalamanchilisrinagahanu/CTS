using System;

public class EmailService : IMessageService
{
    public void Send()
    {
        Console.WriteLine("Email Sent");
    }
}
