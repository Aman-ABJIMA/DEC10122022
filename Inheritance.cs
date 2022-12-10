using System;
namespace Inharitance
{
    public class Base
    {
        public static string employeeName;
        public static int employeeID;  

        public static double salary;
        public static int workingHours;
        public static double bonus = 300;
        public static int perHours = 1200;

        public static void Add()
        {
            Console.WriteLine("Enter Employee Name:");
            employeeName = Console.ReadLine();
            Console.WriteLine("Enter ID:");
            employeeID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter No. of Hours Worked");
            workingHours = Convert.ToInt32(Console.ReadLine());

        }

       
    }
    public class Sub : Base
    {
       static double Calculate()=>
       salary = (workingHours * perHours) + bonus;
        

       static void Display() =>
       Console.WriteLine("Employee Name:" + employeeName + "\nEmployee ID:" + employeeID+ "\nSalary:" + salary);

        public static void Main(string[] args)
        {
            

            Add();
            salary=Calculate();
            Console.Clear();
            Display();
        }
    }
}
