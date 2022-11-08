using CapaNegocio;
using CapaPresentacion.Views.Administrador;
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
    public partial class Medicamentos : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public Medicamentos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        CN_Medicamentos objetoCN = new CN_Medicamentos();
        private string idMedicamento = null;
        private bool Editar = false;

        private void MostrarMedicamentos()
        {
            CN_Medicamentos objeto = new CN_Medicamentos();
            dgvMedicamentos.DataSource = objeto.MostrarMed();
        }

        private void GuardarMedicamento()
        {
            try
            {
                if (txtNombre.Text != "" && txtDesc.Text != "" && txtEfectosSec.Text != "" && txtMarca.Text != "" && txtPrecio.Text != "" && txtStock.Text != "")
                {
                    if (Editar == false)
                    {
                        try
                        {
                            objetoCN.CrearMed(txtNombre.Text, txtDesc.Text, txtEfectosSec.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text);
                            MessageBox.Show("Su medicamento se creó correctamente!", "Medicamento Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarMedicamentos();
                            limpiarCampos();
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"No se pudo crear el medicamento: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (Editar == true)
                    {
                        try
                        {
                            objetoCN.EditarMed(txtNombre.Text, txtDesc.Text, txtEfectosSec.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, idMedicamento);
                            MessageBox.Show("Su medicamento se editó correctamente", "Editado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarMedicamentos();
                            limpiarCampos();
                            Editar = false;
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"No se pudo editar lel medicamento: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ActualizarMedicamento()
        {
            try
            {
                if (dgvMedicamentos.SelectedRows.Count > 0)
                {
                    Editar = true;
                    txtNombre.Text = dgvMedicamentos.CurrentRow.Cells["nombre"].Value.ToString();
                    txtMarca.Text = dgvMedicamentos.CurrentRow.Cells["marca"].Value.ToString();
                    txtDesc.Text = dgvMedicamentos.CurrentRow.Cells["descripcion"].Value.ToString();
                    txtEfectosSec.Text = dgvMedicamentos.CurrentRow.Cells["efectosSecundarios"].Value.ToString();
                    txtPrecio.Text = dgvMedicamentos.CurrentRow.Cells["precio"].Value.ToString();
                    txtStock.Text = dgvMedicamentos.CurrentRow.Cells["stock"].Value.ToString();
                    idMedicamento = dgvMedicamentos.CurrentRow.Cells["id"].Value.ToString();
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

        private void EliminarMedicamento()
        {
            try
            {
                if (dgvMedicamentos.SelectedRows.Count > 0)
                {
                    idMedicamento = dgvMedicamentos.CurrentRow.Cells["id"].Value.ToString();
                    objetoCN.EliminarMed(idMedicamento);
                    MessageBox.Show("Medicamento eliminado correctamente!", "Medicamento Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarMedicamentos();
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
            txtDesc.Clear();
            txtEfectosSec.Clear();
            txtMarca.Text = "";
            txtPrecio.Clear();
            txtStock.Clear();
            txtNombre.Clear();
        }

        private void Medicamentos_Load(object sender, EventArgs e)
        {
            MostrarMedicamentos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarMedicamento();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarMedicamento();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarMedicamento();
        }

        private void txtEfectosSec_TextChanged(object sender, EventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            SalaPrincipalAdministrador sala = new SalaPrincipalAdministrador();
            sala.Show();
            this.Dispose();
        }
    }
}
