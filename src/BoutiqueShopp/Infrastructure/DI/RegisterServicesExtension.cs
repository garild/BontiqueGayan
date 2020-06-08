using Autofac;
using BoutiqueShopp.Infrastructure.Providers.DatabaseConfig;
using SkyReg;
using System.Data;
using System.Data.SqlClient;

namespace BoutiqueShopp.Infrastructure.DI
{
    public static class RegisterServicesExtension
    {
        public static void RegisterServices(this ContainerBuilder builder)
        {
            if (GlobalApplicationSettings.IsDbExists)
            {
                var databaseSettings = ApplicationConfigsProvider.ProviderDatabaseConfig();
                builder.Register(scope => new SqlConnection(databaseSettings.DatabaseConnectionString)).As<IDbConnection>().InstancePerLifetimeScope();
            }
        }
    }
}
