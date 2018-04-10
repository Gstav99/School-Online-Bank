using System;

namespace School_Online_Bank_FrameWork
{
    [Serializable]
    public class Customer
    {
        string firstName;
        string lasName;
        long id;
        //IAccount accounts;
        string passwordHash;
    }
}