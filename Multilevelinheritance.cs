using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSecondApplication
{
    enum Feedback
    {
        Poor=1,Fair,Good=4,Excellent
    };

    //Base or Parent Class
    class Department
    {
        //protected is used within the class and only in derived class
        protected int Did { get; set; }
        protected string Dname { get; set; }
        protected string City { get; set; }

        internal Department(int Did, string Dname, string City)
        {
            Console.WriteLine("Department Constructor");
            this.Did = Did;
            this.Dname = Dname;
            this.City = City;
        }

        protected internal void DisplayDeptInfo()
        {
            Console.WriteLine($"{Did} {Dname} {City}");
        }
        ~Department()
        {
            Console.WriteLine("Department Destructor");
        }

    }

    class Employee :Department
    {
        internal static string CompanyName = "LTI";
        internal int Eid { get; set; }
        internal string Name { get; set; }

        internal string City = "Pune";

        internal Employee(int Eid, string Name,int Did, string Dname, string City) : base(Did, Dname, City)
        {
            Console.WriteLine("Employee Constructor");
            this.Eid = Eid;
            this.Name = Name;
        }

        protected internal void DisplayEmployeeInfo()
        {
            DisplayDeptInfo();
            Console.WriteLine($"Dept City {base.City}");
            Console.WriteLine($"{Eid} {Name} {(int)Feedback.Excellent}");
            Console.WriteLine($"Employee City {City}");
        }
        ~Employee()
        {
            Console.WriteLine("Employee Destructor");
        }
    }

    class PartTimeEmployee : Employee
    {
        internal int hoursofwork { get; set; }
        internal int salary { get; set; }
        internal PartTimeEmployee(int Eid, string Name, int Did,string Dname, string City,int hoursofwork,int salary):base(Eid,Name,Did,Dname,City)
        {
            this.hoursofwork = hoursofwork;
            this.salary = salary;
        }
        internal int MonthlySalary()
        {
            int Payment = hoursofwork * 30 * salary;
            return Payment;
        }
      
        ~PartTimeEmployee()
        {
            Console.WriteLine("PartTimeEmployee Destructor");
        }
    }
    class Multilevelinheritance
    {
        static void Main()
        {
            //Employee employee = new Employee(1,"Mihir",101,"IT","Mumbai");
            //employee.DisplayEmployeeInfo();
            //employee.DisplayDeptInfo();

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee(1, "Mihir", 101, "IT", "Mumbai", 20, 1000);
            partTimeEmployee.DisplayEmployeeInfo();
            Console.WriteLine(partTimeEmployee.MonthlySalary()); 

            GC.Collect();
        }
    }
}
