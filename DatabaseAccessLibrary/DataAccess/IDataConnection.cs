using sample_project1_dotNetCore;

namespace DatabaseAccessLibrary
{
    public interface IDataConnection
    {
        TaxiFareModel CreateTaxiFare(TaxiFareModel model);
    }
}
