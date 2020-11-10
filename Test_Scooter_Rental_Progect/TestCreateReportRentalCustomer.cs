using NUnit.Framework;
using Rhino.Mocks;
using Scooter_Rental_Progect;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Scooter_Rental_Progect
{
    [TestFixture]
    class TestCreateReportRentalCustomer
    {
        [Test]
        public void Test_Create_SimpleReport()
        {
            MockRepository mockRepository = new MockRepository();
            var mockObject = mockRepository.DynamicMock<TextWriter>();
            TextWriterFactory.SetTextWriter(mockObject);

            using (mockRepository.Record())
            {
                mockObject.Write("Something");
                LastCall.Constraints(new Rhino.Mocks.Constraints.Contains("Client report Name: TestCustomer") &
                                     new Rhino.Mocks.Constraints.Contains("Scooter rent Name: TestName") &
                                     new Rhino.Mocks.Constraints.Contains("Scooter type: Honda") &
                                     new Rhino.Mocks.Constraints.Contains("Price rent coast: 7") &
                                     new Rhino.Mocks.Constraints.Contains("Days rent: 6") &
                                     new Rhino.Mocks.Constraints.Contains("Total rent coast: 42") &
                                     new Rhino.Mocks.Constraints.Contains("Total customer dept: 42"));

            }
            Customer customer = new Customer("TestCustomer");
            customer.Rentals.Add(new Rental(Scooter.Honda("TestName"), 6));
            ReportManager.CreateSimpleReport("SomePath", customer);
            mockRepository.VerifyAll();


        }
    }
}
