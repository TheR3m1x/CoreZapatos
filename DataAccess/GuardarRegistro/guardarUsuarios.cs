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
    public class GuardarUsuarios : ConeccionSql
    {
        public bool InsertarUsuario(string username, string password, int rol, string genero, string nombreUser, string apellidoUser, string emailUser, string cedulaUser)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO Usuarios (username, password, rol, genero, nombreUser, apellidoUser, emailUser, cedulaUser) VALUES (@username, @password, @rol, @genero, @nombreUser, @apellidoUser, @emailUser, @cedulaUser)", connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@rol", rol);
                    command.Parameters.AddWithValue("@genero", genero);
                    command.Parameters.AddWithValue("@nombreUser", nombreUser);
                    command.Parameters.AddWithValue("@apellidoUser", apellidoUser);
                    command.Parameters.AddWithValue("@emailUser", emailUser);
                    command.Parameters.AddWithValue("@cedulaUser", cedulaUser);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        
                        
                        return true; // Inserción exitosa

                    }
                    catch (Exception)
                    {
                        // Manejo de excepciones, si es necesario
                        return false; // Error en la inserción
                    }
                }
            }
        }

        public bool ActualizarUsuario(int id, string username, string password, int rol, string genero, string nombreUser, string apellidoUser, string emailUser, string cedulaUser)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("UPDATE Usuarios SET username = @username, password = @password, rol = @rol, genero = @genero, nombreUser = @nombreUser, apellidoUser = @apellidoUser, emailUser = @emailUser, cedulaUser = @cedulaUser WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@rol", rol);
                    command.Parameters.AddWithValue("@genero", genero);
                    command.Parameters.AddWithValue("@nombreUser", nombreUser);
                    command.Parameters.AddWithValue("@apellidoUser", apellidoUser);
                    command.Parameters.AddWithValue("@emailUser", emailUser);
                    command.Parameters.AddWithValue("@cedulaUser", cedulaUser);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // Si se afectó al menos una fila, se considera una actualización exitosa
                    }
                    catch (Exception)
                    {
                        // Manejo de excepciones, si es necesario
                        return false; // Error en la actualización
                    }
                }
            }
        }

        public bool EliminarUsuario(int id)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM Usuarios WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // Si se afectó al menos una fila, se considera una eliminación exitosa
                    }
                    catch (Exception)
                    {
                        // Manejo de excepciones, si es necesario
                        return false; // Error en la eliminación
                    }
                }
            }
        }



    }
}
