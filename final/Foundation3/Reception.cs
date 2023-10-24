using System;

public class Reception : Event
{
    private string _email;

    public Reception(string email) : base("Reception Event")
    {
        _email = email;
    }
}