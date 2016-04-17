using System;
using System.Collections.Generic;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProxySwitcher.Core.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var proxyWriterSettings = new XmlWriterSettings();
            proxyWriterSettings.Indent = true;
            
            var test = new UserProfile(new List<IProxyDetails>(), proxyWriterSettings);

            var proxyDetails = new ProxyDetails();
            proxyDetails.Enabled = false;
            proxyDetails.SelectedProxy = true;
            proxyDetails.ProxyAddress = "testing.co.uk:8080";

            var proxyDetails2 = new ProxyDetails();
            proxyDetails2.Enabled = false;
            proxyDetails2.SelectedProxy = true;
            proxyDetails2.ProxyAddress = "trololol.co.uk:8080";

            test.ProxyRepository.Add(proxyDetails);
            test.ProxyRepository.Add(proxyDetails2);

            test.SaveProxyDetailsToFile("C:\\Testing\\Test.xml");

            var result = test.PopulateFromFile("C:\\Testing\\Test.xml");
        }
    }
}
