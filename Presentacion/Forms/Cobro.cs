using Dominio;
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
    public partial class Cobro : Form
    {

        private CuentasPorCobrarDomain cuentasPorCobrarDomain;
        private DataTable dataTable;

        public Cobro()
        {
            InitializeComponent();
            cuentasPorCobrarDomain = new CuentasPorCobrarDomain();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cobro_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dataTable = cuentasPorCobrarDomain.ObtenerTodasCuentasPorCobrar();
            dataGrid.DataSource = dataTable;
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedCuentaPorCobrarId;
                object value = dataGrid.Rows[e.RowIndex].Cells["Id_CuentasPorCobrar"].Value;

                if (value != DBNull.Value && int.TryParse(value.ToString(), out selectedCuentaPorCobrarId))
                {
                    DataRow cuentaPorCobrarRow = cuentasPorCobrarDomain.ObtenerCuentaPorCobrarPorId(selectedCuentaPorCobrarId);

                    if (cuentaPorCobrarRow != null)
                    {
                        textIdCuentaPorCobrar.Text = cuentaPorCobrarRow["Id_CuentasPorCobrar"].ToString();
                        textIdCliente.Text = cuentaPorCobrarRow["ID_Cliente"].ToString();
                        dateFechaEmision.Value = Convert.ToDateTime(cuentaPorCobrarRow["FechaEmision"]);
                        textProductoID.Text = cuentaPorCobrarRow["ProductoID"].ToString();
                        textDescripcion.Text = cuentaPorCobrarRow["Descripcion"].ToString();
                        textMontoTotal.Text = cuentaPorCobrarRow["MontoTotal"].ToString();
                        textMontoPagado.Text = cuentaPorCobrarRow["MontoPagado"].ToString();
                    }
                }
            }
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBuscar.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                DataTable cuentasPorCobrarFiltradas = cuentasPorCobrarDomain.BuscarCuentasPorCobrar(searchText);
                dataGrid.DataSource = cuentasPorCobrarFiltradas;
            }
            else
            {
                CargarDatos();
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void ButtonReload_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void buttomGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textIdCliente.Text) || string.IsNullOrEmpty(textProductoID.Text) ||
                string.IsNullOrEmpty(textDescripcion.Text) || string.IsNullOrEmpty(textMontoTotal.Text) ||
                string.IsNullOrEmpty(textMontoPagado.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar la cuenta por cobrar.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int idCliente = Convert.ToInt32(this.textIdCliente.Text);
                DateTime fechaEmision = dateFechaEmision.Value;
                int productoId = Convert.ToInt32(this.textProductoID.Text);
                string descripcion = textDescripcion.Text;
                decimal montoTotal = Convert.ToDecimal(textMontoTotal.Text);
                decimal montoPagado = Convert.ToDecimal(textMontoPagado.Text);

                bool resultado = cuentasPorCobrarDomain.InsertarCuentaPorCobrar(idCliente, fechaEmision, productoId, descripcion, montoTotal, montoPagado);

                if (resultado)
                {
                    MessageBox.Show("Cuenta por cobrar insertada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al insertar la cuenta por cobrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttomUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textIdCuentaPorCobrar.Text) || string.IsNullOrEmpty(textIdCliente.Text) ||
                string.IsNullOrEmpty(textProductoID.Text) || string.IsNullOrEmpty(textDescripcion.Text) ||
                string.IsNullOrEmpty(textMontoTotal.Text) || string.IsNullOrEmpty(textMontoPagado.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de actualizar la cuenta por cobrar.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int idCuentaPorCobrar = Convert.ToInt32(textIdCuentaPorCobrar.Text);
                int idCliente = Convert.ToInt32(this.textIdCliente.Text);
                DateTime fechaEmision = dateFechaEmision.Value;
                int productoId = Convert.ToInt32(this.textProductoID.Text);
                string descripcion = textDescripcion.Text;
                decimal montoTotal = Convert.ToDecimal(textMontoTotal.Text);
                decimal montoPagado = Convert.ToDecimal(textMontoPagado.Text);

                bool resultado = cuentasPorCobrarDomain.ActualizarCuentaPorCobrar(idCuentaPorCobrar, idCliente, fechaEmision, productoId, descripcion, montoTotal, montoPagado);

                if (resultado)
                {
                    MessageBox.Show("Cuenta por cobrar actualizada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al actualizar la cuenta por cobrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void buttomDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textIdCuentaPorCobrar.Text))
            {
                MessageBox.Show("Por favor, seleccione una cuenta por cobrar para eliminar.", "Cuenta por cobrar no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCuentaPorCobrar = Convert.ToInt32(textIdCuentaPorCobrar.Text);

            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar esta cuenta por cobrar?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool resultado = cuentasPorCobrarDomain.EliminarCuentaPorCobrar(idCuentaPorCobrar);

                if (resultado)
                {
                    MessageBox.Show("Cuenta por cobrar eliminada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar la cuenta por cobrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarCampos()
        {
            textIdCuentaPorCobrar.Clear();
            textIdCliente.Clear();
            textProductoID.Clear();
            textDescripcion.Clear();
            textMontoTotal.Clear();
            textMontoPagado.Clear();
        }

        private void textDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

