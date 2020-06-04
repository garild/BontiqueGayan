using ComponentFactory.Krypton.Toolkit;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace SkyReg.Utils
{
    public sealed class CommonMethods
    {
        public static bool isNetworkWorking()
        {
            var all = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var item in all)
            {
                if (item.NetworkInterfaceType == NetworkInterfaceType.Loopback)
                    continue;
                if (item.Name.ToLower().Contains("virtual") || item.Description.ToLower().Contains("virtual"))
                    continue;
                if (item.OperationalStatus == OperationalStatus.Up)
                {
                    return true;
                }
            }

            return false;
        }
        public static void CheckInternetConnection()
        {
            if (!CommonMethods.isNetworkWorking())
            {
                KryptonMessageBox.Show("Brak połaczenia z internetem", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
