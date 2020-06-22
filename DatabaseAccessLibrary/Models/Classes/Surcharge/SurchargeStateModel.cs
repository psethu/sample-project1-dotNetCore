using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseAccessLibrary.Models
{
    /// <summary>
    /// Surcharge that is for the state, ie NY state surcharge
    /// </summary>
    public class SurchargeStateModel : SurchargeBaseModel
    {
        public override decimal Amount { get; set; }

        public string State { get; set; }

        // constructor for state
        public SurchargeStateModel(string state)
        {
            this.State = state;
        }


        //TODO -- in future may want to reference a class having a dictionary that maps charges between all states
        /// <summary>
        /// Calculates NY surcharge only currently
        /// </summary>
        public override void Calculate()
        {
            if (State == "NY")
                Amount =  0.50m;
            else
                Amount = 0.00m;
        }
    }
}
