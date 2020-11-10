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
    class TestScooterRental
    {
        [Test]
        public void Test_CalculateDeptRental()
        {
            Rental rental = new Rental(Scooter.Honda("RX80"), 6);
            Assert.AreEqual(rental.CalculateDept(), 42);
        }
        [Test] 
        public void Test_AddRentalDays()
        {
            Rental rental = new Rental(Scooter.Honda("RX80"), 3);
            rental.AddDays(3);
            Assert.AreEqual(rental.CalculateDept(), 7 * 6);
            rental.AddDays(2);
            Assert.AreEqual(rental.CalculateDept(), 7 * 8);
        }
        [Test]
        public void Test_SubstractionRentalDays()
        {
            Rental rental = new Rental(Scooter.Honda("RX80"), 9);
            rental.SubtractionDays(3);
            Assert.AreEqual(rental.CalculateDept(), 7 * 6);
            rental.SubtractionDays();
            Assert.AreEqual(rental.CalculateDept(), 7 * 5);
        }
        [Test]
        public void Test_CreateRentalDaysException()
        {
            try
            {
                Rental rental = new Rental(Scooter.Suzuki("M100"), -5);
                Assert.Fail();
            }
            catch (ArgumentDaysException e)
            {
                Assert.AreEqual(e.Days, -5);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
        [Test]
        public void Test_SubstractionDaysException()
        {
            try
            {
                Rental rental = new Rental(Scooter.Suzuki("M100"), 5);
                rental.SubtractionDays(6);
                Assert.Fail();
            }
            catch (ArgumentDaysException e)
            {
                Assert.AreEqual(e.Days, -1);
            }
            catch (Exception)
            {
                Assert.Fail();
            }


        }
    }
}
