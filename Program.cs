using System;

namespace MyApp
{
    public class Session3
    {
        
        public static void Main()
        {
            PermanentEmployee permanentEmployee = new PermanentEmployee()
            {
                Id = 1,
                Name = "ABC"
            };

            ContractEmployee contractEmployee = new ContractEmployee()
            {
                Id = 2,
                Name = "XYZ"
            };




            permanentEmployee.PrintEmployeeDetails();
            contractEmployee.PrintEmployeeDetails();

        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual  void PrintEmployeeDetails()
        {
            Console.WriteLine($"Employee Name is {Name} and Id {Id}");
        }
        
    }

    public class PermanentEmployee : Employee
    {
        public override void PrintEmployeeDetails()
        {
            Console.WriteLine($"Employee Name is {Name} and Id {Id}. Employee is permanent emp.");
        }
    }
    public class ContractEmployee : Employee
    {
       
    }




}
