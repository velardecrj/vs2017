using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class ArtistDA:BaseConnection
    {
        /// <summary>
        /// Permite obtener la cantidad de registros
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            
            var result = 0;
            var sql = "SELECT COUNT(1) FROM Artist";
            /*1.-Creando la instancia del objeto connection */
            using (IDbConnection 
                cn=new SqlConnection(base.ConnectionString))
            {
                /*1.-Creando el objeto command */
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                cn.Open(); //Abriendo la conexion a la base de datos;

                result = (int)cmd.ExecuteScalar();
            }
            return result;
        }
    }
}
