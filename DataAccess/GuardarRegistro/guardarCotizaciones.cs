using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class CotizacionesDataAccess : ConeccionSql
    {
        public DataTable ObtenerTodasLasCotizaciones()
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Cotizaciones", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public DataRow ObtenerCotizacionPorId(int idCotizacion)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Cotizaciones WHERE Id_Cotizaciones = @idCotizacion", connection))
                {
                    command.Parameters.AddWithValue("@idCotizacion", idCotizacion);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    connection.Close();
                    return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
                }
            }
        }

        public DataTable BuscarCotizaciones(string searchText)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Cotizaciones WHERE Descripcion LIKE @searchText", connection))
                {
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public bool InsertarCotizacion(int idCliente, DateTime fecha, int productoId, string descripcion, decimal precioUnitario, int cantidad, decimal itbis, decimal descuento, decimal total)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO Cotizaciones (ID_Cliente, Fecha, ProductoID, Descripcion, PrecioUnitario, Cantidad, ITBIS, Descuento, Total) " +
                                                            "VALUES (@idCliente, @fecha, @productoId, @descripcion, @precioUnitario, @cantidad, @itbis, @descuento, @total)", connection))
                {
                    command.Parameters.AddWithValue("@idCliente", idCliente);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@productoId", productoId);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@precioUnitario", precioUnitario);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@itbis", itbis);
                    command.Parameters.AddWithValue("@descuento", descuento);
                    command.Parameters.AddWithValue("@total", total);

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

        public bool ActualizarCotizacion(int idCotizacion, int idCliente, DateTime fecha, int productoId, string descripcion, decimal precioUnitario, int cantidad, decimal itbis, decimal descuento, decimal total)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("UPDATE Cotizaciones SET ID_Cliente = @idCliente, Fecha = @fecha, ProductoID = @productoId, Descripcion = @descripcion, " +
                                                            "PrecioUnitario = @precioUnitario, Cantidad = @cantidad, ITBIS = @itbis, Descuento = @descuento, Total = @total " +
                                                            "WHERE Id_Cotizaciones = @idCotizacion", connection))
                {
                    command.Parameters.AddWithValue("@idCliente", idCliente);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@productoId", productoId);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@precioUnitario", precioUnitario);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@itbis", itbis);
                    command.Parameters.AddWithValue("@descuento", descuento);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@idCotizacion", idCotizacion);

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

        public bool EliminarCotizacion(int idCotizacion)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM Cotizaciones WHERE Id_Cotizaciones = @idCotizacion", connection))
                {
                    command.Parameters.AddWithValue("@idCotizacion", idCotizacion);

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
