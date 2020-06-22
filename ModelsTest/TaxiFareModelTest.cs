
using DatabaseAccessLibrary;
using DatabaseAccessLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ModelsTest
{
    [TestClass]
    public class TaxiFareModelTest
    {
        /// <summary>
        /// Check result without any mileage
        /// </summary>
        [TestMethod]
        public void FareNone()
        {

            TaxiFareModel TaxiFare = new TaxiFareModel();
            TaxiRideModel TaxiRide = new TaxiRideModel();
            TaxiRide.Miles = 0;
            TaxiRide.Minutes = 0;

            TaxiFare.Calculate(TaxiRide);

            Assert.IsTrue(TaxiFare.Total == 0.0m);
        }

        /// <summary>
        /// Check result without any surcharges
        /// </summary>
        [TestMethod]
        public void FareNoSurcharge()
        {
         
            TaxiFareModel TaxiFare = new TaxiFareModel();
            TaxiRideModel TaxiRide = new TaxiRideModel();
            TaxiRide.Miles = 2;
            TaxiRide.Minutes = 5;
            
            TaxiFare.Calculate(TaxiRide);
            
            Assert.IsTrue(TaxiFare.Total == 8.25m);
        }

        /// <summary>
        /// Check result with all surcharges
        /// </summary>
        [TestMethod]
        public void FareSurcharge()
        {
            List<SurchargeBaseModel> Surcharges = new List<SurchargeBaseModel>();

            Surcharges.Add(new SurchargePeakModel(PeakTime.Active));
            Surcharges.Add(new SurchargePodModel(PartOfDay.Night));
            Surcharges.Add(new SurchargeStateModel("NY"));

            foreach (SurchargeBaseModel charge in Surcharges)
            {
                charge.Calculate();
            }

            TaxiFareModel TaxiFare = new TaxiFareModel(Surcharges);
            TaxiRideModel TaxiRide = new TaxiRideModel()
            {
                Miles = 2,
                Minutes = 5
            };

            TaxiFare.Calculate(TaxiRide);

            Assert.IsTrue(TaxiFare.Total == 10.25m);
        }
    }
}
