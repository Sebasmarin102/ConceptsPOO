using System;

namespace ConceptsPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POO Concepts");
            Console.WriteLine("============");

            Employee employee1 = new SalaryEmployee()
            {
                Id = 1010,
                FirstName = "Sebastian",
                LastName = "Posada",
                BirthDate = new Date(1999, 9, 2),
                HiringDate = new Date(2020, 8, 31),
                IsActive = true,
                Salary = 1350000.45M
            };
            Console.WriteLine(employee1);

            Employee employee2 = new CommissionEmployee()
            {
                Id = 2020,
                FirstName = "Carolina",
                LastName = "Ibarguen",
                BirthDate = new Date(1996, 12, 9),
                HiringDate = new Date(2017, 5, 25),
                IsActive = true,
                CommissionPercentaje = 0.03f,
                Sales = 320000000M
            };
            Console.WriteLine(employee2);
        }
    }
}

