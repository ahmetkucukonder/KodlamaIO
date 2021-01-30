using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                id = 0,
                age = 19,
                firstName = "Ahmet",
                surName = "Kucukonder",
            };

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer);
            customerManager.Delete(customer);
            customerManager.Update(customer);
        }
    }
}
