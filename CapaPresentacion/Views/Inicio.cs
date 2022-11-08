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
    public partial class Inicio : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public Inicio()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InicioSesiónPaciente usuario = new InicioSesiónPaciente();
            usuario.Show();
            this.Hide();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            inicioSesionAdministrador administrador = new inicioSesionAdministrador();
            administrador.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            inicioSesionMedico medico = new inicioSesionMedico();
            medico.Show();
            this.Hide();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
