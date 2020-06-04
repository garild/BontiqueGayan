using System;
using System.Data.SqlClient;

namespace SkyReg.Common
{
    public class DatabaseAccess
    {
        public string ServerName { get; set; } = Environment.MachineName;
        public string DataBaseName { get; set; } = "BoutiqueShopp";
        public string DatabaseConnectionString { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }

    public sealed class DatabaseFactory
    {
        private static SqlConnectionStringBuilder connBuilder = null;
        public static DatabaseAccess _databaseAccess { get; set; }

        public static string CreateConnectionString(DatabaseAccess databaseAccess)
        {
            _databaseAccess = databaseAccess;

            if (connBuilder == null)
            {
                connBuilder = new SqlConnectionStringBuilder();
                connBuilder.InitialCatalog = _databaseAccess.DataBaseName;
                connBuilder.DataSource = _databaseAccess.ServerName;
                connBuilder.ConnectTimeout = 0;
                connBuilder.Encrypt = false;
                connBuilder.UserID = databaseAccess.User;
                connBuilder.Password = databaseAccess.Password;
                connBuilder.TrustServerCertificate = true;
                connBuilder.IntegratedSecurity = true;
                connBuilder.MultipleActiveResultSets = true;
                connBuilder.MaxPoolSize = 100;
               
                return connBuilder.ConnectionString;
            }
            else
                return connBuilder.ConnectionString;
        }
    }
}

