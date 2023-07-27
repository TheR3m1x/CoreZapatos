using Domain;
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
    public partial class Cotizaciones : Form
    {
        private CotizacionesDomain cotizacionesDomain;
        private DataTable dataTable;

        public Cotizaciones()
        {
            InitializeComponent();
            cotizacionesDomain = new CotizacionesDomain();
        }

        private void Cotizaciones_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dataTable = cotizacionesDomain.ObtenerTodasCotizaciones();
            dataGrid.DataSource = dataTable;
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedCotizacionId;
                object value = dataGrid.Rows[e.RowIndex].Cells["Id_Cotizaciones"].Value;

                if (value != DBNull.Value && int.TryParse(value.ToString(), out selectedCotizacionId))
                {
                    DataRow cotizacionRow = cotizacionesDomain.ObtenerCotizacionPorId(selectedCotizacionId);

                    if (cotizacionRow != null)
                    {
                        textIdCotizacion.Text = cotizacionRow["Id_Cotizaciones"].ToString();
                        textIdCliente.Text = cotizacionRow["ID_Cliente"].ToString();
                        dateFecha.Value = Convert.ToDateTime(cotizacionRow["Fecha"]);
                        textProductoID.Text = cotizacionRow["ProductoID"].ToString();
                        textDescripcion.Text = cotizacionRow["Descripcion"].ToString();
                        textPrecioUnitario.Text = cotizacionRow["PrecioUnitario"].ToString();
                        textCantidad.Text = cotizacionRow["Cantidad"].ToString();
                        textITBIS.Text = cotizacionRow["ITBIS"].ToString();
                        textDescuento.Text = cotizacionRow["Descuento"].ToString();
                        textTotal.Text = cotizacionRow["Total"].ToString();
                    }
                }
            }
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBuscar.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                DataTable cotizacionesFiltradas = cotizacionesDomain.BuscarCotizaciones(searchText);
                dataGrid.DataSource = cotizacionesFiltradas;
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

        private void buttomGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textIdCliente.Text) || string.IsNullOrEmpty(textProductoID.Text) ||
                string.IsNullOrEmpty(textDescripcion.Text) || string.IsNullOrEmpty(textPrecioUnitario.Text) ||
                string.IsNullOrEmpty(textCantidad.Text) || string.IsNullOrEmpty(textITBIS.Text) ||
                string.IsNullOrEmpty(textDescuento.Text) || string.IsNullOrEmpty(textTotal.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar la cotización.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int idCliente = Convert.ToInt32(textIdCliente.Text);
                DateTime fecha = dateFecha.Value;
                int productoId = Convert.ToInt32(textProductoID.Text);
                string descripcion = textDescripcion.Text;
                decimal precioUnitario = Convert.ToDecimal(textPrecioUnitario.Text);
                int cantidad = Convert.ToInt32(textCantidad.Text);
                decimal itbis = Convert.ToDecimal(textITBIS.Text);
                decimal descuento = Convert.ToDecimal(textDescuento.Text);
                decimal total = Convert.ToDecimal(textTotal.Text);

                bool resultado = cotizacionesDomain.InsertarCotizacion(idCliente, fecha, productoId, descripcion, precioUnitario, cantidad, itbis, descuento, total);

                if (resultado)
                {
                    MessageBox.Show("Cotización insertada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al insertar la cotización", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttomUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textIdCotizacion.Text) || string.IsNullOrEmpty(textIdCliente.Text) ||
                string.IsNullOrEmpty(textProductoID.Text) || string.IsNullOrEmpty(textDescripcion.Text) ||
                string.IsNullOrEmpty(textPrecioUnitario.Text) || string.IsNullOrEmpty(textCantidad.Text) ||
                string.IsNullOrEmpty(textITBIS.Text) || string.IsNullOrEmpty(textDescuento.Text) ||
                string.IsNullOrEmpty(textTotal.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de actualizar la cotización.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int idCotizacion = Convert.ToInt32(textIdCotizacion.Text);
                int idCliente = Convert.ToInt32(textIdCliente.Text);
                DateTime fecha = dateFecha.Value;
                int productoId = Convert.ToInt32(textProductoID.Text);
                string descripcion = textDescripcion.Text;
                decimal precioUnitario = Convert.ToDecimal(textPrecioUnitario.Text);
                int cantidad = Convert.ToInt32(textCantidad.Text);
                decimal itbis = Convert.ToDecimal(textITBIS.Text);
                decimal descuento = Convert.ToDecimal(textDescuento.Text);
                decimal total = Convert.ToDecimal(textTotal.Text);

                bool resultado = cotizacionesDomain.ActualizarCotizacion(idCotizacion, idCliente, fecha, productoId, descripcion, precioUnitario, cantidad, itbis, descuento, total);

                if (resultado)
                {
                    MessageBox.Show("Cotización actualizada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al actualizar la cotización", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttomDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textIdCotizacion.Text))
            {
                MessageBox.Show("Por favor, seleccione una cotización para eliminar.", "Cotización no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCotizacion = Convert.ToInt32(textIdCotizacion.Text);

            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar esta cotización?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool resultado = cotizacionesDomain.EliminarCotizacion(idCotizacion);

                if (resultado)
                {
                    MessageBox.Show("Cotización eliminada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar la cotización", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonReload_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void LimpiarCampos()
        {
            textIdCotizacion.Clear();
            textIdCliente.Clear();
            textProductoID.Clear();
            textDescripcion.Clear();
            textPrecioUnitario.Clear();
            textCantidad.Clear();
            textITBIS.Clear();
            textDescuento.Clear();
            textTotal.Clear();
        }
    }
}