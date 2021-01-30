using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class ProjectManager
    {
        public void Add(IPersonManager person)
        {
            person.Add();
        }
        public void Update(IPersonManager person)
        {
            person.Update();
        }
    }
}
