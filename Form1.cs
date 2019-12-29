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
        bool isStart = false;

        public Form1()
        {
            InitializeComponent();

            DatabaseConnectionInfo connectionInfo = new DatabaseConnectionInfo("", "", "", "", "", "");

            GetDatabaseConnectionInfoForm getDatabaseConnectionInfoForm = new GetDatabaseConnectionInfoForm(connectionInfo);
            getDatabaseConnectionInfoForm.ShowDialog();

            DataAccessor.connectionInfo = connectionInfo;
            DataAccessor.Init();
        }

        private void ServerStartButton_Click(object sender, EventArgs e)
        {
            if (isStart)
                return;

            string address = "net.tcp://localhost:8080/wcf";

            NetTcpBinding binding = new NetTcpBinding();

            host = new ServiceHost(typeof(DataAccessor));
            host.AddServiceEndpoint(typeof(IDataAccessor), binding, address);

            host.Open();

            this.statText.Text = "Server Start";

            isStart = true;
        }

        private void ServerStopButton_Click(object sender, EventArgs e)
        {
            if (!isStart)
                return;

            host.Close();

            this.statText.Text = "Server Stop";

            isStart = false;
        }
    }
}
