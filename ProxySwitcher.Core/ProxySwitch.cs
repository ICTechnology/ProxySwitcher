namespace ProxySwitcher.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Runtime.InteropServices;
    using Microsoft.Win32;

    public class ProxySwitch : IProxySwitch
    {
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;
        private readonly RegistryKey registry;

        public ProxySwitch(RegistryKey registryKey)
        {
            this.registry = registryKey;                                     
        }

        public ProxySwitch()
        {
            this.registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
        }

        public void SwitchOff()
        {
            this.registry.SetValue("ProxyServer", 1);
            this.registry.SetValue("ProxyEnable", 0);
            this.RefreshOSSettings();
        }

        public void SwitchOn()
        {
            this.registry.SetValue("ProxyServer", "isdproxy.isd-nr.idealshoppingdirect.co.uk:3128");
            this.registry.SetValue("ProxyEnable", 1);
            this.RefreshOSSettings();
        }

        public void RefreshOSSettings()
        {
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }

        public bool CheckStatus()
        {
            var proxyStatus = (int)registry.GetValue("ProxyEnable");

            var boolStatus = false;

            if (proxyStatus == 1)
            {
                boolStatus = true;
            }

            return boolStatus;                         
        }

        public string CheckProxyConnectionString()
        {
            return registry.GetValue("ProxyServer").ToString();                
        }        
    }
}
