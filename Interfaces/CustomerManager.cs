using System;

namespace Interfaces
{
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer successfully added!");
        }

        public void Update()
        {
            Console.WriteLine("Customer successfully updated!");
        }
    }
}
