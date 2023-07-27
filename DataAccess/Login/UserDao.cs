using Comun.Cache;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserDao : ConeccionSql
    {
        public bool Login(string username, string password)
        {
            using (var connection = GetSqlConnection())
            {
                connection.Open();

                using (var cmd = new SqlCommand()) 
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM Usuarios WHERE username = @username AND password = @password";
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.CommandType = CommandType.Text; 
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.idUsuario = reader.GetInt32(0);
                            UserLoginCache.username = reader.GetString(1);
                            UserLoginCache.rol = reader.GetInt32(3);
                            UserLoginCache.nombreUser = reader.GetString(5);
                            UserLoginCache.apellidoUser = reader.GetString(6);
                            UserLoginCache.emailUser = reader.GetString(7);

                        }
                        return true;
                    }
                    else
                    {
                       return false;
                    }
                }
            }
        }
        public void metodo()
        {
            if (UserLoginCache.rol == cargos.Administrador || UserLoginCache.rol == cargos.Mantenimiento)
            {

            }
            
            if (UserLoginCache.rol == cargos.Usuario)
            {

            }
            if (UserLoginCache.rol == cargos.Consultas)
            {

            }

        }
    }
}
