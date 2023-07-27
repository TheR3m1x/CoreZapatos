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
    public partial class Facturas : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private FacturasDominio facturasDominio;
        private DataTable dataTable;

        public Facturas()
        {
            InitializeComponent();
            facturasDominio = new FacturasDominio();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            FacturasDominio facturasDominio = new FacturasDominio();
            dataTable = facturasDominio.ObtenerTodasLasFacturas();
            dataGrid.DataSource = dataTable;
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedId;
                object value = dataGrid.Rows[e.RowIndex].Cells["Id_Factura"].Value;

                if (value != DBNull.Value && int.TryParse(value.ToString(), out selectedId))
                {
                    dataViewFacturasDominio facturasDominio = new dataViewFacturasDominio();
                    DataTable facturaTable = facturasDominio.ObtenerFacturaPorId(selectedId);

                    if (facturaTable.Rows.Count > 0)
                    {
                        DataRow row = facturaTable.Rows[0];

                        textIdFactura.Text = row["Id_Factura"].ToString();
                        textIdCliente.Text = row["ID_Cliente"].ToString();
                        dateFecha.Text = row["Fecha"].ToString();
                        textTotal.Text = row["Total"].ToString();
                        textProductoID.Text = row["ProductoID"].ToString();
                        textDescripcion.Text = row["Descripcion"].ToString();
                        textPrecioUnitario.Text = row["PrecioUnitario"].ToString();
                        textCantidad.Text = row["Cantidad"].ToString();

                        log.Info($"El usuario {UserLoginCache.nombreUser.ToString()} seleccionó la factura con el ID {selectedId}");
                    }
                }
            }
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBuscar.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                dataViewFacturasDominio facturasDominio = new dataViewFacturasDominio();

                List<object> facturasFiltradas = facturasDominio.ObtenerFacturasFiltradas(searchText);
                dataGrid.DataSource = ConvertToDataTable(facturasFiltradas);
            }
            else
            {
                CargarDatos();
            }
        }

        private DataTable ConvertToDataTable(List<object> data)
        {
            DataTable table = new DataTable();

            if (data.Count > 0)
            {
                var properties = data[0].GetType().GetProperties();

                foreach (var prop in properties)
                {
                    table.Columns.Add(prop.Name, prop.PropertyType);
                }

                foreach (var item in data)
                {
                    var values = new object[properties.Length];

                    for (int i = 0; i < properties.Length; i++)
                    {
                        values[i] = properties[i].GetValue(item);
                    }

                    table.Rows.Add(values);
                }
            }

            return table;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttomGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textIdCliente.Text) || string.IsNullOrEmpty(dateFecha.Text) || string.IsNullOrEmpty(textTotal.Text) ||
                string.IsNullOrEmpty(textProductoID.Text) || string.IsNullOrEmpty(textDescripcion.Text) || string.IsNullOrEmpty(textPrecioUnitario.Text) || string.IsNullOrEmpty(textCantidad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar la factura.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int idCliente = Convert.ToInt32(textIdCliente.Text);
                DateTime fecha = Convert.ToDateTime(dateFecha.Text);
                decimal total = Convert.ToDecimal(textTotal.Text);
                int productoId = Convert.ToInt32(textProductoID.Text);
                string descripcion = textDescripcion.Text;
                decimal precioUnitario = Convert.ToDecimal(textPrecioUnitario.Text);
                int cantidad = Convert.ToInt32(textCantidad.Text);

                FacturasDominio facturasDominio = new FacturasDominio();
                bool resultado = facturasDominio.InsertarFactura(idCliente, fecha, total, productoId, descripcion, precioUnitario, cantidad);

                if (resultado)
                {
                    MessageBox.Show("Factura insertada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    log.Info($" El usuario {UserLoginCache.username.ToString()} ha generado una nueva factura.");
                }
                else
                {
                    MessageBox.Show("Error al insertar la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttomUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textIdFactura.Text) || string.IsNullOrEmpty(textIdCliente.Text) || string.IsNullOrEmpty(dateFecha.Text) ||
                string.IsNullOrEmpty(textTotal.Text) || string.IsNullOrEmpty(textProductoID.Text) || string.IsNullOrEmpty(textDescripcion.Text) ||
                string.IsNullOrEmpty(textPrecioUnitario.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de actualizar la factura.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int idFactura = Convert.ToInt32(textIdFactura.Text);
                int idCliente = Convert.ToInt32(textIdCliente.Text);
                DateTime fecha = Convert.ToDateTime(dateFecha.Text);
                decimal total = Convert.ToDecimal(textTotal.Text);
                int productoId = Convert.ToInt32(textProductoID.Text);
                string descripcion = textDescripcion.Text;
                decimal precioUnitario = Convert.ToDecimal(textPrecioUnitario.Text);
                int cantidad = Convert.ToInt32(textCantidad.Text);

                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres actualizar esta factura?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    FacturasDominio facturasDominio = new FacturasDominio();
                    bool resultado = facturasDominio.ActualizarFactura(idFactura, idCliente, fecha, total, productoId, descripcion, precioUnitario, cantidad);

                    if (resultado)
                    {
                        MessageBox.Show("Factura actualizada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        log.Info($" El usuario {UserLoginCache.username.ToString()} ha actualizado la factura con ID {idFactura}");

                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        log.Info("Error en la actualización de la factura");
                    }
                }
            }
        }

        private void buttomDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textIdFactura.Text))
            {
                MessageBox.Show("Por favor, seleccione una factura para eliminar.", "Factura no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idFactura = Convert.ToInt32(textIdFactura.Text);

            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar esta factura?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool resultado = facturasDominio.EliminarFactura(idFactura);

                if (resultado)
                {
                    MessageBox.Show("Factura eliminada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    log.Info($" El usuario {UserLoginCache.username.ToString()} ha eliminado la factura con ID {idFactura}");

                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Info("Error en la eliminación de la factura");
                }
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

        private void LimpiarCampos()
        {
            textIdFactura.Clear();
            textIdCliente.Clear();
            textTotal.Clear();
            textProductoID.Clear();
            textDescripcion.Clear();
            textPrecioUnitario.Clear();
        }
    }
}
