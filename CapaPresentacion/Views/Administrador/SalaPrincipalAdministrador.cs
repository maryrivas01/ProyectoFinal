using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Views.Administrador
{
    public partial class SalaPrincipalAdministrador : Form
    {
        public SalaPrincipalAdministrador()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Medicamentos medicamento = new Medicamentos();
            medicamento.Show();
            this.Dispose();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Médico medico = new Médico();
            medico.Show();
            this.Dispose();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            inicioSesionAdministrador admin = new inicioSesionAdministrador();
            admin.Show();
            this.Dispose();
        }
    }
}
