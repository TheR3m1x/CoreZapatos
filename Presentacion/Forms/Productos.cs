using Comun.Cache;
using Dominio;
using Dominio.DataView;
using Dominio.GuardarRegistro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Presentacion.Forms
{
    public partial class Productos : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private registrosProductosDominio registroProductoDominio;
        private DataTable dataTable;

        public Productos()
        {
            InitializeComponent();

        }
        private void Productos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            dataViewProductosDominio dataViewProductosDominio = new dataViewProductosDominio();
            dataTable = dataViewProductosDominio.ObtenerTodosProductos();
            dataGrid.DataSource = dataTable;
        }
        private void buttomGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDescripcion.Text) || string.IsNullOrEmpty(textPrecio.Text) ||  string.IsNullOrEmpty(textProveedor.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar el producto.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string descripcion = textDescripcion.Text;
                decimal precio = decimal.Parse(textPrecio.Text);
                int cantidad = Convert.ToInt32(numericCantidad.Value);
                string proveedor = textProveedor.Text;

                registrosProductosDominio guardarProductos = new registrosProductosDominio();

                bool resultado = guardarProductos.InsertarProducto(descripcion, precio, cantidad, proveedor);

                if (resultado)
                {
                    MessageBox.Show("Producto insertado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    log.Info($" El usuario {UserLoginCache.username.ToString()} acaba de generar un nuevo registro!");
                }
                else
                {
                    MessageBox.Show("Error al insertar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }


        private void buttomUpdate_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén completos
            if (string.IsNullOrEmpty(textDescripcion.Text) || string.IsNullOrEmpty(textPrecio.Text) || string.IsNullOrEmpty(numericCantidad.Text) || string.IsNullOrEmpty(textProveedor.Text))
            {
                MessageBox.Show("Para poder actualizar el producto, complete todos los campos", "Datos Incompletos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Info("Error en la actualización del producto!");
            }
            else
            {
                int selectedProductId = Convert.ToInt32(textID.Text); // Obtener el ID del producto seleccionado en el DataGridView

                if (selectedProductId != -1)
                {
                    // Obtener los valores de los campos
                    string descripcion = textDescripcion.Text;
                    decimal precio = decimal.Parse(textPrecio.Text);
                    int cantidad = int.Parse(numericCantidad.Text);
                    string proveedor = textProveedor.Text;

                    DialogResult result = MessageBox.Show("¿Estás seguro de que quieres actualizar este producto?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        registrosProductosDominio guardarProductos = new registrosProductosDominio();
                        
                        // Actualizar el producto
                        bool resultado = guardarProductos.ActualizarProducto(selectedProductId, descripcion, precio, cantidad, proveedor);

                        if (resultado)
                        {
                            MessageBox.Show("Producto actualizado exitosamente!", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            log.Info($" El usuario {UserLoginCache.username.ToString()} acaba de actualizar el ID {selectedProductId}");

                            LimpiarTextBox();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            log.Info("Error en la actualización del producto!");
                        }
                    }
                }
            }
        }

        private int GetSelectedProductId()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGrid.SelectedRows[0];
                DataGridViewCell idCell = selectedRow.Cells["id"];

                if (idCell != null && idCell.Value != null && !Convert.IsDBNull(idCell.Value))
                {
                    dataGrid.ClearSelection(); // Limpiar la selección actual en el DataGridView
                    selectedRow.Selected = true; // Seleccionar toda la fila

                    return Convert.ToInt32(idCell.Value);
                }
            }

            return -1; // Si no se seleccionó ninguna fila o el valor del atributo "id" es DBNull, retorna -1
        }

        private void buttomDelete_Click(object sender, EventArgs e)
        {
            int selectedProductId = GetSelectedProductId(); // Obtener el ID del producto seleccionado en el DataGridView

            if (selectedProductId != -1)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Instanciar la clase del dominio para gestionar los productos
                    registrosProductosDominio guardarProductos = new registrosProductosDominio();

                    // Eliminar el producto
                    bool resultado = guardarProductos.EliminarProducto(selectedProductId);

                    if (resultado)
                    {
                        MessageBox.Show("Producto eliminado exitosamente!", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        log.Info($" El usuario {UserLoginCache.username.ToString()} acaba de eliminar el ID {selectedProductId}");

                        LimpiarTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        log.Info("Error en la eliminación del producto!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona la fila entera para borrar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para limpiar los campos de texto
        private void LimpiarTextBox()
        {
            textID.Clear();
            textDescripcion.Clear();
            textPrecio.Clear();
            numericCantidad.Value = 0;
            textProveedor.Clear();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedProductId;
                object value = dataGrid.Rows[e.RowIndex].Cells["id"].Value;

                if (value != DBNull.Value && int.TryParse(value.ToString(), out selectedProductId))
                {
                    // Instanciar la clase del dominio para obtener los datos del producto por ID
                    dataViewProductosDominio domain = new dataViewProductosDominio();
                    DataTable productoTable = domain.ObtenerProductoPorId(selectedProductId);

                    if (productoTable.Rows.Count > 0)
                    {
                        DataRow row = productoTable.Rows[0];

                        textID.Text = row["id"].ToString();
                        textDescripcion.Text = row["descripcion"].ToString();
                        textPrecio.Text = row["precio"].ToString();
                        numericCantidad.Value = Convert.ToInt32(row["cantidad"]);
                        textProveedor.Text = row["proveedor"].ToString();

                        log.Info($"El usuario {UserLoginCache.nombreUser.ToString()} seleccionó la fila con el ID {selectedProductId}");
                    }
                }
            }
        }


        // Evento que se dispara al cambiar el texto en la barra de búsqueda
        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBuscar.Text.Trim();

            // Validar que el texto de búsqueda no esté vacío
            if (!string.IsNullOrEmpty(searchText))
            {
                // Instanciar la clase del dominio para gestionar los productos
                dataViewProductosDominio DVU = new dataViewProductosDominio();

                // Obtener los productos filtrados según el texto de búsqueda
                List<object> productosFiltrados = DVU.ObtenerProductosFiltrados(searchText);

                // Actualizar el origen de datos del DataGridView con los resultados filtrados
                dataGrid.DataSource = productosFiltrados;
            }
            else
            {
                // Si el texto de búsqueda está vacío, cargar todos los productos en el DataGridView
                CargarDatos();
            }
        }

        // Método para cargar todos los productos en el DataGridView
        


        private void ButtonReload_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();

        }
    }
}
