using System;

namespace Interfaces
{
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee successfully added!");
        }

        public void Update()
        {
            Console.WriteLine("Employee successfully updated");
        }
    }
}
