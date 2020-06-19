using System;

namespace DatabaseAccessLibrary
{
    public class TaxiRideModel
    {
        /// <summary>
        /// unique identifier for the taxi ride
        /// </summary>
        /// 
        internal int Id { get; set; }

        public bool InNY { get; set; }

        private TaxiFareModel TaxiFare;

        public DateTime Date { get; set; }

        public int Minutes { get; set; }

        public int Miles { get; set; }

        public TaxiRideModel()
        {
            InNY = false;
            // passing ride so that fare has a link to the same ride
            TaxiFare = new TaxiFareModel(this);
        }

        public decimal getFare()
        {
            return TaxiFare.GetAmount();
        }

        public void CalculateFare()
        {
            TaxiFare.calculate();
        }

        //TODO - Implement logic if night surcharge required using Date
        public decimal Surcharge()
        {
            return 0.50m;
        }

        //TODO - Implement logic if peak hour charge required using Date
        public decimal PeakHourCharge()
        {
            return 1.00m;
        }


        //TODO - this method uses the location of the client's request to determine if a client is in NY
        public void VerifyLocation(Object ClientRequest)
        {
            InNY = true;
        }

        public decimal getNYFee()
        {
            if (InNY)
                return 0.50m;
            else
                return 0.0m;
        }

    }
}
