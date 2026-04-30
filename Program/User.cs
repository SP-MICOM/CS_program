using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

internal class User
{
    public string email;
    public string password;

    public string Email { get { return email; } }

    public User(string email, string password)
    {
        this.email = email;
        this.password = password;
    }
}