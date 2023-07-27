using Comun.Cache;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Presentacion.Forms
{
    public partial class Usuarios : Form
    {
        int index = 0;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            dataViewUsuariosDomain domain = new dataViewUsuariosDomain();
            DataTable usuariosTable = domain.viewDataUsuarioDomain();
            dataGrid.DataSource = usuariosTable;

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool VerificarRestriccionesContrasena(string contrasena)
        {
            bool tieneMayusculas = false;
            bool tieneMinusculas = false;
            bool tieneDigitos = false;
            bool tieneSimbolos = false;

            foreach (char c in contrasena)
            {
                if (char.IsUpper(c))
                    tieneMayusculas = true;
                else if (char.IsLower(c))
                    tieneMinusculas = true;
                else if (char.IsDigit(c))
                    tieneDigitos = true;
                else
                    tieneSimbolos = true;
            }

            return tieneMayusculas && tieneMinusculas && tieneDigitos && tieneSimbolos && contrasena.Length >= 8;
        }
        private void buttomGuardar_Click(object sender, EventArgs e)
        {
            
                if (string.IsNullOrEmpty(textUsername.Text) || string.IsNullOrEmpty(textNombre.Text) || string.IsNullOrEmpty(textApellido.Text) || string.IsNullOrEmpty(textEmail.Text) || string.IsNullOrEmpty(textCedula.Text) || string.IsNullOrEmpty(textGenero.Text))
                {
                    MessageBox.Show("Para poder guardar el registro, complete todos los campos", "Datos Incompletos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Info("Error en el registro!");
                }
                else
                {
                    if (textPassword.Text != textConfirmarPassword.Text)
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "Datos Incompletos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textConfirmarPassword.Clear();
                        log.Info("Error en el registro!");
                    }
                else if (!VerificarRestriccionesContrasena(textPassword.Text))
                {
                    MessageBox.Show("La contraseña no cumple con los requisitos de seguridad", "Datos Incompletos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textPassword.Clear();
                    textConfirmarPassword.Clear();
                    log.Info("Error en el registro!");
                }
                else
                    {
                        string username = textUsername.Text;
                        string password = textPassword.Text;
                        int rol = Convert.ToInt32(numericRol.Value);
                        string genero = textGenero.Text;
                        string nombreUser = textNombre.Text;
                        string apellidoUser = textApellido.Text;
                        string emailUser = textEmail.Text;
                        string cedulaUser = textCedula.Text;

                        guardarUsuarioDomain guardarUsuarios = new guardarUsuarioDomain();

                        bool resultado = guardarUsuarios.InsertarUsuarios(username, password, rol, genero, nombreUser, apellidoUser, emailUser, cedulaUser);

                        if (resultado)
                        {
                            MessageBox.Show("Usuario Registrado exitosamente!", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            textConfirmarPassword.Clear();
                            textUsername.Clear();
                            textPassword.Clear();                            
                            textGenero.Clear();
                            textNombre.Clear();
                            textApellido.Clear();
                            textEmail.Clear();
                            textCedula.Clear();

                            log.Info("Registro exitoso!");
                        }
                        else
                        {
                            MessageBox.Show("Error al guardar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            log.Info("Error en el registro!");
                        }
                    }
                }
            
           
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedUserId;
                object value = dataGrid.Rows[e.RowIndex].Cells["id"].Value;

                if (value != DBNull.Value && int.TryParse(value.ToString(), out selectedUserId))
                {
                    dataViewUsuariosDomain domain = new dataViewUsuariosDomain();
                    DataTable usuarioTable = domain.ObtenerUsuarioPorIdDomain(selectedUserId);

                    if (usuarioTable.Rows.Count > 0)
                    {
                        DataRow row = usuarioTable.Rows[0];

                        textID.Text = row["id"].ToString();
                        textUsername.Text = row["username"].ToString();
                        textPassword.Text = row["password"].ToString();
                        textConfirmarPassword.Text = textPassword.Text;
                        numericRol.Value = Convert.ToInt32(row["rol"]);
                        textGenero.Text = row["genero"].ToString();
                        textNombre.Text = row["nombreUser"].ToString();
                        textApellido.Text = row["apellidoUser"].ToString();
                        textEmail.Text = row["emailUser"].ToString();
                        textCedula.Text = row["cedulaUser"].ToString();

                        log.Info($"El usuario {UserLoginCache.nombreUser.ToString()} seleccionó la fila con el ID {selectedUserId}");
                    }
                }
            }
        }

        private void buttomUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textUsername.Text) || string.IsNullOrEmpty(textNombre.Text) || string.IsNullOrEmpty(textApellido.Text) || string.IsNullOrEmpty(textEmail.Text) || string.IsNullOrEmpty(textCedula.Text) || string.IsNullOrEmpty(textGenero.Text))
            {
                MessageBox.Show("Para poder guardar el registro, complete todos los campos", "Datos Incompletos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Info("Error en el registro!");
            }
            else if (textPassword.Text != textConfirmarPassword.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Datos Incompletos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textConfirmarPassword.Clear();
                log.Info("Error en el registro!");
            }
            else if (!VerificarRestriccionesContrasena(textPassword.Text))
            {
                MessageBox.Show("La contraseña no cumple con los requisitos de seguridad", "Datos Incompletos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPassword.Clear();
                textConfirmarPassword.Clear();
                log.Info("Error en el registro!");
            }
            else
            {
                int selectedUserId = Convert.ToInt32(textID.Text); // Obtener el ID del usuario seleccionado en el DataGridView

                if (selectedUserId != -1)
                {
                    string username = textUsername.Text;
                    string password = textPassword.Text;
                    int rol = Convert.ToInt32(numericRol.Value);
                    string genero = textGenero.Text;
                    string nombreUser = textNombre.Text;
                    string apellidoUser = textApellido.Text;
                    string emailUser = textEmail.Text;
                    string cedulaUser = textCedula.Text;

                    DialogResult result = MessageBox.Show("¿Estás seguro de que quieres actualizar este usuario?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        guardarUsuarioDomain guardarUsuarios = new guardarUsuarioDomain();

                        bool resultado = guardarUsuarios.ActualizarUsuario(selectedUserId, username, password, rol, genero, nombreUser, apellidoUser, emailUser, cedulaUser);

                        if (resultado)
                        {
                            MessageBox.Show("Usuario actualizado exitosamente!", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            log.Info($" El usuario {UserLoginCache.username.ToString()} acaba de actualizar el ID {selectedUserId}");

                            LimpiarTextBox();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            log.Info("Error en la actualización!");
                        }
                    }
                }
            }
        }


        private int GetSelectedUserId()
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
            if (string.IsNullOrEmpty(textUsername.Text) || string.IsNullOrEmpty(textNombre.Text) || string.IsNullOrEmpty(textApellido.Text) || string.IsNullOrEmpty(textEmail.Text) || string.IsNullOrEmpty(textCedula.Text) || string.IsNullOrEmpty(textGenero.Text))
            {
                MessageBox.Show("Para poder eliminar el registro, complete todos los campos", "Datos Incompletos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Info("Error en el registro!");
            }
            else
            {
                int selectedUserId = GetSelectedUserId(); // Obtener el ID del usuario seleccionado en el DataGridView

                if (selectedUserId != -1)
                {
                    // Mostrar una ventana de confirmación antes de eliminar
                    DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        guardarUsuarioDomain guardarUsuarios = new guardarUsuarioDomain();
                        bool resultado = guardarUsuarios.EliminarUsuario(selectedUserId);

                        if (resultado)
                        {
                            MessageBox.Show("Usuario eliminado exitosamente!", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            log.Info($" El usuario {UserLoginCache.username.ToString()} acaba de eliminar el ID {selectedUserId}");

                            // Limpiar las TextBox después de la eliminación
                            LimpiarTextBox();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            log.Info("Error en la eliminación!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona la fila entera para borrar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void LimpiarTextBox()
        {
            textID.Clear();
            textUsername.Clear();
            textPassword.Clear();
            textConfirmarPassword.Clear();
            textGenero.Clear();
            textNombre.Clear();
            textApellido.Clear();
            textEmail.Clear();
            textCedula.Clear();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBuscar.Text.Trim();

            dataViewUsuariosDomain DVU = new dataViewUsuariosDomain();

            // Llamar al método en la capa de dominio para obtener los datos filtrados
            List<object> usuariosFiltrados = DVU.ObtenerUsuariosFiltrados(searchText);

            // Actualizar el origen de datos del DataGridView con los resultados filtrados
            dataGrid.DataSource = usuariosFiltrados;
        }

        private void CargarDatosGrid()
        {
            
        }

        

        private void ButtonReload_Click(object sender, EventArgs e)
        {
            dataViewUsuariosDomain domain = new dataViewUsuariosDomain();
            DataTable usuariosTable = domain.viewDataUsuarioDomain();
            dataGrid.DataSource = usuariosTable;
        }
    }
}
