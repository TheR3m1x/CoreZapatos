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

namespace Presentacion.Forms
{
    public partial class Clientes : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private registrosProductosDominio registroClienteDominio;
        private DataTable dataTable;

        public Clientes()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            dataViewClientesDominio dataViewClientesDominio = new dataViewClientesDominio();
            dataTable = dataViewClientesDominio.ObtenerTodosClientes();
            dataGrid.DataSource = dataTable;
        }

        private void buttomGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textNombre.Text) || string.IsNullOrEmpty(textApellido.Text) || string.IsNullOrEmpty(textEmail.Text) || string.IsNullOrEmpty(textTelefono.Text) || string.IsNullOrEmpty(textDireccion.Text) || string.IsNullOrEmpty(textCedula.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar el cliente.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string nombre = textNombre.Text;
                string apellido = textApellido.Text;
                string email = textEmail.Text;
                string telefono = textTelefono.Text;
                string direccion = textDireccion.Text;
                string cedula = textCedula.Text;

                registrosClientesDominio guardarClientes = new registrosClientesDominio();

                bool resultado = guardarClientes.InsertarCliente(nombre, apellido, email, telefono, direccion, cedula);

                if (resultado)
                {
                    MessageBox.Show("Cliente insertado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    log.Info($" El usuario {UserLoginCache.username.ToString()} acaba de generar un nuevo registro de cliente!");
                    LimpiarTextBox();
                }
                else
                {
                    MessageBox.Show("Error al insertar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private int GetSelectedClientId()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGrid.SelectedRows[0];
                DataGridViewCell idCell = selectedRow.Cells["ID_Cliente"];

                if (idCell != null && idCell.Value != null && !Convert.IsDBNull(idCell.Value))
                {
                    dataGrid.ClearSelection(); // Limpiar la selección actual en el DataGridView
                    selectedRow.Selected = true; // Seleccionar toda la fila

                    return Convert.ToInt32(idCell.Value);
                }
            }

            return -1; // Si no se seleccionó ninguna fila o el valor del atributo "ID_Cliente" es DBNull, retorna -1
        }


        // Método para limpiar los campos de texto
        private void LimpiarTextBox()
        {
            textID.Clear();
            textNombre.Clear();
            textApellido.Clear();
            textEmail.Clear();
            textTelefono.Clear();
            textDireccion.Clear();
            textCedula.Clear();
        }

        private void buttonLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }

        private void ButtonReload_Click_1(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void buttomUpdate_Click_1(object sender, EventArgs e)
        {
            // Validar que todos los campos estén completos
            if (string.IsNullOrEmpty(textNombre.Text) || string.IsNullOrEmpty(textApellido.Text) || string.IsNullOrEmpty(textEmail.Text) || string.IsNullOrEmpty(textTelefono.Text) || string.IsNullOrEmpty(textDireccion.Text) || string.IsNullOrEmpty(textCedula.Text))
            {
                MessageBox.Show("Para poder actualizar el cliente, complete todos los campos", "Datos Incompletos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Info("Error en la actualización del cliente!");
            }
            else
            {
                int selectedClientId = Convert.ToInt32(textID.Text); // Obtener el ID del cliente seleccionado en el DataGridView

                if (selectedClientId != -1)
                {
                    // Obtener los valores de los campos
                    string nombre = textNombre.Text;
                    string apellido = textApellido.Text;
                    string email = textEmail.Text;
                    string telefono = textTelefono.Text;
                    string direccion = textDireccion.Text;
                    string cedula = textCedula.Text;

                    DialogResult result = MessageBox.Show("¿Estás seguro de que quieres actualizar este cliente?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        registrosClientesDominio guardarClientes = new registrosClientesDominio();

                        // Actualizar el cliente
                        bool resultado = guardarClientes.ActualizarCliente(selectedClientId, nombre, apellido, email, telefono, direccion, cedula);

                        if (resultado)
                        {
                            MessageBox.Show("Cliente actualizado exitosamente!", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            log.Info($" El usuario {UserLoginCache.username.ToString()} acaba de actualizar el ID {selectedClientId}");

                            LimpiarTextBox();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            log.Info("Error en la actualización del cliente!");
                        }
                    }
                }
            }
        }

        private void buttomDelete_Click_1(object sender, EventArgs e)
        {
            int selectedClientId = GetSelectedClientId(); // Obtener el ID del cliente seleccionado en el DataGridView

            if (selectedClientId != -1)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Instanciar la clase del dominio para gestionar los clientes
                    registrosClientesDominio guardarClientes = new registrosClientesDominio();

                    // Eliminar el cliente
                    bool resultado = guardarClientes.EliminarCliente(selectedClientId);

                    if (resultado)
                    {
                        MessageBox.Show("Cliente eliminado exitosamente!", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        log.Info($" El usuario {UserLoginCache.username.ToString()} acaba de eliminar el ID {selectedClientId}");

                        LimpiarTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        log.Info("Error en la eliminación del cliente!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona la fila entera para borrar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedClientId;
                object value = dataGrid.Rows[e.RowIndex].Cells["ID_Cliente"].Value;

                if (value != DBNull.Value && int.TryParse(value.ToString(), out selectedClientId))
                {
                    // Instanciar la clase del dominio para obtener los datos del cliente por ID
                    dataViewClientesDominio domain = new dataViewClientesDominio();
                    DataTable clienteTable = domain.ObtenerClientePorId(selectedClientId);

                    if (clienteTable.Rows.Count > 0)
                    {
                        DataRow row = clienteTable.Rows[0];

                        textID.Text = row["ID_Cliente"].ToString();
                        textNombre.Text = row["Nombre"].ToString();
                        textApellido.Text = row["Apellido"].ToString();
                        textEmail.Text = row["Email"].ToString();
                        textTelefono.Text = row["Telefono"].ToString();
                        textDireccion.Text = row["Direccion"].ToString();
                        textCedula.Text = row["Cedula"].ToString();

                        log.Info($"El usuario {UserLoginCache.nombreUser.ToString()} seleccionó la fila con el ID {selectedClientId}");
                    }
                }
            }
        }

        private void Clientes_Load_1(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBuscar.Text.Trim();

            // Validar que el texto de búsqueda no esté vacío
            if (!string.IsNullOrEmpty(searchText))
            {
                // Instanciar la clase del dominio para gestionar los clientes
                dataViewClientesDominio domain = new dataViewClientesDominio();

                // Obtener los clientes filtrados según el texto de búsqueda
                List<object> clientesFiltrados = domain.ObtenerClientesFiltrados(searchText);

                // Actualizar el origen de datos del DataGridView con los resultados filtrados
                dataGrid.DataSource = clientesFiltrados;
            }
            else
            {
                // Si el texto de búsqueda está vacío, cargar todos los clientes en el DataGridView
                CargarDatos();
            }

        }

    }
}
