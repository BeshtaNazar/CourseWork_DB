using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class Database
    {
        NpgsqlConnection npgSqlConnection;        

        public Database()
        {
            string connInfo = "Host=localhost;Port=5432;Database=ISOfOrderingAndDeliveringFood;user id=postgres;password=sqfehtkuij";
            npgSqlConnection = new NpgsqlConnection(connInfo);
        }

        public void OpenConnection()
        {
            if (npgSqlConnection.State==System.Data.ConnectionState.Closed)
                npgSqlConnection.Open();
        }

        public void CloseConnection()
        {
            if (npgSqlConnection.State == System.Data.ConnectionState.Open)
                npgSqlConnection.Close();
        }

        public NpgsqlConnection getConnection()
        { 
            return npgSqlConnection;
        }
    }
}
