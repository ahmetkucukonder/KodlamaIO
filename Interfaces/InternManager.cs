using System;

namespace Interfaces
{
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern successfully added!");
        }

        public void Update()
        {
            Console.WriteLine("Intern successfully updated!");
        }
    }
}
