namespace ProxySwitcher.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IProxyDetails
    {
        string ProxyAddress { get; set; }

        bool Enabled { get; set; }

        bool SelectedProxy { get; set; }
    }
}
