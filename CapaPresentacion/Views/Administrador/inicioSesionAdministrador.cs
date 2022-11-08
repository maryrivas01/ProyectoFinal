using CapaPresentacion.Middlewares;
using CapaPresentacion.Views.Administrador;
using CapaPresentacion.Views.Paciente;
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

namespace CapaPresentacion.Views
{
    public partial class inicioSesionAdministrador : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public inicioSesionAdministrador()
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

                        var data = from d in db.Usuarios
                                   where d.nombreUsuario == txtUsuario.Text
                                   && d.password == encryptPass
                                   select d;

                        if (data.Count() > 0)
                        {
                            SalaPrincipalAdministrador sala = new SalaPrincipalAdministrador();
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

        private void picExit_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void inicioSesionAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }
    }
}
