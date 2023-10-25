using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProv;
    private bool _country;

    public void DisplayAddress()
    {
        if (_country)
        {
            Console.WriteLine($"{_street}, {_city}, {_stateProv}, {_country}.");
        }
        else
        {
            Console.WriteLine($"{_street}, {_city}, {_stateProv}, USA.");
        }
    }

    public bool IsUSA()
    {
        return _country;
    }

    public void NotUSA()
    {
        _country = true;
    }

    public void USA()
    {
        _country = false;
    }

    public Address(string street, string city, string stateProv, bool country)
    {
        _street = street;
        _city = city;
        _stateProv = stateProv;
        _country = country;
    }

    public Address(string street, string city, string stateProv)
    {
        _street = street;
        _city = city;
        _stateProv = stateProv;
        _country = false;
    }
}