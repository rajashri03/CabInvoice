using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoice;

namespace CabInvoiceTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Step 1-Calculate Fare for single ride
        /// </summary>
        [TestMethod]
        public void CalculateFare_ShouldReturnTotalFare()
        {
            //Arrance
            InvoiceGenerator invoice = new InvoiceGenerator();
            double fare = invoice.CalculateFare(2.0, 5);
            int expected_fare = 25;
            //Assert
            Assert.AreEqual(expected_fare, fare);
        }
        /// <summary>
        /// TestMethod to calculate fare for multiple rides
        /// </summary>
        [TestMethod]
        public void GivenMultipleRides_ShouldReturnTotalFare()
        {
            //Arrange
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            Rides[] rides = { new Rides(2.0, 5), new Rides(1, 1) };
            double fare = invoiceGenerator.CalculateFare(rides);
            int numofride = 2;
            double expectedtotalfare = 36;
            double avg = expectedtotalfare / numofride;
            System.Console.WriteLine("Avg:"+avg);
            //Assert
            Assert.AreEqual(expectedtotalfare, fare);
        }
    }
}