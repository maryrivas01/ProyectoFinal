using CapaPresentacion.Middlewares;
using CapaPresentacion.Models;
using CapaPresentacion.Views;
using CapaPresentacion.Views.Paciente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class InicioSesiónPaciente : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public InicioSesiónPaciente()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        // Login Method
        public void IniciarSesion()
        {
            try
            {
                using (Models.FarmaciaLaboratorio_DaVida db = new Models.FarmaciaLaboratorio_DaVida())
                {
                    if (txtUsuario.Text != "" && txtPass.Text != "")
                    {
                        string encryptPass = Encrypt.GetSHA256(txtPass.Text.Trim());

                        var data = from d in db.Pacientes
                                   where d.codigo == txtUsuario.Text
                                   && d.contraPaciente == encryptPass
                                   select d;

                        if (data.Count() > 0)
                        {
                            salaPrincipalPaciente sala = new salaPrincipalPaciente();
                            ClearFields();
                            sala.Show();
                            this.Hide();
                        }
                        else
                        {
                            ClearFields();
                            MessageBox.Show("El usuario no Existe en la base de datos!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No pueden estar los campos vacíos!");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void ClearFields()
        {
            txtUsuario.Clear();
            txtPass.Clear();
        }

        private void InicioSesión_Load(object sender, EventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void pbHide_Click(object sender, EventArgs e)
        {
            pbShow.BringToFront();
            txtPass.PasswordChar = '*';
        }

        private void pbShow_Click(object sender, EventArgs e)
        {
            pbHide.BringToFront();
            txtPass.PasswordChar = '\0';
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            CrearCuenta cuenta = new CrearCuenta();
            cuenta.Show();
            this.Dispose();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void lblForgetPass_Click(object sender, EventArgs e)
        {
            ContraOlvidada formularioContraseña = new ContraOlvidada();
            formularioContraseña.Show();
            this.Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
