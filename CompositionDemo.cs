using System;
namespace CompositionDemo
{
    class Address{
    public string Street { get; set; }
    public string City { get; set; }
    public string Country { get; set; }

    public Address(string street, string city, string country)
    {
        Street = street;
        City = city;
        Country = country;
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"Address: {Street}, {City}, {Country}");
    }
}

class Person
{
    public string Name { get; set; }
    public Address CurrentAddress { get; set; } // Address as a component

    public Person(string name, Address address)
    {
        Name = name;
        CurrentAddress = address;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        CurrentAddress.DisplayAddress();
    }
}

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Creating an Address instance
//         Address personAddress = new Address("hetauda", "bagmati", "nepal");

//         // Creating a Person and assigning the Address
//         Person person = new Person("John", personAddress);

//         // Displaying Person's information including the Address
//         person.DisplayInfo();
//     }
// }
    
}
