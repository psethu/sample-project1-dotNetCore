
namespace DatabaseAccessLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        //TODO - Given taxi ride, update text file and return taxi ride with latest id
        /// <summary>
        /// Saves a new TaxiRide to the text file
        /// </summary>
        /// <param name="model">The taxi ride information </param>
        /// <returns>The taxi ride information, including the unique identifier</returns>
        public TaxiRideModel CreateTaxiRide(TaxiRideModel model)
        {
            return model;
        }
    }
}
