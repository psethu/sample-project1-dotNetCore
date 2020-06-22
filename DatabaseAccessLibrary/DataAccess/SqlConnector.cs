using Dapper;
using DatabaseAccessLibrary.Models;
using System.Data;

namespace DatabaseAccessLibrary
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Add DateTime field using Dapper
        /// <summary>
        /// Saves a new TaxiRide to the database
        /// </summary>
        /// <param name="model">The taxi ride information </param>
        /// <returns>The taxi ride information, including the unique identifier</returns>
        public TaxiRideModel CreateTaxiRide(TaxiRideModel model)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("TaxiRide")))
            {
                var p = new DynamicParameters();
                p.Add("@Minutes", model.Minutes);
                p.Add("@Miles", model.Miles);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTaxiFare_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }

    }
}
