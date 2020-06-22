using System;

namespace DatabaseAccessLibrary.Models
{
    public class TaxiRideModel
    {
        /// <summary>
        /// unique identifier for the taxi ride
        /// </summary>
        /// 
        public int Id { get; set; }

        public TaxiFareModel TaxiFare { get; set; }

        public DateTime Date { get; set; }

        public int Minutes { get; set; }

        public int Miles { get; set; }

    }
}
