using System;

// Auto implemented properties
namespace Properties
{
    class Employee
    {
        public int Eno
        {
            get;
            set;
        }

        public string Ename
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Eno = 1001;
            employee.Ename = "Ashok";

            Console.WriteLine("{0} \t {1}", employee.Eno, employee.Ename);
        }
    }
}
