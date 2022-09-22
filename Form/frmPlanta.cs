using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IngresoEstudiantes
{
    public partial class frmPlanta : Form
    {
        private BusinessLogicLayer _businessLogicLayer;

        public DateTime InitFilter { get; }

        public frmPlanta()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
            btnEditar.Enabled = false;
            cmbcarreraes.Items.Add("DIRECTOR");
            cmbcarreraes.Items.Add("CORDINADOR ACADEMICO");
            cmbcarreraes.Items.Add("AUXILIAR ADMINISTRATIVO");
            cmbcarreraes.Items.Add("PRECTICANTE");
            cmbcarreraes.Items.Add("SERVICIO GENERAL");
            cmbcarreraes.Items.Add("SEGURIDAD");
            cmbcarreraes.Items.Add("VISITANTE");
            cmbcarreraes.Items.Add("AUXILIAR COMERCIAL");
            cmbcarreraes.Items.Add("CAFETERIA");




            cmbmunicipoes.Items.Add("RIONEGRO");
            cmbmunicipoes.Items.Add("LA CEJA");
            cmbmunicipoes.Items.Add("LA UNION");
            cmbmunicipoes.Items.Add("MARINILLA");
            cmbmunicipoes.Items.Add("SANTUARIO");
            cmbmunicipoes.Items.Add("EL PE;OL");
            cmbmunicipoes.Items.Add("COCORNA");
            cmbmunicipoes.Items.Add("SAN RAFAEL");
            cmbmunicipoes.Items.Add("MEDELLIN");
            cmbmunicipoes.Items.Add("ENVIGADO");
            cmbmunicipoes.Items.Add("SABANETA");
            cmbmunicipoes.Items.Add("GUATAPE");
            cmbmunicipoes.Items.Add("ABEJORRAL");
            cmbmunicipoes.Items.Add("NARI;O");
            cmbmunicipoes.Items.Add("RETIRO");

            InitFilter = DateTime.Now;
            btnEditar.Enabled = false;

        }

        private void dataGridEstudiantere_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnguardares.Enabled = false;
            btnactualizar.Enabled = false;
            btnEditar.Enabled = true;
            txtcodigoes.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtdocumentoes.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textnombrees.Text = dataGridView1.SelectedCells[2].Value.ToString();
            texapellidoes.Text = dataGridView1.SelectedCells[3].Value.ToString();
            cmbcarreraes.Text = dataGridView1.SelectedCells[4].Value.ToString();
            cmbmunicipoes.Text = dataGridView1.SelectedCells[5].Value.ToString();
            txtfecha.Text = dataGridView1.SelectedCells[6].Value.ToString();
        }


        private void MensajeConfirmacion(String Mensaje)
        {
            MessageBox.Show(Mensaje, "Meteoro Corte", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardarPL_Click(object sender, EventArgs e)
        {
           
        }

        private void Limpiar()
        {
            txtcodigoes.Text = string.Empty;
            txtdocumentoes.Text = string.Empty;
            textnombrees.Text = string.Empty;
            texapellidoes.Text = string.Empty;
            txtdocumentoes.Text = string.Empty;
            cmbcarreraes.Text = string.Empty;
            cmbmunicipoes.Text = string.Empty;
        }

        private void frmPlanta_Load(object sender, EventArgs e)
        {
            DetallePlanta();
        }

        private void DetallePlanta()
        {
            var date = DateTime.Now;
           dataGridView1.DataSource = BusinessLogicLayer.verlistaPlanta(date);
        }
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            DetallePlanta();
        }

        private void txtdocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void texapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > 0))
            {
                e.Handled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtcodigoes.Text.Trim() != "" && txtdocumentoes.Text.Trim() != "" && textnombrees.Text.Trim() != "" && texapellidoes.Text.Trim() != "" && cmbcarreraes.Text.Trim() != "" && cmbmunicipoes.Text.Trim() != "")
            {
                Planta planta = new Planta();
                planta.Codigo = Convert.ToInt32(txtcodigoes.Text);
                planta.Documento = txtdocumentoes.Text;
                planta.Nombre = textnombrees.Text;
                planta.Apellido = texapellidoes.Text;
                planta.Cargo = cmbcarreraes.Text;
                planta.Municipio = cmbmunicipoes.Text;


                _businessLogicLayer.ActualizarPlanta(planta);
                MensajeConfirmacion("Empleado Actualizado correctamente, Actualice La Lista");
                btnEditar.Enabled = false;
                Limpiar();
                btnactualizar.Enabled = true;
                btnguardares.Enabled = true;
                btnEditar.Enabled = false;
            }
            else
            {

                MensajeConfirmacion("LLene todos los campos");
            }
        }

        private void btnguardares_Click(object sender, EventArgs e)
        {
            if (txtdocumentoes.Text.Trim() != "" && textnombrees.Text.Trim() != "" && texapellidoes.Text.Trim() != "" && cmbcarreraes.Text.Trim() != "" && cmbmunicipoes.Text.Trim() != "")
            {
                var date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");

                // var startDate = date.ToString("yyyy-MM-ddTHH:mm:ss");
                Planta planta = new Planta();

                planta.Documento = txtdocumentoes.Text;
                planta.Nombre = textnombrees.Text;
                planta.Apellido = texapellidoes.Text;
                planta.Cargo = cmbcarreraes.Text;
                planta.Municipio = cmbmunicipoes.Text;
                planta.Fecha = InitFilter;

                _businessLogicLayer.SavePlanta(planta);
                Limpiar();
                MensajeConfirmacion("Empleado registrado correctamente, Actualice la lista");
            }
            else
            {
                MensajeConfirmacion("LLene todos los campos");
            }

            
        }

        private void btnactualizar_Click_1(object sender, EventArgs e)
        {
            DetallePlanta();
        }
        private void txtdocumentoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textnombrees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void texapellidoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtcodigoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > 0))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnguardares.Enabled = false;
            btnactualizar.Enabled = false;
            btnEditar.Enabled = true;
            txtcodigoes.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtdocumentoes.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textnombrees.Text = dataGridView1.SelectedCells[2].Value.ToString();
            texapellidoes.Text = dataGridView1.SelectedCells[3].Value.ToString();
            cmbcarreraes.Text = dataGridView1.SelectedCells[4].Value.ToString();
            cmbmunicipoes.Text = dataGridView1.SelectedCells[5].Value.ToString();
            txtfecha.Text = dataGridView1.SelectedCells[6].Value.ToString();
        }
    }
}
