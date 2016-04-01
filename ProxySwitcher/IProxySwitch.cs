using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxySwitcher
{
    public interface IProxySwitch
    {
        void SwitchOff();
        void SwitchOn();
        bool CheckStatus();
        string CheckProxyConnectionString();
    }
}
