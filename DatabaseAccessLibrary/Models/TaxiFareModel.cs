using sample_project1_dotNetCore.Server.Models;
using System;


namespace sample_project1_dotNetCore
{
    public class TaxiFareModel : FareBaseModel
    {
        /// <summary>
        /// unique identifier for the prize
        /// </summary>
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int Minutes { get; set; }
            
        public int Miles { get; set; }


        public override int calculate()
        {
            throw new NotImplementedException();
        }
    }
}
