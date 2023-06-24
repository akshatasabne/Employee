using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class EmployeeDetails
    {
        int emp_id;
        string name;
        double salary;

        ////public void getdata(int a,string b,double c)
        ////{
        ////    emp_id = a;
        ////    name = b;
        ////    salary = c;
        ////}
            public EmployeeDetails() 
        { 
            emp_id = 1;
            name = "Akshata";
            salary = 45000;
        }
        //public string putdata()
        //{
        //    return $" Employee Info {emp_id}/{name}/{salary}";
        //}
        public EmployeeDetails(int a,string b,double c)
        {
            emp_id = a;
            name = b;
            salary = c;

        }
        public string printdata()
        {
            return $"  emp_id - {emp_id}\n  Name - {name} \n   Salary - {salary}";
        }

    }
}
