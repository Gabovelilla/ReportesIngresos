using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IngresoEstudiantes
{
    public partial class frmRepPlanta : Form
    {
        public frmRepPlanta()
        {
            InitializeComponent();
        }

        private void btnVerPla_Click(object sender, EventArgs e)
        {
            var fefcha = dateTimePlant.Value;
            dataGridRePlant.DataSource = BusinessLogicLayer.verlistaPlanta(fefcha);
        }
    }
}
