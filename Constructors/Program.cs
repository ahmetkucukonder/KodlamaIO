using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Default Constructor
            Customer customer = new Customer { 
                Id = 0,
                FirstName = "Ahmet",
                LastName = "Kucukonder",
                City = "Kahramanmaras"
            };

            //Advanced Constructor
            Customer customer2 = new Customer(1, "Engin", "Demirog", "Ankara");

            //Outputs
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer2.FirstName);
        }

        class Customer
        {
            //Default Constructor
            public Customer()
            {

            }

            //Advanced Constructor
            public Customer(int id, string firstName, string surName, string city)
            {
                Id = id;
                FirstName = firstName;
                LastName = surName;
                City = city;
            }

            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }
        }
    }
}
