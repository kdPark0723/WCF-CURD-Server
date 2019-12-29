using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCF_Server
{
    public partial class GetDatabaseConnectionInfoForm : Form
    {
        DatabaseConnectionInfo connection;
        public GetDatabaseConnectionInfoForm(DatabaseConnectionInfo connection)
        {
            InitializeComponent();

            this.connection = connection;
            this.passwordInputTextBox.PasswordChar = '*';
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.connection.SetServer(this.urlInputTextBox.Text);
            this.connection.SetPort(this.portIndexTextBox.Text);
            this.connection.SetDatabase(this.databaseInputTextBox.Text);
            this.connection.SetTable(this.tableInputTextBox.Text);
            this.connection.SetUser(this.userInputTextBox.Text);
            this.connection.SetPassword(this.passwordInputTextBox.Text);

            this.Close();
        }
    }
}
