using Autofac;
using BoutiqueShopp.Domain;
using BoutiqueShopp.Infrastructure.Providers.DatabaseConfig;
using BoutiqueShopp.Infrastructure.Repositories;
using SkyReg;
using SkyReg.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();
            }
        }
    }
}
