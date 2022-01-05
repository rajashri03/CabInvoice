using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoice;

namespace CabInvoiceTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Step 1-Calculate Fare
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
    }
}