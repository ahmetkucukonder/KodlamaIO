using System;

namespace ClassMethods
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            //Some DB processes..
            Console.Write("Customer succesfully added! !\nID: " + customer.id + " Firstname Lastname: " + customer.name + " " + customer.surName);
        }
        public void RemoveCustomer(Customer customer)
        {
            //Some DB processes..
            Console.Write("\n\nCustomer succesfully deleted!\nID: " + customer.id + " Firstname Lastname: " + customer.name + " " + customer.surName);
        }
        public void CustomerList(Customer[] customers)
        {
            //Some DB processes..
            Console.WriteLine("\n\nCustomers:");
            foreach (Customer customer in customers)
            {
                Console.WriteLine("ID: " + customer.id + "\nFirstname Lastname: " + customer.name + " " + customer.surName + "\n");
            }

        }
    }
}
