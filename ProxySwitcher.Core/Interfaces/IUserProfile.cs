namespace ProxySwitcher.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IUserProfile
    {
        IList<IProxyDetails> ProxyRepository { get; }

        bool PopulateFromFile(string directory);
    }
}
