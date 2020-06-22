
using DatabaseAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DatabaseAccessLibrary.Models
{
    public class TaxiFareModel
    {
        /// <summary>
        /// unique identifier for the taxi fare
        /// </summary>
        public int Id { get; set; }

        public decimal Total { get; set; } = 0.0m;

        public List<SurchargeBaseModel> Surcharges { get; set; }

        public TaxiFareModel()
        {
        }

        public TaxiFareModel(List<SurchargeBaseModel> surCharges)
        {
            this.Surcharges = surCharges;
        }

        public void Calculate(TaxiRideModel TaxiRide)
        {
            if (TaxiRide.Miles == 0 && TaxiRide.Minutes == 0)
            {
                Total = 0.0m;
                return;
            }

            decimal amtMiles = TaxiRide.Miles * Constants.MileMultiplier * Constants.Unit; 
            decimal amtMinutes = Constants.Unit * TaxiRide.Minutes;
            decimal totalSurcharge = 0.0m;

            // need this check because foreach causes null ptr exception if array does not exist
            if (Surcharges != null)
            {
                foreach (SurchargeBaseModel charge in Surcharges)
                {
                    totalSurcharge += charge.Amount;
                }
            }

            Total = Constants.Entry
                + amtMiles
                + amtMinutes
                + totalSurcharge
           ;
        }
    }
}
