using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SonoraCreativaV2_2.ConnectionsSQL
{
    internal class ConexionSCDB
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.SonoraCreativaConnection);
            conn.Open();
            return conn;
        }
    }
}
