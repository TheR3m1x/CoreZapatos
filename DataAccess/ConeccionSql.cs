using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public abstract class ConeccionSql
    {
        //Conexion de la base de datos

        private readonly string connectionString;
        public ConeccionSql() 
        {
            connectionString = "Data Source=DESKTOP-U7V8DA0;Initial Catalog=X;Integrated Security=True";
        } 

        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
