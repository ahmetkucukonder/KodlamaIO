using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();
            //customerManager.Update();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();
            //employeeManager.Update();

            //IPersonManager internManager = new EmployeeManager();
            //internManager.Add();
            //internManager.Update();

            ProjectManager projectManager = new ProjectManager();

            projectManager.Add(new CustomerManager());
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());
            projectManager.Update(new CustomerManager());
            projectManager.Update(new EmployeeManager());
            projectManager.Update(new InternManager());
        }
    }
}
