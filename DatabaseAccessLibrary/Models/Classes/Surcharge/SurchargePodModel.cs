using Microsoft.VisualBasic;
using System;

namespace DatabaseAccessLibrary.Models
{
    /// <summary>
    /// Surcharge for Part of Day
    /// </summary>
    public class SurchargePodModel : SurchargeBaseModel
    {

        public override  decimal Amount { get; set; }

        public PartOfDay Pod { get; set; }

        public SurchargePodModel(PartOfDay pod)
        {
            this.Pod = pod;
        }

        /// <summary>
        /// Using the instance's Part of Day, assign Amount
        /// </summary>
        public override void Calculate()
        {
            // enums are wonderful to use with switch statements
            switch (Pod)
            {
                case PartOfDay.Morning:
                    Amount = 0.0m;
                    break;
                case PartOfDay.Afternoon:
                    Amount = 0.0m;
                    break;
                case PartOfDay.Night:
                    Amount = 0.50m;
                    break;
                default:
                    break;

            }
        }
    }
}
