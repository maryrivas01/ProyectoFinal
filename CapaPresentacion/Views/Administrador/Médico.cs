using CapaNegocio;
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

namespace CapaPresentacion.Views.Administrador
{
    public partial class Médico : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public Médico()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        CN_Doctores objetoCN = new CN_Doctores();
        private string idMedico = null;
        private bool Editar = false;

        private void MostrarMedicos()
        {
            CN_Doctores objeto = new CN_Doctores();
            dgvMedicos.DataSource = objeto.MostrarDoc();
        }

        private void GuardarMedico()
        {
            try
            {
                if (txtNombre.Text != "" && txtApellido.Text != "" && txtEdad.Text != "" && txtGenero.Text != "" && txtEspecialidad.Text != "" && txtCodigo.Text != "" && txtContra.Text != "")
                {
                    if (Editar == false)
                    {
                        try
                        {
                            objetoCN.CrearDoc(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtEdad.Text),txtGenero.Text, txtEspecialidad.Text, txtCodigo.Text, txtContra.Text);
                            MessageBox.Show("Médico se creó correctamente!", "´Médico Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarMedicos();
                            limpiarCampos();
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"No se pudo crear el registro del Médico: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (Editar == true)
                    {
                        try
                        {
                            objetoCN.EditarDoc(txtNombre.Text, txtApellido.Text, txtEdad.Text, txtGenero.Text, txtEspecialidad.Text, txtCodigo.Text, txtContra.Text, idMedico);
                            MessageBox.Show("Médico se editó correctamente", "Editado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarMedicos();
                            limpiarCampos();
                            Editar = false;
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"No se pudo editar el registro del Médico: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Faltan ingresar algunos datos", "Advertencia: Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Se produjo el siguiente error: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarMedico()
        {
            try
            {
                if (dgvMedicos.SelectedRows.Count > 0)
                {
                    Editar = true;
                    txtNombre.Text = dgvMedicos.CurrentRow.Cells["nombre"].Value.ToString();
                    txtApellido.Text = dgvMedicos.CurrentRow.Cells["apellido"].Value.ToString();
                    txtEdad.Text = dgvMedicos.CurrentRow.Cells["edad"].Value.ToString();
                    txtGenero.Text = dgvMedicos.CurrentRow.Cells["genero"].Value.ToString();
                    txtEspecialidad.Text = dgvMedicos.CurrentRow.Cells["especialidad"].Value.ToString();
                    txtCodigo.Text = dgvMedicos.CurrentRow.Cells["codigo"].Value.ToString();
                    txtContra.Text = dgvMedicos.CurrentRow.Cells["contraMedico"].Value.ToString();
                    idMedico = dgvMedicos.CurrentRow.Cells["id"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Seleccione una fila por favor", "Ítem no Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Se produjo el siguiente error: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarMedico()
        {
            try
            {
                if (dgvMedicos.SelectedRows.Count > 0)
                {
                    idMedico = dgvMedicos.CurrentRow.Cells["id"].Value.ToString();
                    objetoCN.EliminarDoc(idMedico);
                    MessageBox.Show("Medico eliminado correctamente!", "Medico Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarMedicos();
                }
                else
                {
                    MessageBox.Show("seleccione una fila por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Se produjo el siguiente error: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarCampos()
        {
            txtApellido.Clear();
            txtGenero.Clear();
            txtCodigo.Text = "";
            txtContra.Clear();
            txtEdad.Clear();
            txtEspecialidad.Clear();
            txtNombre.Clear();
        }

        private void Médico_Load(object sender, EventArgs e)
        {
            MostrarMedicos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarMedico();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarMedico();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarMedico();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            SalaPrincipalAdministrador admin = new SalaPrincipalAdministrador();
            admin.Show();
            this.Dispose();
        }
    }
}
