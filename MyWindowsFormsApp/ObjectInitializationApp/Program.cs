using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWindowsFormsApp.Model.Model;
namespace ObjectInitializationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize Object

            //Using Object
            Employee employee = new Employee();

            employee.Id = 1;
            employee.Name = "Ali";
            employee.Address = "Mirpur";

            Console.WriteLine("Id: "+ employee.Id + " Name: " + employee.Name + " Address: "+ employee.Address) ;

            //Using Contructor
            Employee employee2 = new Employee(2, "Mehedi", "Mogbazar");
            Console.WriteLine("Id: " + employee2.Id + " Name: " + employee2.Name + " Address: " + employee2.Address);

            //Initializer
            Employee employee3 = new Employee()
            {
                Id = 3,
                Name = "Milon",
                Address = "Mirpur"
            };
            Console.WriteLine("Id: " + employee3.Id + " Name: " + employee3.Name + " Address: " + employee3.Address);

            List<Employee> employees = new List<Employee>()
            {
                //new Employee(){Id = 1,Name = "Ali",Address = "Mirpur"}
                employee, //employees.Add(employee);
                new Employee() {Id = 2,Name = "Hasan",Address = "Mirpur"}

            };

            foreach (Employee emp in employees)
            {
                Console.WriteLine("Id: " + emp.Id + " Name: " + emp.Name + " Address: " + emp.Address);
            }
            
            Console.ReadKey();
        }
    }
}
