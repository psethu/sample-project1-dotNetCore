using sample_project1_dotNetCore;

namespace DatabaseAccessLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        //TODO - Given taxi fare, update text file and return taxi fare with latest id
        /// <summary>
        /// Saves a new TaxiFare to the text file
        /// </summary>
        /// <param name="model">The taxi fare information </param>
        /// <returns>The taxi fare information, including the unique identifier</returns>
        public TaxiFareModel CreateTaxiFare(TaxiFareModel model)
        {
            return model;
        }
    }
}
