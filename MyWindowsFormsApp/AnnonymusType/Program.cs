using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWindowsFormsApp.Model.Model;

namespace AnnonymusType
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee {Id = 1, Name = "Ali", Address = "Motijhil"};
            var employees = new List<Employee>()
            {
                new Employee(){ Id = 1, Name = "Ali", Address = "Motijhil" },
                new Employee(){ Id = 2, Name = "Alim", Address = "Mirpur" },
            };

            var customer =  new { Id = 1, Name = "Ali", Address = "Motijhil" };
            //customer.Id = 2;
            Console.WriteLine(customer.Name);

            var customers = new[]
            {
                new { Id = 1, Name = "Ali", Address = "Motijhil" },
                new { Id = 2, Name = "Alim", Address = "Mirpur" },
                new { Id = 3, Name = "Alif", Address = "Motijhil" }
            };

            int[] a = new[] {1, 2, 3};

            Show(customers);

            //dynamic dyObj = new ExpandoObject();
            //dyObj.Message = "AA";
            dynamic dyObj = new Employee();
            dyObj.Message = "AA";

            dyObj.Id=0;

            Console.ReadKey();
        }

        private static void Show(dynamic customers)
        {
            foreach (var cust in customers)
            {
                Console.WriteLine("Id: " + cust.Id + " Name: " + cust.Name + " Address: " + cust.Address);
            }
        }
    }
}
