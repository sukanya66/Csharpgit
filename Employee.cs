using System;
namespace Properties
{
    class Employee
    {public int Id{get;set;}
    public string Name{get;set;}
    public double Salary{get;set;}
    public override string ToString()
    {
        return $"{Id}\t{Nmae}\t{Salary}";
    }

    }
}