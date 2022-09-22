using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace IngresoEstudiantes
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            AbrirFormulariohija(new frmInicio());
           
        }
        private void AbrirFormulariohija(object formhija)
        {
            if (this.pnContenedor.Controls.Count > 0)
                this.pnContenedor.Controls.RemoveAt(0);
            Form forhija = formhija as Form;
            forhija.TopLevel = false;
            forhija.Dock = DockStyle.Fill;
            this.pnContenedor.Controls.Add(forhija);
            this.pnContenedor.Tag = forhija;
            forhija.Show();

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
           
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
         [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int lParam, int wParam );

        private void pnBarradeTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112, 0xf012, 0);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            pnSubMenuReporte.Visible = true;
        }

        private void btnrepEstudiantes_Click(object sender, EventArgs e)
        {
            pnSubMenuReporte.Visible = false;
            AbrirFormulariohija(new frmRepEstudiantes());
        }

        private void btnrepProfesores_Click(object sender, EventArgs e)
        {
            pnSubMenuReporte.Visible = false;
            AbrirFormulariohija(new frmRepProfesores());
        }

        private void btnrepPlanta_Click(object sender, EventArgs e)
        {
            pnSubMenuReporte.Visible = false;
            AbrirFormulariohija(new frmRepPlanta());
        }

       
        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            pnSubMenuReporte.Visible = false;
            AbrirFormulariohija(new frmEstudiantes());
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            pnSubMenuReporte.Visible = false;
            AbrirFormulariohija(new frmInicio());
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            pnSubMenuReporte.Visible = false;
            AbrirFormulariohija(new frmProfesores());
        }

        private void btnPlanta_Click(object sender, EventArgs e)
        {
            pnSubMenuReporte.Visible = false;
            AbrirFormulariohija(new frmPlanta());
        }

       
    }
}
