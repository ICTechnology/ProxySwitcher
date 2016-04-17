namespace ProxySwitcher.Core
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    public class UserProfile : IUserProfile
    {
        public IList<IProxyDetails> ProxyRepository { get; private set; }

        private XmlWriterSettings xmlWriterSettings { get; }

        private XmlWriter xmlWriter;

        private XmlReader xmlReader;

        public UserProfile(IList<IProxyDetails> proxyRepository, XmlWriterSettings xmlWriterSettings)
        {
            this.ProxyRepository = proxyRepository;
            this.xmlWriterSettings = xmlWriterSettings;         
        }

        public UserProfile()
            : this(new List<IProxyDetails>(), new XmlWriterSettings())
        {
        }

        public bool PopulateFromFile(string filepath)
        {
            var result = false;

            if (!string.IsNullOrEmpty(filepath))
            {
                this.xmlReader = XmlReader.Create(filepath);

                if (this.xmlReader != null)
                {
                    while (this.xmlReader.Read())
                    {
                        if ((this.xmlReader.NodeType == XmlNodeType.Element) && (this.xmlReader.Name == "ProxyDetails"))
                        {
                            var proxyDetails = new ProxyDetails();
                            proxyDetails.ProxyAddress = this.xmlReader.GetAttribute("ProxyAddress");
                            proxyDetails.SelectedProxy = (this.xmlReader.GetAttribute("SelectedProxy") == "True") ? true : false;
                            proxyDetails.Enabled = (this.xmlReader.GetAttribute("Enabled") == "True") ? true : false;

                            this.ProxyRepository.Add(proxyDetails);
                        }
                    }
                }
            }

            return result;
        }

        public bool SaveProxyDetailsToFile(string filepath)
        {
            var result = false;

            if (!string.IsNullOrEmpty(filepath))
            {
                using (this.xmlWriter = XmlWriter.Create(filepath, this.xmlWriterSettings))
                {
                    if (this.xmlWriter != null)
                    {
                        this.xmlWriter.WriteStartDocument();
                        this.xmlWriter.WriteStartElement("ProxyDetailsCollection");

                        foreach (IProxyDetails details in this.ProxyRepository)
                        {
                            this.xmlWriter.WriteStartElement("ProxyDetails");
                            this.xmlWriter.WriteAttributeString("ProxyAddress", details.ProxyAddress);
                            this.xmlWriter.WriteAttributeString("SelectedProxy", details.SelectedProxy.ToString(CultureInfo.CurrentCulture));
                            this.xmlWriter.WriteAttributeString("Enabled", details.Enabled.ToString(CultureInfo.CurrentCulture));
                            this.xmlWriter.WriteEndElement();
                        }

                        this.xmlWriter.WriteEndElement();
                        this.xmlWriter.WriteEndDocument();
                    }
                }
            }

            return result;
        }
        
    }
}
