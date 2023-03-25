using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Address
{
    public Address(string name, string surname, string street, string city, string province, string zIP)
    {
        Name = name;
        Surname = surname;
        Street = street;
        City = city;
        Province = province;
        ZIP = zIP;
    }
    public Address(string? name, string? surname, string? secondName, string street, string city, string province, string zIP)
    {
        Name = name;
        Surname = surname;
        SecondName = secondName;
        Street = street;
        City = city;
        Province = province;
        ZIP = zIP;
    }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string SecondName { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string ZIP { get; set; }
}
