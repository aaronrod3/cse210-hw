using System;


// this class will contain the address and tell if in USA or not
// return address as string
public class Address
{
    private string _street;
    private string _city;
    private string _stateorprov;
    private string _country;

    public Address(string street, string city, string stateorprov, string country)
    {
        _street = street;
        _city = city;
        _stateorprov = stateorprov;
        _country = country;
    }

    public void shippingLabel()
    {
        Console.WriteLine($"{_street}\n{_city}, {_stateorprov}, {_country}");
    }

    public bool country()
    {
        if(_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}