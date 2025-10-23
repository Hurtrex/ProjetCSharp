using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC_.Utility
{
    public class ConnectionFactory
    {
        private readonly string host = "mysql-colval25.alwaysdata.net";
        private readonly string port = "3306";
        private readonly string username = "colval25_admp3";
        private readonly string password = "Gustave123";
        private readonly string database = "colval25_projectprog3_hi25";

        private MySqlConnection Connection = null;

        private static ConnectionFactory instance = null;
        private ConnectionFactory()
        {
            string connectionString = $"Server={this.host};Database={this.database};Uid={this.username};Pwd={this.password};";
            this.Connection = new MySqlConnection(connectionString);
        }

        public static ConnectionFactory GetInstance()
        {
            if (ConnectionFactory.instance == null)
                ConnectionFactory.instance = new ConnectionFactory();
            return ConnectionFactory.instance;
        }

        public MySqlConnection GetConnection()
        {
            return this.Connection;
        }
    }
}
