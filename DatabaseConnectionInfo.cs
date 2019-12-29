namespace WCF_Server
{
    public class DatabaseConnectionInfo
    {
        public string server;
        private string port;
        private string database;
        private string user;
        private string password;

        private string table;

        public DatabaseConnectionInfo(string server, string port, string database, string user, string password, string table)
        {
            this.server = server;
            this.port = port;
            this.database = database;
            this.user = user;
            this.password = password;

            this.table = table;
        }

        public void SetServer(string server)
        {
            this.server = server;
        }

        public void SetPort(string port)
        {
            this.port = port;
        }

        public void SetDatabase(string database)
        {
            this.database = database;
        }

        public void SetUser(string user)
        {
            this.user = user;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }

        public void SetTable(string table)
        {
            this.table = table;
        }

        public string GetTable()
        {
            return table;
        }

        public string GetConnectionInfo()
        {
            return "Server=" + this.server + "; Port=" + this.port + "; Database=" + this.database + "; Uid=" + this.user + "; Pwd=" + this.password + "; CharSet=utf8;";
        }
    }
}
