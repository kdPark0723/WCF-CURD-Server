using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace WCF_Server
{
    public partial class Form1 : Form
    {
        ServiceHost host;

        public Form1()
        {
            InitializeComponent();

            DatabaseConnectionInfo connectionInfo = new DatabaseConnectionInfo("", "", "", "", "", "");

            GetDatabaseConnectionInfoForm getDatabaseConnectionInfoForm = new GetDatabaseConnectionInfoForm(connectionInfo);
            getDatabaseConnectionInfoForm.ShowDialog();

            DataAccessor.currentConnection = connectionInfo;
        }

        private void ServerStartButton_Click(object sender, EventArgs e)
        {
            string address = "net.tcp://localhost:8080/mcf";

            NetTcpBinding binding = new NetTcpBinding();

            host = new ServiceHost(typeof(DataAccessor));
            host.AddServiceEndpoint(typeof(IDataAccessor), binding, address);

            host.Open();

            this.statText.Text = "Server Start";
        }

        private void ServerStopButton_Click(object sender, EventArgs e)
        {
            host.Close();

            this.statText.Text = "Server Stop";
        }
    }
}
