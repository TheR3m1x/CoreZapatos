using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.GuardarRegistro
{
    public class guardarClientes : ConeccionSql
    {
        public bool InsertarCliente(string nombre, string apellido, string email, string telefono, string direccion, string cedula)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO Clientes (Nombre, Apellido, Email, Telefono, Direccion, Cedula) VALUES (@nombre, @apellido, @email, @telefono, @direccion, @cedula)", connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@cedula", cedula);

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

        public bool ActualizarCliente(int id, string nombre, string apellido, string email, string telefono, string direccion, string cedula)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("UPDATE Clientes SET Nombre = @nombre, Apellido = @apellido, Email = @email, Telefono = @telefono, Direccion = @direccion, Cedula = @cedula WHERE ID_Cliente = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@cedula", cedula);

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

        public bool EliminarCliente(int id)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM Clientes WHERE ID_Cliente = @id", connection))
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
