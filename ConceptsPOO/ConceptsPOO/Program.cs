using System;
using System.Collections.Generic;

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
            //Console.WriteLine(employee1);

            Employee employee2 = new CommissionEmployee()
            {
                Id = 2020,
                FirstName = "Carolina",
                LastName = "Ibarguen",
                BirthDate = new Date(1996, 12, 9),
                HiringDate = new Date(2017, 5, 25),
                IsActive = true,
                CommissionPercentaje = 0.03F,
                Sales = 320000000M
            };
            //Console.WriteLine(employee2);

            Employee employee3 = new HourlyEmployee()
            {
                Id = 3030,
                FirstName = "Marcela",
                LastName = "Marin",
                BirthDate = new Date(1981, 10, 7),
                HiringDate = new Date(2015, 6, 15),
                IsActive = true,
                HourValue = 12356.56M,
                Hours = 123.5F
            };
            //Console.WriteLine(employee3);

            Employee employee4 = new BaseCommissionEmployee()
            {
                Id = 4040,
                FirstName = "Julio",
                LastName = "Villegas",
                BirthDate = new Date(1976, 8, 9),
                HiringDate = new Date(2016, 1, 29),
                IsActive = true,
                Base = 860678.45M,
                CommissionPercentaje = 0.015F,
                Sales = 58000000,
            };
            //Console.WriteLine(employee4);

            ICollection<Employee> employees = new List<Employee>()
            {
                employee1, employee2, employee3, employee4
            };

            decimal payroll = 0;

            foreach (Employee employee in employees) 
            {
                Console.WriteLine(employee);
                payroll += employee.GetValueToPay();
            }

            Console.WriteLine("                                  ===============");
            Console.WriteLine($"TOTAL:                         {$"{payroll:C2}", 18}");

            Invoice invoice1 = new Invoice()
            {
                Description = "iPhone 13",
                Id = 1,
                Price = 5300000M,
                Quantity = 6
            };

            Invoice invoice2 = new Invoice()
            {
                Description = "Carne",
                Id = 2,
                Price = 32000M,
                Quantity = 17.5F
            };

            Console.WriteLine(invoice1);
            Console.WriteLine(invoice2);
        }
    }
}

