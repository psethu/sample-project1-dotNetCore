using DatabaseAccessLibrary;
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
            decimal fare = ride.getFare();

            Assert.IsTrue(fare>=0);
        }

        [TestMethod]
        public void FareCalculation()
        {
            TaxiRideModel ride = new TaxiRideModel();
            ride.Miles = 2;
            ride.Minutes = 5;
            ride.CalculateFare();
            decimal fare = ride.getFare();

            Assert.IsTrue(fare==9.75m);
        }
    }
}
