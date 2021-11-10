using System;
namespace Demo
{
    class Employee
    {
        int _eno;
        string _ename;
        public int Eno
        {
            get
            {
                return _eno;
            }
            set
            {
                _eno = value+1;
            }
        }
            public string Ename
        {
            get { return _ename; }
            set { _ename = value+"1" ; }
        }
        
    }
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee();
            employee.Eno = 101;
            employee.Ename = "hema";
            Console.WriteLine("{0} \t {1}",employee.Eno,employee.Ename);
        }
    }
}