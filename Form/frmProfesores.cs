using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IngresoEstudiantes
{
    public partial class frmProfesores : Form
    {
        private BusinessLogicLayer _businessLogicLayer;
        private void MensajeConfirmacion(String Mensaje)
        {
            MessageBox.Show(Mensaje, "Meteoro Corte", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DateTime InitFilter { get; }
        public frmProfesores()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
            btnEditar.Enabled = false;
            cmbCarrerPro.Items.Add("Ing sistemas");
            cmbCarrerPro.Items.Add("salud ocupacional");
            cmbCarrerPro.Items.Add("Facultad de Diseño");
            cmbCarrerPro.Items.Add("Facultad de Ciencias Jurídicas y Políticas");
            cmbCarrerPro.Items.Add("Facultad de Ciencias de la Salud");
            cmbCarrerPro.Items.Add("Facultad de Medicina Veterinaria");
            cmbCarrerPro.Items.Add("Facultad de Ciencias Empresariales");
            cmbCarrerPro.Items.Add("Facultad de Ciencias Contables");
            cmbCarrerPro.Items.Add("Facultad de Ingenierías");

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

        private void dataGridEstudiantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnguardarPro.Enabled = false;
            btnactualizar.Enabled = false;
            btnEditar.Enabled = true;
            txtCodPro.Text = dataGridEstudiantes.SelectedCells[0].Value.ToString();
            txtDocProfeso.Text = dataGridEstudiantes.SelectedCells[1].Value.ToString();
            txtNombPro.Text = dataGridEstudiantes.SelectedCells[2].Value.ToString();
            txtApellPro.Text = dataGridEstudiantes.SelectedCells[3].Value.ToString();
            cmbCarrerPro.Text = dataGridEstudiantes.SelectedCells[4].Value.ToString();
            cmbmunicipoes.Text = dataGridEstudiantes.SelectedCells[5].Value.ToString();
            txtfecha.Text = dataGridEstudiantes.SelectedCells[6].Value.ToString();
        }

        private void btnguardarPro_Click(object sender, EventArgs e)
        {
            if (txtDocProfeso.Text.Trim() != "" && txtNombPro.Text.Trim() != "" && txtApellPro.Text.Trim() != "" && cmbCarrerPro.Text.Trim() != "" && cmbmunicipoes.Text.Trim() != "")
            {
                var date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");

                // var startDate = date.ToString("yyyy-MM-ddTHH:mm:ss");
                Profesores profesores = new Profesores();

                profesores.Documento = txtDocProfeso.Text;
                profesores.Nombre = txtNombPro.Text;
                profesores.Apellido = txtApellPro.Text;
                profesores.Carrera = cmbCarrerPro.Text;
                profesores.Municipio = cmbmunicipoes.Text;
                profesores.Fecha = InitFilter;

                _businessLogicLayer.SaveProfesor(profesores);

                MensajeConfirmacion("Empleado registrado correctamente, Actualice la lista");
            }
            else
            {
                MensajeConfirmacion("LLene todos los campos");
            }

            Limpiar();

           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (txtDocProfeso.Text.Trim() != "" && txtNombPro.Text.Trim() != "" && txtApellPro.Text.Trim() != "" && cmbCarrerPro.Text.Trim() != "" && cmbmunicipoes.Text.Trim() != "")
            {
                var date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");

                // var startDate = date.ToString("yyyy-MM-ddTHH:mm:ss");
                Profesores profesores = new Profesores();
                profesores.Codigo=Convert.ToInt32(txtCodPro.Text);
                profesores.Documento = txtDocProfeso.Text;
                profesores.Nombre = txtNombPro.Text;
                profesores.Apellido = txtApellPro.Text;
                profesores.Carrera = cmbCarrerPro.Text;
                profesores.Municipio = cmbmunicipoes.Text;
               


                _businessLogicLayer.ActualizaProfesores(profesores);
                MensajeConfirmacion("Empleado Actualizado correctamente, Actualice La Lista");
                btnEditar.Enabled = false;
                Limpiar();
                btnactualizar.Enabled = true;
                btnguardarPro.Enabled = true;
                btnEditar.Enabled = false;
            }
            else
            {

                MensajeConfirmacion("LLene todos los campos");
            }

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


























        private void Limpiar()
        {
            txtCodPro.Text = string.Empty;
            txtDocProfeso.Text = string.Empty;
            txtNombPro.Text = string.Empty;
            txtApellPro.Text = string.Empty;
            cmbCarrerPro.Text = string.Empty;
            cmbmunicipoes.Text = string.Empty; ;
        }

        private void frmProfesores_Load(object sender, EventArgs e)
        {
            DetalleEstudiantes();
        }

        private void DetalleEstudiantes()
        {
            var date = DateTime.Now;
            dataGridEstudiantes.DataSource = BusinessLogicLayer.verlistaProfe(date);
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            DetalleEstudiantes();
        }
    }

 }

