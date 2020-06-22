
using DatabaseAccessLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModelsTest
{
    [TestClass]
    public class TaxiFareModelTest
    {
        [TestMethod]
        public void FareNotNegative()
        {
            TaxiRideModel ride = new TaxiRideModel();
            decimal fare = ride.TaxiFare.Total;

            Assert.IsTrue(fare>=0);
        }

        [TestMethod]
        public void FareCalculation()
        {
            SurchargePeakModel surcharge;

            TaxiRideModel ride = new TaxiRideModel
            {
                Miles = 2,
                Minutes = 5
            };

            ride.TaxiFare.calculate();
            decimal fare = ride.getFare();

            Assert.IsTrue(fare==9.75m);
        }
    }
}
