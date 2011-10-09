using System;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Xml;
using OptionContract;
using Hosting;

namespace Hosting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        
        
        public Uri baseAddress;
        Type contractType = typeof(IOption);
        Type instanceType = typeof(Option);
        private ServiceHost host;
        private bool ServiceStarted = false;
        private void BtStartServiceClick(object sender, EventArgs e)
        {
            if (ServiceStarted)
            {
                host.Close();
                ServiceStarted = false;
            }
            else
            {
                using (host)
                {
                    baseAddress = new Uri(txbaseaddress.Text);
                    host = new ServiceHost(typeof (Option), baseAddress);
                    ServiceMetadataBehavior  behavior = new ServiceMetadataBehavior();
                    behavior.HttpGetEnabled = true;
                    host.Description.Behaviors.Add(behavior);
                    host.AddServiceEndpoint(typeof (IOption), new BasicHttpBinding(), "Option");
                    if (cbMex.Checked)
                    { 
                        host.AddServiceEndpoint(typeof (IMetadataExchange), new BasicHttpBinding(), "MEX");
                    }
                    host.Open();
                    lbmessage.Visible = true;
                    lbmessage.Text = "Host Option is running...";
                    ServiceStarted = true;
                }
            }
        }

        private void BtStopServiceClick(object sender, EventArgs e)
        {
            lbmessage.Visible = true;
            if (ServiceStarted)
            {
                host.Close();
                lbmessage.Text = "Host stopped!";
            }
            else
            {
                lbmessage.Text = "Host is not running!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void txLocation_MouseClick(object sender, MouseEventArgs e)
        {
            txLocation.Text = "";
        }

        private void txtServiceContract1_MouseClick(object sender, MouseEventArgs e)
        {
            txtServiceContract1.Text = "";
        }

        private void txtServiceContract2_MouseClick(object sender, MouseEventArgs e)
        {
            txtServiceContract2.Text = "";
        }

        private void btSaveConfig_Click(object sender, EventArgs e)
        {
            Xml xml = new Xml();
            XmlDocument doc = new XmlDocument();
            if (!cbServiceContract1.Checked && !cbServiceContract2.Checked)
            {
                MessageBox.Show("Please choose Service Contract!");
            }
            else
            {
                if (cbBinding.Text != "" && txLocation.Text != "")
                {
                    xml.CreateXmlService(doc);
                    if (cbServiceContract1.Checked)
                    {
                        xml.AddService(doc, txLocation.Text, cbBinding.Text, "Option");
                    }
                    if (cbServiceContract2.Checked)
                    {
                        xml.AddService(doc, txLocation.Text, cbBinding.Text, "Option1");
                    }
                    doc.Save(@"appconfig.xml");
                    MessageBox.Show("Save successfully! Appconfig.xml is saved at bin/debug folder! Please check again!");

                }
                else
                {
                    MessageBox.Show("Please enter endpoint binding and location!");
                }
            }
        }

    }
}
