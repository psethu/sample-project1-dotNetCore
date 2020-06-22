
using DatabaseAccessLibrary.Models;
using System;
using System.Collections.Generic;

namespace DatabaseAccessLibrary
{
    public class TaxiFareModel
    {
        /// <summary>
        /// unique identifier for the taxi fare
        /// </summary>
        public int Id { get; set; }

        public decimal Total { get; set; }

        public TaxiRideModel TaxiRide { get; set; }

        public List<SurchargeBaseModel> Surcharges { get; set; }
        

        public TaxiFareModel(TaxiRideModel ride)
        {
            this.TaxiRide = ride;
        }

        public void Calculate()
        {
            decimal amtMiles = TaxiRide.Miles * Constants.MileMultiplier * Constants.Unit; 
            decimal amtMinutes = Constants.Unit * TaxiRide.Minutes;
            decimal totalSurcharge = 0.0m;

            foreach (SurchargePodModel charge in Surcharges)
            {
                totalSurcharge += charge.Amount;
            }

            Total = Constants.Entry
                + amtMiles
                + amtMinutes
                + totalSurcharge
           ;
        }
    }
}
