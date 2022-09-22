using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IngresoEstudiantes
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl2hora.Text = DateTime.Now.ToString("G");
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
