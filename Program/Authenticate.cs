using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

internal class Authenticate
{
    private Persistence persistence;

    public Authenticate(Persistence persistence)
    {

    }

    public bool Execute(string email, string password)
    {

    }

    public void Find(string email)
    {
        
    }

    public bool Exists(string email)
    {
        int count = 0;

        while (persistence.users[count] != null)
        {
            if (persistence.users[count].Email == email)
            {
                return true;
            }
        }

        return false;
    }
}
