using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IngresoEstudiantes
{
   
    public partial class frmRepProfesores : Form
    {
        public frmRepProfesores()
        {
            InitializeComponent();
        }

        private void btnVerProf_Click(object sender, EventArgs e)
        {
            var fefcha = timeprofe.Value;
            dataGridRepProf.DataSource = BusinessLogicLayer.verlistaProfe(fefcha);
        }
    }
}
