using Comun.Cache;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using log4net.Config;


namespace Presentacion
{

    public partial class MainMenu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form actualformHijo;
        private UserControl userControlActual;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //Main 
        public MainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);
            //form
            //this.Text = string.Empty;
            //this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            LoadUserData();
            permisos();
            

            
        }

        //Permisos hechos para que lo vea cada uno
        private void permisos()
        {
            //que no puede hacer este rol
            if (UserLoginCache.rol == cargos.Administrador || UserLoginCache.rol == cargos.Mantenimiento)
            {

            }

            //Que no puede hacer este rol
            if (UserLoginCache.rol == cargos.Usuario)
            {
                buttomUsuarios.Enabled = false;
                buttomUsuarios.Visible = false;

            }

            //Que no pueden hacer estos roles
            if (UserLoginCache.rol == cargos.Consultas)
            {
                buttomUsuarios.Enabled = false;
                buttomUsuarios.Visible = false;

                buttomClientes.Enabled = false;
                buttomClientes.Visible = false;

                buttomCotizaciones.Enabled = false;
                buttomCotizaciones.Visible = false;

                ButtomCobrar.Enabled = false;
                ButtomCobrar.Visible = false;

                buttomServicios.Enabled = false;
                buttomServicios.Visible = false;
            }
        }

        //Color para el efecto de cuando haces click en una de las CRUD
        private struct RGBColors
        {
            
            public static Color color4 = Color.FromArgb(95, 77, 221);
           
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                //currentBtn.BackColor = Color.FromArgb(192, 169, 126);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                buttomHome.IconChar = currentBtn.IconChar;
                buttomHome.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //currentBtn.BackColor = Color.FromArgb(192, 169, 126);
                currentBtn.ForeColor = Color.FromName("ControlDarkDark");
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromName("ControlDarkDark");
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void abrirFormHijo(Form hijoForm)
        {
            if (actualformHijo != null) 
            { 
                actualformHijo.Close();
            }

            actualformHijo = hijoForm;
            hijoForm.TopLevel = false;
            hijoForm.FormBorderStyle = FormBorderStyle.None;
            hijoForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(hijoForm);
            panelDesktop.Tag = hijoForm;
            hijoForm.BringToFront();
            hijoForm.Show();
            labelHome.Text = hijoForm.Text;
        }
        
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            buttomHome.IconChar = IconChar.Home;
            buttomHome.IconColor = Color.FromName("ControlDarkDark");
            labelHome.Text = "Home";
            abrirFormHijo(new Presentacion.Forms.mainForm());
        }

        private void buttomUsuarios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            abrirFormHijo(new Presentacion.Forms.Usuarios());
        }

        private void buttomProducto_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBColors.color4);
            abrirFormHijo(new Presentacion.Forms.Productos());
        }

        private void buttomClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            abrirFormHijo(new Presentacion.Forms.Clientes());
        }

        private void buttomServicios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            abrirFormHijo(new Presentacion.Forms.Servicios());
        }

        private void buttomCotizaciones_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            abrirFormHijo(new Presentacion.Forms.Cotizaciones());
        }

        private void buttomFacturas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            abrirFormHijo(new Presentacion.Forms.Facturas());
        }

        private void ButtomCobrar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            abrirFormHijo(new Presentacion.Forms.Cobro());
        }

        private void labelHome_Click(object sender, EventArgs e)
        {

        }

        private void buttomHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Arrastrar Ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttomClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de cerrar la app?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                log.Info($"El usuario {labelUsername.Text} con permiso {labelPocision.Text} cerro seccion");

                Application.Exit();

                
            }
            
        }

        private void buttomMaximaze_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                buttomMaximaze.IconChar = IconChar.WindowRestore;
                
            }
            else
            {
                WindowState = FormWindowState.Normal;
                buttomMaximaze.IconChar = IconChar.WindowMaximize;
            }
                
        }

        private void buttomMinus_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Boton de logout
        private void buttomLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Estas seguro de cerrar seccion?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                log.Info($"El usuario {labelUsername.Text} con permiso {labelPocision.Text} cerro seccion");

                this.Close();

                
            }
        }

        //Para tener el nombre y el rol en el menu Usando el cache
        private void LoadUserData()
        {
            labelUsername.Text = UserLoginCache.username;
            //labelMail.Text = UserLoginCache.emailUser;

            if (UserLoginCache.rol == 1)
            {
                labelPocision.Text = "Administrador"; 
            }
            if (UserLoginCache.rol == 2)
            {
                labelPocision.Text = "Mantenimiento";
            }
            if (UserLoginCache.rol == 3)
            {
                labelPocision.Text = "Usuario";
            }
            if (UserLoginCache.rol == 4)
            {
                labelPocision.Text = "Consulta";
            }


        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
