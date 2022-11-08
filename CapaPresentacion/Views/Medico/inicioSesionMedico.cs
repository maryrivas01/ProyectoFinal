using CapaPresentacion.Middlewares;
using CapaPresentacion.Views.Medico;
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
    public partial class inicioSesionMedico : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public inicioSesionMedico()
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
                    if (txtCódigo.Text != "" && txtPass.Text != "")
                    {
                        var data = from d in db.Doctores
                                   where d.codigo == txtCódigo.Text
                                   && d.contraMedico == txtPass.Text
                                   select d;

                        if (data.Count() > 0)
                        {
                            SalaPrincipalMedico sala = new SalaPrincipalMedico();
                            ClearFields();
                            sala.Show();
                            this.Hide();
                        }
                        else
                        {
                            ClearFields();
                            MessageBox.Show("El usuario no Existe!");
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
            txtCódigo.Clear();
            txtPass.Clear();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Dispose();
        }

        private void inicioSesionMedico_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion();
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
    }
}
