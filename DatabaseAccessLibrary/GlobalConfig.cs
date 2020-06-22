
using DatabaseAccessLibrary.DataAccess;

namespace DatabaseAccessLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            switch (db)
            {
                case DatabaseType.Sql:
                    SqlConnector sql = new SqlConnector();
                    Connection = sql;
                    break;
                case DatabaseType.TextFile:
                    TextConnector text = new TextConnector();
                    Connection = text;
                    break;
                default:
                    break;
            }

        }
        // TODO - Create path connection string for SQL database
        public static string CnnString(string name)
        {
       
            return name;
        }

    }
}
