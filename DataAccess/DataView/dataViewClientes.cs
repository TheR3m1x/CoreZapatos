using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataView
{
    public class dataViewClientes : ConeccionSql
    {
        public DataTable ObtenerTodosClientes()
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Clientes", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public DataTable ObtenerClientePorId(int id)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Clientes WHERE ID_Cliente = @id", connection))
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

        public List<object> ObtenerClientesFiltrados(string searchText)
        {
            List<object> clientes = new List<object>();

            using (var connection = GetSqlConnection())
            {
                connection.Open();

                // Crear la consulta SQL con los filtros por ID, nombre, apellido, email y cédula
                string query = "SELECT * FROM Clientes WHERE ID_Cliente LIKE @searchText OR Nombre LIKE @searchText OR Apellido LIKE @searchText OR Email LIKE @searchText OR Cedula LIKE @searchText";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchText", $"%{searchText}%");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Crear un objeto de tipo Cliente con los datos obtenidos de la consulta y agregarlo a la lista
                            var cliente = new
                            {
                                ID_Cliente = Convert.ToInt32(reader["ID_Cliente"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                Email = reader["Email"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                                Direccion = reader["Direccion"].ToString(),
                                Cedula = reader["Cedula"].ToString()
                            };

                            clientes.Add(cliente);
                        }

                        return clientes;
                    }
                }
            }
        }
    }
}
