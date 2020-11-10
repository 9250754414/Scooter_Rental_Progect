using NUnit.Framework;
using Scooter_Rental_Progect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Scooter_Rental_Progect
{
    [TestFixture]
    class TestCreateCustomer
    {
        [Test]
        public void Test_CalculateDeptCustomer()
        {
            Customer customer = new Customer("Nick");
            customer.Rentals.Add(new Rental(Scooter.BMW("RX250"), 4));
            customer.Rentals.Add(new Rental(Scooter.Honda("M80"), 3));
            Assert.AreEqual(customer.CalculateDept(), 12 * 4 + 7 * 3); 
        }
    }
}
