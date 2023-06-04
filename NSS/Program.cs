using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NSS
{
    //Non-Standard Soccer
    internal class Program: Employee
    {     
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.Head();

            Console.ReadKey();
        }
    }
}
