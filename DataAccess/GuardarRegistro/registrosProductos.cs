using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.GuardarRegistro
{
    public class guardarProductos : ConeccionSql
    {
        public bool InsertarProducto(string descripcion, decimal precio, int cantidad, string proveedor)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO Productos (descripcion, precio, cantidad, proveedor) VALUES (@descripcion, @precio, @cantidad, @proveedor)", connection))
                {
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@proveedor", proveedor);

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


        public bool ActualizarProducto(int id, string descripcion, decimal precio, int cantidad, string proveedor)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("UPDATE Productos SET descripcion = @descripcion, precio = @precio, cantidad = @cantidad, proveedor = @proveedor WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@proveedor", proveedor);

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

        public bool EliminarProducto(int id)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM Productos WHERE id = @id", connection))
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