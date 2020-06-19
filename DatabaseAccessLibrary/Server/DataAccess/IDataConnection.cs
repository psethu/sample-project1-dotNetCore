using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_project1_dotNetCore.Server.DataAccess
{
    interface IDataConnection
    {
        TaxiFareModel CreatePrize(TaxiFareModel model);
    }
}
