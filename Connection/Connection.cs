using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoVendas.Connection
{
    public class ConnectionCreation
    {
        public MySqlConnection getConnection()
        {
            //configuração do banco
            string connection = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;
            return new MySqlConnection(connection);
        }
    }
}
