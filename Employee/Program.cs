using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EmployeeDetails employeeDetails = new EmployeeDetails();
            //employeeDetails.getdata(101, "Akshata", 45000);
            //    String show = employeeDetails.putdata();
            //Console.WriteLine(show);
            EmployeeDetails details = new EmployeeDetails();
            Console.WriteLine(details.printdata());
            EmployeeDetails details1 = new EmployeeDetails(101,"Anjali",50000);
            Console.WriteLine(details1.printdata());
        }
    }
}
