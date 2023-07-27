using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.DataView
{
    public class dataViewFacturas : ConeccionSql
    {
        public DataTable ObtenerTodasFacturas()
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

        public DataTable ObtenerFacturaPorId(int id)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Facturas WHERE Id_Factura = @id", connection))
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

        public List<object> ObtenerFacturasFiltradas(string searchText)
        {
            List<object> facturas = new List<object>();

            using (var connection = GetSqlConnection())
            {
                connection.Open();

                // Crear la consulta SQL con los filtros por ID, Descripcion y Cliente
                string query = "SELECT * FROM Facturas WHERE Id_Factura LIKE @searchText OR Descripcion LIKE @searchText OR ID_Cliente IN (SELECT ID_Cliente FROM Clientes WHERE Nombre LIKE @searchText OR Apellido LIKE @searchText)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchText", $"%{searchText}%");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Crear un objeto de tipo Factura con los datos obtenidos de la consulta y agregarlo a la lista
                            var factura = new
                            {
                                Id_Factura = Convert.ToInt32(reader["Id_Factura"]),
                                ID_Cliente = Convert.ToInt32(reader["ID_Cliente"]),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Total = Convert.ToDecimal(reader["Total"]),
                                ProductoID = Convert.ToInt32(reader["ProductoID"]),
                                Descripcion = reader["Descripcion"].ToString(),
                                PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"])
                            };

                            facturas.Add(factura);
                        }

                        return facturas;
                    }
                }
            }
        }
    }
}
