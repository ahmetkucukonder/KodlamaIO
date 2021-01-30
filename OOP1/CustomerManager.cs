using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.firstName + " Adlı müşteri başarıyla eklendi!");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.id + " ID'li müşteri başarıyla silindi!");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.firstName + " Adlı müşteri başarıyla güncellendi!");
        }
    }
}
