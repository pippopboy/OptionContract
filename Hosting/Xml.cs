using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Hosting
{
    class Xml
    {
        public void CreateXmlService(XmlDocument doc)
        {
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", @"utf-8", null);
            doc.AppendChild(docNode);

            //add system.web
            XmlNode configuration = doc.CreateElement("configuration");
            doc.AppendChild(configuration);
            XmlNode systemweb = doc.CreateElement("system.web");
            XmlNode compilation = doc.CreateElement("compilation");
            XmlAttribute debug = doc.CreateAttribute("debug");
            debug.Value = "true";
            compilation.Attributes.Append(debug);
            configuration.AppendChild(systemweb);
            systemweb.AppendChild(compilation);

            XmlNode systemservicemodel = doc.CreateElement("system.serviceModel");
            configuration.AppendChild(systemservicemodel);
            XmlNode services = doc.CreateElement("services");
            systemservicemodel.AppendChild(services);

            //add a service
            
            //add behaviors
            XmlNode behaviors = doc.CreateElement("behaviors");
            systemservicemodel.AppendChild(behaviors);
            XmlNode serviceBehaviors = doc.CreateElement("serviceBehaviors");
            behaviors.AppendChild(serviceBehaviors);
            XmlNode behavior = doc.CreateElement("behavior");
            XmlAttribute name = doc.CreateAttribute("name");
            name.Value = "OptionContract.OptionBehavior";
            behavior.Attributes.Append(name);
            serviceBehaviors.AppendChild(behavior);
            XmlNode serviceMetadata = doc.CreateElement("serviceMetadata");
            XmlAttribute httpenabled = doc.CreateAttribute("httpGetEnabled");
            httpenabled.Value = "true";
            serviceMetadata.Attributes.Append(httpenabled);
            XmlNode serviceDebug = doc.CreateElement("serviceDebug");
            XmlAttribute includeexception = doc.CreateAttribute("includeExceptionDetailInFaults");
            includeexception.Value = "true";
            serviceDebug.Attributes.Append(includeexception);
            behavior.AppendChild(serviceMetadata);
            behavior.AppendChild(serviceDebug);

        }

        public void AddService(XmlDocument doc, string addressbase, string bind, string name)
        {
            XmlNode service = doc.CreateElement("service");
            doc.ChildNodes[1].FirstChild.AppendChild(service);
            XmlAttribute nameservice = doc.CreateAttribute("name");
            if (name.Length == 6)
            {
                nameservice.Value = "OptionContract.Option";
            }
            else
            {
                nameservice.Value = "OptionContract.Option1";
            }
            service.Attributes.Append(nameservice);
            XmlAttribute behaviorConfig = doc.CreateAttribute("behaviorConfiguration");
            behaviorConfig.Value = "OpContract.OptionBehavior";
            service.Attributes.Append(behaviorConfig);

            //endpoint trong service
            XmlNode endpoint = doc.CreateElement("endpoint");
            XmlAttribute address = doc.CreateAttribute("address");
            XmlAttribute binding = doc.CreateAttribute("binding");
            binding.Value = bind;
            XmlAttribute contract = doc.CreateAttribute("contract");
            contract.Value = "OptionContract.I" + name;
            endpoint.Attributes.Append(address);
            endpoint.Attributes.Append(binding);
            endpoint.Attributes.Append(contract);
            service.AppendChild(endpoint);

            //identify dns
            XmlNode identify = doc.CreateElement("identify");
            service.AppendChild(identify);
            XmlNode dns = doc.CreateElement("dns");
            XmlAttribute valuedns = doc.CreateAttribute("value");
            valuedns.Value = "localhost";
            dns.Attributes.Append(valuedns);
            identify.AppendChild(dns);

            //host
            XmlNode host = doc.CreateElement("host");
            service.AppendChild(host);
            XmlNode baseAddresses = doc.CreateElement("baseAddresses");
            host.AppendChild(baseAddresses);
            XmlNode addbaseaddress = doc.CreateElement("add");
            XmlAttribute baseaddress = doc.CreateAttribute("baseAddress");
            baseaddress.Value = addressbase;
            addbaseaddress.Attributes.Append(baseaddress);
            baseAddresses.AppendChild(addbaseaddress);
        }

      
    }
}
