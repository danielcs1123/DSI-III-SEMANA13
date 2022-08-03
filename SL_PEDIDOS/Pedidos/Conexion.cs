using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Pedidos
{
    public class Conexion
    {
        private static string StringConnection =
        "Data Source=DESKTOP-IBSOR13\\SQLEXPRESS; Initial Catalog=SEMANA13; Integrated Security=true";

        public static SqlConnection Conectar()
        {
            SqlConnection cnx = new SqlConnection(StringConnection);
            return cnx;
        }
    }
}
