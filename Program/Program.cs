using Scooter_Rental_Progect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Nick");
            customer.Rentals.Add(new Rental(Scooter.BMW("FX300"), 4));
            customer.Rentals.Add(new Rental(Scooter.Honda("M250"), 4));
            customer.Rentals.Add(new Rental(Scooter.Suzuki("RX5"), 5));
            var result = customer.CalculateDept();
            Console.WriteLine($"Client {customer.Name}. Dept - {result}");

            ReportManager.CreateSimpleReport(@"D:\\ReportTest.txt", customer);
        }
    }
}
