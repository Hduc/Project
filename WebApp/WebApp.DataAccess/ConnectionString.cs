using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;

namespace WebApp.DataAccess
{
    public class ConnectionString
    {
        private ConnectionString() { }
        private static ConnectionString _connectionString = null;
        private static string _connectionStringDefault = ConfigurationManager.ConnectionStrings["DBContext"].ConnectionString;
        public static string ConString
        {
            get
            {
                return _connectionStringDefault;

            }
        }
        public static string Connect(string dataSource, string initialCatalog, string userID, string password)
        {
            //Build an SQL connection string
            SqlConnectionStringBuilder sqlString = new SqlConnectionStringBuilder()
            {
                DataSource = dataSource, // Server name
                InitialCatalog = initialCatalog,  //Database
                UserID = userID,         //Username
                Password = password,  //Password
                MultipleActiveResultSets = true,
                PersistSecurityInfo = true,
            };

            //Build an Entity Framework connection string
            EntityConnectionStringBuilder entityString = new EntityConnectionStringBuilder()
            {
                Provider = "System.Data.SqlClient",
                Metadata = @"res://*/DBContext.csdl|
                            res://*/DBContext.ssdl|
                            res://*/DBContext.msl",
                ProviderConnectionString = sqlString.ToString()
            };
            return entityString.ConnectionString;
        }
        public static string DefaultConnection = ConfigurationManager.ConnectionStrings["DBContext"].ConnectionString;
    }
}
