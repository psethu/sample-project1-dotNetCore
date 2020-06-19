
using System;


namespace DatabaseAccessLibrary
{
    public class TaxiFareModel : FareBaseModel
    {
        /// <summary>
        /// unique identifier for the taxi fare
        /// </summary>
        public int Id { get; set; }

        private decimal Amount { get; set; }

        public override decimal calculate(TaxiRideModel ride)
        {
            decimal amt_miles = ride.Miles * Constants.MileMultiplier * Constants.UnitFee; 
            decimal amt_minutes = Constants.UnitFee * ride.Minutes;
            
            return Constants.EntryFee + 
                   amt_miles +
                   amt_minutes +
                   ride.Surcharge() +
                   ride.PeakHourCharge() +
                   ride.getNYFee() 
           ;
        }
    }
}
