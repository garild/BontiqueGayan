using ComponentFactory.Krypton.Toolkit;
using Newtonsoft.Json;
using SkyReg;
using SkyReg.Common;
using SkyReg.Extensions;
using System;
using System.IO;
using System.Windows.Forms;

namespace BoutiqueShopp.Infrastructure.Providers.DatabaseConfig
{
    public static class ApplicationConfigsProvider
    {
        public static LoggedUser ProviderUserConfig()
        {
            try
            {
                if (File.Exists(GlobalApplicationSettings.UserConfigFile))
                {

                    var userConfigJson = File.ReadAllText(GlobalApplicationSettings.UserConfigFile);
                    var userConfig = JsonConvert.DeserializeObject<LoggedUser>(userConfigJson);

                    return userConfig;
                }

                return null;

            }

            catch (Exception)
            {
                KryptonMessageBox.Show("Wystąpił błąd podczas wczytywania pliku z ustawieniami", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        public static DatabaseAccess ProviderDatabaseConfig()
        {
            try
            {
                if (File.Exists(GlobalApplicationSettings.DatabaseConfigFile))
                {
                    var databaseJson = File.ReadAllText(GlobalApplicationSettings.DatabaseConfigFile);
                    var configSettings = JsonConvert.DeserializeObject<DatabaseAccess>(databaseJson);

                    configSettings.Password = configSettings.Password.DecryptString();

                    DatabaseFactory.CreateConnectionString(configSettings);

                    GlobalApplicationSettings.IsDbExists = !string.IsNullOrEmpty(configSettings.DatabaseConnectionString);

                    return configSettings;
                }

                return null;
            }

            catch (Exception)
            {
                KryptonMessageBox.Show("Wystąpił błąd podczas wczytywania pliku z ustawieniami", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }
    }
}
