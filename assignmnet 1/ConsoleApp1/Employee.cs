using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Employee
{
    int id;
    string name;
    string dept;
    decimal salary;
    string manager;
    string company;
    public void GetDetails()
    {
        Console.WriteLine("ENter Id");
        id = Byte.Parse(Console.ReadLine());
        Console.WriteLine("ENter NAme");
        name = Console.ReadLine();
        Console.WriteLine("ENter Dept");
        dept = Console.ReadLine();
        Console.WriteLine("ENter Manager");
        manager = Console.ReadLine();
        Console.WriteLine("ENter Company");
        company = Console.ReadLine();
        Console.WriteLine("ENter Salary");
        salary = Convert.ToDecimal(Console.ReadLine());
    }
    public void DisplayDetails()
    {

        Console.WriteLine("ID is {0}", id);
        Console.WriteLine("NAme is {0}", name);
        Console.WriteLine("Dept is {0}", dept);
        Console.WriteLine("Manager is {0}", manager);
        Console.WriteLine("COmpmay is {0}", company);
        Console.WriteLine("Salary is {0}", salary);

    }
   
    public static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp.GetDetails();
        emp.DisplayDetails();
    }

}