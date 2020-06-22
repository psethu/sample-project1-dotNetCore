using System;
using DatabaseAccessLibrary;

namespace DatabaseAccessLibrary.Models
{

    /// <summary>
    /// Surcharge for Peak hour using fixed numbers intsead of enums since peak hour is not expected to change often
    /// </summary>
    public class SurchargePeakModel : SurchargeBaseModel
    {
        public override decimal Amount { get; set; }

        public int PeakStart { get; set; } = 4;

        public int PeakEnd { get; set; } = 8;

        /// <summary>
        /// Charge $1.00 Monday - Friday between 4:00 PM exclusive and 8:00 PM exclusive
        /// </summary>
        public override void Calculate()
        {
            DateTime dt = DateTime.Now.ToLocalTime();

            if (dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)
                Amount = 0.0m;
            else
            {
                if (dt.Hour > PeakStart && dt.Hour < PeakEnd)
                    Amount = 1.00m;
            }


        }

    }
}
