using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IngresoEstudiantes
{
    public partial class frmEstudiantes : Form
    {
        private BusinessLogicLayer _businessLogicLayer;

        public DateTime InitFilter { get; }

        public frmEstudiantes()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
            btnEditar.Enabled = false;
            cmbcarreraes.Items.Add("Ing sistemas");
            cmbcarreraes.Items.Add("salud ocupacional");
            cmbcarreraes.Items.Add("Facultad de Diseño");
            cmbcarreraes.Items.Add("Facultad de Ciencias Jurídicas y Políticas");
            cmbcarreraes.Items.Add("Facultad de Ciencias de la Salud");
            cmbcarreraes.Items.Add("Facultad de Medicina Veterinaria");
            cmbcarreraes.Items.Add("Facultad de Ciencias Empresariales");
            cmbcarreraes.Items.Add("Facultad de Ciencias Contables");
            cmbcarreraes.Items.Add("Facultad de Ingenierías");

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
        private void MensajeConfirmacion(String Mensaje)
        {
            MessageBox.Show(Mensaje, "Meteoro Corte", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dataGridEstudiantere_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnguardares.Enabled = false;
            btnactualizar.Enabled = false;
            btnEditar.Enabled = true;
            txtcodigoes.Text = dataGridEstudiantere.SelectedCells[0].Value.ToString();
            txtdocumentoes.Text = dataGridEstudiantere.SelectedCells[1].Value.ToString();
            textnombrees.Text = dataGridEstudiantere.SelectedCells[2].Value.ToString();
            texapellidoes.Text = dataGridEstudiantere.SelectedCells[3].Value.ToString();
            cmbcarreraes.Text = dataGridEstudiantere.SelectedCells[4].Value.ToString();
            cmbmunicipoes.Text = dataGridEstudiantere.SelectedCells[5].Value.ToString();
            txtfecha.Text= dataGridEstudiantere.SelectedCells[6].Value.ToString();
        }

        private void btnguardares_Click_1(object sender, EventArgs e)
        {
            if (txtdocumentoes.Text.Trim() != "" && textnombrees.Text.Trim() != "" && texapellidoes.Text.Trim() != "" && cmbcarreraes.Text.Trim() != "" && cmbmunicipoes.Text.Trim() != "")
            {
                var date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");

               // var startDate = date.ToString("yyyy-MM-ddTHH:mm:ss");
                Estudiantes estudiantes = new Estudiantes();

                estudiantes.Documento = txtdocumentoes.Text;
                estudiantes.Nombre = textnombrees.Text;
                estudiantes.Apellido = texapellidoes.Text;
                estudiantes.Carrera = cmbcarreraes.Text;
                estudiantes.Municipio = cmbmunicipoes.Text;
                estudiantes.Fecha = InitFilter;

                _businessLogicLayer.Saveestudiante(estudiantes);

                MensajeConfirmacion("Empleado registrado correctamente, Actualice la lista");
            }
            else
            {
                MensajeConfirmacion("LLene todos los campos");
            }

            Limpiar();
        }

        private void btnguardares_Click(object sender, EventArgs e)
        {
           
          
        }
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
          

            if  (txtcodigoes.Text.Trim() != "" && txtdocumentoes.Text.Trim() != "" && textnombrees.Text.Trim() != "" && texapellidoes.Text.Trim() != "" && cmbcarreraes.Text.Trim() != "" && cmbmunicipoes.Text.Trim() != "")
           { Estudiantes estudiantes = new Estudiantes();
                estudiantes.Codigo = Convert.ToInt32(txtcodigoes.Text);
                estudiantes.Documento = txtdocumentoes.Text;
                estudiantes.Nombre = textnombrees.Text;
                estudiantes.Apellido = texapellidoes.Text;
                estudiantes.Carrera = cmbcarreraes.Text;
                estudiantes.Municipio = cmbmunicipoes.Text;
                

                _businessLogicLayer.Actualizarestudiante(estudiantes);
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

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            DetalleEstudiantes();
        }

        public void DetalleEstudiantes()
        {
            var date = DateTime.Now;
            dataGridEstudiantere.DataSource = BusinessLogicLayer.verlista(date);
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            DetalleEstudiantes();
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

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
