using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class CuentasPorCobrarDataAccess : ConeccionSql
    {
        public DataTable ObtenerTodasLasCuentasPorCobrar()
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM CuentasPorCobrar", connection))
                {
                    connection.Open();

                    var dataTable = new DataTable();
                    dataTable.Load(command.ExecuteReader());

                    return dataTable;
                }
            }
        }

        public DataRow ObtenerCuentaPorCobrarPorId(int idCuentaPorCobrar)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM CuentasPorCobrar WHERE Id_CuentasPorCobrar = @Id", connection))
                {
                    command.Parameters.AddWithValue("@Id", idCuentaPorCobrar);

                    connection.Open();

                    var dataTable = new DataTable();
                    dataTable.Load(command.ExecuteReader());

                    if (dataTable.Rows.Count > 0)
                        return dataTable.Rows[0];

                    return null;
                }
            }
        }

        public DataTable BuscarCuentasPorCobrar(string searchText)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM CuentasPorCobrar\r\nWHERE ID_Cliente LIKE CONCAT('%', @SearchText, '%')\r\n   OR Id_CuentasPorCobrar LIKE CONCAT('%', @SearchText, '%')\r\n   OR ProductoID LIKE CONCAT('%', @SearchText, '%')\r\n", connection))
                {
                    command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    connection.Open();

                    var dataTable = new DataTable();
                    dataTable.Load(command.ExecuteReader());

                    return dataTable;
                }
            }
        }

        public bool InsertarCuentaPorCobrar(int idCliente, DateTime fechaEmision, int productoId, string descripcion, decimal montoTotal, decimal montoPagado)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO CuentasPorCobrar (ID_Cliente, FechaEmision, ProductoID, Descripcion, MontoTotal, MontoPagado) VALUES (@ID_Cliente, @FechaEmision, @ProductoID, @Descripcion, @MontoTotal, @MontoPagado)", connection))
                {
                    command.Parameters.AddWithValue("@ID_Cliente", idCliente);
                    command.Parameters.AddWithValue("@FechaEmision", fechaEmision);
                    command.Parameters.AddWithValue("@ProductoID", productoId);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@MontoTotal", montoTotal);
                    command.Parameters.AddWithValue("@MontoPagado", montoPagado);

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public bool ActualizarCuentaPorCobrar(int idCuentaPorCobrar, int idCliente, DateTime fechaEmision, int productoId, string descripcion, decimal montoTotal, decimal montoPagado)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("UPDATE CuentasPorCobrar SET ID_Cliente = @ID_Cliente, FechaEmision = @FechaEmision, ProductoID = @ProductoID, Descripcion = @Descripcion, MontoTotal = @MontoTotal, MontoPagado = @MontoPagado WHERE Id_CuentasPorCobrar = @Id", connection))
                {
                    command.Parameters.AddWithValue("@ID_Cliente", idCliente);
                    command.Parameters.AddWithValue("@FechaEmision", fechaEmision);
                    command.Parameters.AddWithValue("@ProductoID", productoId);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@MontoTotal", montoTotal);
                    command.Parameters.AddWithValue("@MontoPagado", montoPagado);
                    command.Parameters.AddWithValue("@Id", idCuentaPorCobrar);

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public bool EliminarCuentaPorCobrar(int idCuentaPorCobrar)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM CuentasPorCobrar WHERE Id_CuentasPorCobrar = @Id", connection))
                {
                    command.Parameters.AddWithValue("@Id", idCuentaPorCobrar);

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
    }
}
