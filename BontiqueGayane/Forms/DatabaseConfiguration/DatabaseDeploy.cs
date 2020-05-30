using Microsoft.SqlServer.Dac;
using System;

namespace SkyReg.Forms.DatabaseConfiguration
{
    public static class DatabaseDeploy
    {
        private static bool IsErrorAtDeyploment;
        public static void Deploy(string dacpacFileName,string databaseName)
        {
            var connectionString = $"Data Source={Environment.MachineName};Initial Catalog={databaseName};Integrated Security=True;Connect Timeout=0;Encrypt=False;TrustServerCertificate=True;";

            var dacServices = new DacServices(connectionString);
            dacServices.Message += DacServices_Message;
            var options = new DacDeployOptions
            {
                CreateNewDatabase = false,
                BlockOnPossibleDataLoss = false,
                GenerateSmartDefaults = true,
                VerifyDeployment = true,
                DropObjectsNotInSource = true
            };

            //TODO na pszyłość można to wykorzystać
            //dacServices.GenerateDeployReport(DacPackage.Load(DacpacFileName), DatabaseName, options);


            dacServices.Deploy(DacPackage.Load(dacpacFileName), databaseName, true, options);

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
