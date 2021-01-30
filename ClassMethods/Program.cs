using System;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customermanager = new CustomerManager();

            Customer customer = new Customer();
            customer.id = 0;
            customer.name = "Jordan";
            customer.surName = "Comolli";

            Customer customer2 = new Customer();
            customer2.id = 1;
            customer2.name = "Engin";
            customer2.surName = "Demirog";

            Customer customer3 = new Customer();
            customer3.id = 2;
            customer3.name = "Waren";
            customer3.surName = "Buffet";

            customermanager.AddCustomer(customer);
            customermanager.RemoveCustomer(customer2);

            Customer[] customers = new Customer[] { customer, customer2, customer3 };
            customermanager.CustomerList(customers);
        }
    }
}
