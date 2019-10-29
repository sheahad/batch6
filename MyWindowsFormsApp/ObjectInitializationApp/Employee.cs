using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializationApp
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Employee()
        {
        }

        public Employee(int id, string name, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
        }
    }
}
