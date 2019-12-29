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
            // Address 
            string address = "net.tcp://localhost:8080/myAddress";

            // Binding : TCP 사용
            NetTcpBinding binding = new NetTcpBinding();

            // Service Host 만들기
            host = new ServiceHost(typeof(DataAccessor));

            // End Point 추가
            host.AddServiceEndpoint(typeof(IDataAccessor), binding, address);

            // Service Host 시작
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
