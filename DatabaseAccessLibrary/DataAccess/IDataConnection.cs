
using DatabaseAccessLibrary.Models;

namespace DatabaseAccessLibrary
{
    public interface IDataConnection
    {
        TaxiRideModel CreateTaxiRide(TaxiRideModel model);
    }
}
