using CapaPresentacion.Middlewares;
using CapaPresentacion.Models;
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

namespace CapaPresentacion.Views.Paciente
{
    public partial class CrearCuenta : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public CrearCuenta()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        // Method to create an account
        public void CrearCuentaPaciente()
        {
            try
            {
                using (Models.FarmaciaLaboratorio_DaVida db = new Models.FarmaciaLaboratorio_DaVida())
                {
                    if (txtNombre.Text != "" && txtApellido.Text != "" && txtEdad.Text != "" && txtGenero.Text != "" && txtCodigo.Text != "" && txtContra.Text != "")
                    {
                        Pacientes account = new Pacientes
                        {
                            nombre = txtNombre.Text,
                            apellido = txtApellido.Text,
                            edad = Convert.ToInt32(txtEdad.Text),
                            genero = txtGenero.Text,
                            codigo = txtCodigo.Text,
                            contraPaciente = Encrypt.CreateSHA256(txtContra.Text),
                        };
                        db.Pacientes.Add(account);
                        try
                        {
                            db.SaveChanges();
                            ClearFields();
                            MessageBox.Show("Usuario creado satisfactoriamente!\n" + "Ahora puede iniciar sesión", "Usuario creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            db.SaveChanges();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No pueden estar los campos vacíos!", "Advertencia: Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtGenero.Clear();
            txtCodigo.Clear();
            txtContra.Clear();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            CrearCuentaPaciente();
        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            InicioSesiónPaciente paciente = new InicioSesiónPaciente();
            paciente.Show();
            this.Dispose();
        }
    }
}
