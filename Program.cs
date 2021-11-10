using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
            Employee employee =new Employee(Id=1001,nameof="Ashok",Salary=98000);
            Console.WriteLine(employee);
            List<Employee> employees= new List<Employee>
            {
             new Employee{Id=1002,Name="mouni",Salary=45000},
             new Employee{Id=1002,Name="Rahul",Salary=55000}
            };
            foreach(Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        
    }
}