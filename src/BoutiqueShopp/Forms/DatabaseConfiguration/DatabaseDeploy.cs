using Microsoft.SqlServer.Dac;
using System;

namespace SkyReg.Forms.DatabaseConfiguration
{
    public static class DatabaseDeploy
    {
        private static bool IsErrorAtDeyploment;
        public static void Deploy(string connectionString,string dacpacFileName,string databaseName)
        {
            try
            {
                var dacServices = new DacServices(connectionString);
                dacServices.Message += DacServices_Message;
                dacServices.ProgressChanged += DacServices_ProgressChanged;
                var options = new DacDeployOptions
                {
                    CreateNewDatabase = true,
                    BlockOnPossibleDataLoss = true,
                    GenerateSmartDefaults = true,
                    VerifyDeployment = true,
                };

                //TODO na pszyłość można to wykorzystać
                //dacServices.GenerateDeployReport(DacPackage.Load(DacpacFileName), DatabaseName, options);

                var dacpackPackage = DacPackage.Load(dacpacFileName);

                dacServices.Deploy(dacpackPackage, databaseName, true, options);
                GlobalApplicationSettings.IsDbExists = true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static void DacServices_ProgressChanged(object sender, DacProgressEventArgs e)
        {
            var aa = e.Message;
        }

        private static void DacServices_Message(object sender, DacMessageEventArgs e)
        {
            IsErrorAtDeyploment = false;
            if (e.Message.MessageType == DacMessageType.Error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message.Message);
                IsErrorAtDeyploment = true;
            }
            if (e.Message.MessageType == DacMessageType.Warning)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(e.Message.Message);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(e.Message.Message);
            }
        }
    }
}
