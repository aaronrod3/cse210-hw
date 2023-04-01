using System;

public class Address
{
    private string _address;

    public Address(string address)
    {
        _address = address;
    }

    public string getAddress()
    {
        return _address;
    }
}