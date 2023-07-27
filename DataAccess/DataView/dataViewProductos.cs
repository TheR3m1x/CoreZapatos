using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataView
{
    public class dataViewProductos : ConeccionSql
    {
        public DataTable ObtenerTodosProductos()
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Productos", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public DataTable ObtenerProductoPorId(int id)
        {
            using (var connection = GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Productos WHERE id = @id", connection))
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


        public List<object> ObtenerProductosFiltrados(string searchText)
        {
            List<object> Producto = new List<object>();

            using (var connection = GetSqlConnection())
            {
                connection.Open();

                // Crear la consulta SQL con los filtros por ID, descripción y proveedor
                string query = "SELECT * FROM Productos WHERE id LIKE @searchText OR descripcion LIKE @searchText OR proveedor LIKE @searchText";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchText", $"%{searchText}%");

                    
                        using (SqlDataReader reader = command.ExecuteReader())
                        {


                            while (reader.Read())
                            {
                                // Crear un objeto de tipo Producto con los datos obtenidos de la consulta y agregarlo a la lista
                                var productos = new
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Descripcion = reader["descripcion"].ToString(),
                                    Precio = Convert.ToDecimal(reader["precio"]),
                                    Cantidad = Convert.ToInt32(reader["cantidad"]),
                                    Proveedor = reader["proveedor"].ToString(),
                                };


                                Producto.Add(productos);
                            }

                            return Producto;
                        }
                    
                }
            }
        }

        public List<object> ObtenerTodosLosProductos()
        {
            List<object> Producto = new List<object>();

            using (var connection = GetSqlConnection())
            {
                connection.Open();

                // Consulta SQL para obtener todos los productos
                string query = "SELECT * FROM Productos";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        

                        while (reader.Read())
                        {
                            // Crear un objeto de tipo Producto con los datos obtenidos de la consulta y agregarlo a la lista
                            var productos = new
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Descripcion = reader["descripcion"].ToString(),
                                Precio = Convert.ToDecimal(reader["precio"]),
                                Cantidad = Convert.ToInt32(reader["cantidad"]),
                                Proveedor = reader["proveedor"].ToString(),
                            };


                            Producto.Add(productos);
                        }

                        return Producto;
                    }
                }
            }
        }
    }
}
