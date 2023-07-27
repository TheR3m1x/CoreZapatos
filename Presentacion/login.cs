using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;
using log4net;
using log4net.Config;
using System.IO;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using System.Drawing.Text;
using Dominio;
using Comun.Cache;

namespace Presentacion
{
    public partial class login : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        

        public login()
        {
            InitializeComponent();

            log.Info("Abrio!");

            
        }

       

        private void buttomLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text != "")
            {
                if (txtPassword.Text != "")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUsername.Text, txtPassword.Text);
                    if (validLogin == true)
                    {
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.Show();
                        this.Hide();
                        mainMenu.FormClosed += logout;

                        log.Info($"El usuario {txtUsername.Text} ha ingresado al core!");
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña inválido. Intentelo nuevamente.", "Fallo el Login!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Clear();
                        txtUsername.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Falta la contraseña.", "Fallo el Login!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Falta el nombre de Usuario.", "Fallo el Login!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void logout(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            this.Show();
            txtUsername.Focus();
        }

        private void buttomClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void checkboxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void minimizePicture_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closePicture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        //Arrastrar Ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttomClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttomMinus_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
