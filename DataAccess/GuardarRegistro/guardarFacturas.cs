using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class FacturasDataAccess : ConeccionSql
    {
        public DataTable ObtenerTodasLasFacturas()
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Facturas", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public DataRow ObtenerFacturaPorId(int idFactura)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Facturas WHERE Id_Factura = @idFactura", connection))
                {
                    command.Parameters.AddWithValue("@idFactura", idFactura);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    connection.Close();
                    return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
                }
            }
        }

        public bool InsertarFactura(int idCliente, DateTime fecha, decimal total, int productoId, string descripcion, decimal precioUnitario, int cantidad)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO Facturas (ID_Cliente, Fecha, Total, ProductoID, Descripcion, PrecioUnitario, Cantidad) " +
                                                            "VALUES (@idCliente, @fecha, @total, @productoId, @descripcion, @precioUnitario, @cantidad)", connection))
                {
                    command.Parameters.AddWithValue("@idCliente", idCliente);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@productoId", productoId);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@precioUnitario", precioUnitario);
                    command.Parameters.AddWithValue("@cantidad", cantidad);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
        }

        public bool ActualizarFactura(int idFactura, int idCliente, DateTime fecha, decimal total, int productoId, string descripcion, decimal precioUnitario, int cantidad)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("UPDATE Facturas SET ID_Cliente = @idCliente, Fecha = @fecha, Total = @total, " +
                                                            "ProductoID = @productoId, Descripcion = @descripcion, PrecioUnitario = @precioUnitario, Cantidad = @cantidad " +
                                                            "WHERE Id_Factura = @idFactura", connection))
                {
                    command.Parameters.AddWithValue("@idCliente", idCliente);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@productoId", productoId);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@precioUnitario", precioUnitario);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@idFactura", idFactura);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
        }

        public bool EliminarFactura(int idFactura)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM Facturas WHERE Id_Factura = @idFactura", connection))
                {
                    command.Parameters.AddWithValue("@idFactura", idFactura);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
        }
    }
}
