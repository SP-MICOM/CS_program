using System;
using System.Collections.Generic;
using System.Text;

internal class Persistence
{
    public List<User> users = new List<User>();

    public void Save(User user)
    {
        users.Add(user);
    }
}
