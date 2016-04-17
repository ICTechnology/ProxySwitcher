namespace ProxySwitcher.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ProxyDetails : IProxyDetails
    {
        public bool Enabled { get; set; }
        
        public string ProxyAddress { get; set; }

        public bool SelectedProxy { get; set; }
    }
}
