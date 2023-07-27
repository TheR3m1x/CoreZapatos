using Comun.Cache;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    
    public class dataViewUsuarios : ConeccionSql
    {
        public DataTable viewDataUsuarioDA()
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("select * from Usuarios", connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    connection.Close();
                    return dataTable;
                }
            }
        }

        public DataTable ObtenerUsuarioPorId(int id)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Usuarios WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    connection.Close();
                    return dataTable;
                }
            }
        }

        public List<object> ObtenerUsuariosFiltrados(string searchText)
        {
            List<object> usuarios = new List<object>();

            using (var connection = GetSqlConnection())
            {
                // Consulta SQL para obtener los usuarios filtrados
                string query = "SELECT * FROM Usuarios WHERE rol LIKE @searchText OR username LIKE @searchText OR nombreUser LIKE @searchText";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var usuario = new
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Username = reader["username"].ToString(),
                            NombreUser = reader["nombreUser"].ToString(),
                            // Agrega las demás propiedades del usuario según tus necesidades
                        };

                        usuarios.Add(usuario);
                    }

                    reader.Close();
                }
            }

            return usuarios;
        }



    }
}
