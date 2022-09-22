using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IngresoEstudiantes
{
    public partial class frmRepEstudiantes : Form
    {
        private BusinessLogicLayer _businessLogicLayer;
        public frmRepEstudiantes()
        {
            InitializeComponent();

        }
        
        

        private void btnVerES_Click(object sender, EventArgs e)
        {
           
            var fefcha = dateTimeEstu.Value;
            dataGridRepES.DataSource = BusinessLogicLayer.verlista(fefcha);
        }
        public void DetalleEstudiantes()
        {

           
        }

        private void dataGridRepES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
