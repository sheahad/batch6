using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWindowsFormsApp.Model.Model;

namespace ImplicitlyTypedLocalVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num; num = 10;
            num = 20;
            var num2 = 10;
            num2 = 20;
            num2 = "";

            string name = "Ali";
            name = "";
            var name2 = "Kamal";
            name2 = "";

            var employee = new Employee();
            var employees =  new List<Employee>();

        }
    }
}
