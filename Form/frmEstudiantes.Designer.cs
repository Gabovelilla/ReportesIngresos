
namespace IngresoEstudiantes
{
    partial class frmEstudiantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstudiantes));
            this.label1 = new System.Windows.Forms.Label();
            this.txtdocumentoes = new System.Windows.Forms.TextBox();
            this.textnombrees = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridEstudiantere = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbcarreraes = new System.Windows.Forms.ComboBox();
            this.cmbmunicipoes = new System.Windows.Forms.ComboBox();
            this.texapellidoes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcodigoes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnguardares = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.gbPeridPro = new System.Windows.Forms.GroupBox();
            this.checper01Pr = new System.Windows.Forms.CheckBox();
            this.checper02Pro = new System.Windows.Forms.CheckBox();
            this.gbvincuPro = new System.Windows.Forms.GroupBox();
            this.checSIPro = new System.Windows.Forms.CheckBox();
            this.checNOPro = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstudiantere)).BeginInit();
            this.gbPeridPro.SuspendLayout();
            this.gbvincuPro.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(83, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOCUMENTO ";
            // 
            // txtdocumentoes
            // 
            this.txtdocumentoes.BackColor = System.Drawing.SystemColors.Info;
            this.txtdocumentoes.Location = new System.Drawing.Point(54, 227);
            this.txtdocumentoes.Name = "txtdocumentoes";
            this.txtdocumentoes.Size = new System.Drawing.Size(183, 30);
            this.txtdocumentoes.TabIndex = 1;
            this.txtdocumentoes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdocumentoes_KeyPress);
            // 
            // textnombrees
            // 
            this.textnombrees.BackColor = System.Drawing.SystemColors.Info;
            this.textnombrees.Location = new System.Drawing.Point(245, 227);
            this.textnombrees.Name = "textnombrees";
            this.textnombrees.Size = new System.Drawing.Size(273, 30);
            this.textnombrees.TabIndex = 3;
            this.textnombrees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textnombrees_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(334, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(83, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "CARRERA";
            // 
            // dataGridEstudiantere
            // 
            this.dataGridEstudiantere.AllowUserToAddRows = false;
            this.dataGridEstudiantere.AllowUserToDeleteRows = false;
            this.dataGridEstudiantere.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridEstudiantere.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEstudiantere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstudiantere.Location = new System.Drawing.Point(14, 509);
            this.dataGridEstudiantere.Name = "dataGridEstudiantere";
            this.dataGridEstudiantere.ReadOnly = true;
            this.dataGridEstudiantere.RowHeadersWidth = 51;
            this.dataGridEstudiantere.RowTemplate.Height = 29;
            this.dataGridEstudiantere.Size = new System.Drawing.Size(1251, 296);
            this.dataGridEstudiantere.TabIndex = 6;
            this.dataGridEstudiantere.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEstudiantere_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(334, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "MUNICIPIO";
            // 
            // cmbcarreraes
            // 
            this.cmbcarreraes.BackColor = System.Drawing.SystemColors.Info;
            this.cmbcarreraes.FormattingEnabled = true;
            this.cmbcarreraes.Location = new System.Drawing.Point(54, 309);
            this.cmbcarreraes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbcarreraes.Name = "cmbcarreraes";
            this.cmbcarreraes.Size = new System.Drawing.Size(237, 31);
            this.cmbcarreraes.TabIndex = 10;
            // 
            // cmbmunicipoes
            // 
            this.cmbmunicipoes.BackColor = System.Drawing.SystemColors.Info;
            this.cmbmunicipoes.FormattingEnabled = true;
            this.cmbmunicipoes.Location = new System.Drawing.Point(304, 309);
            this.cmbmunicipoes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbmunicipoes.Name = "cmbmunicipoes";
            this.cmbmunicipoes.Size = new System.Drawing.Size(237, 31);
            this.cmbmunicipoes.TabIndex = 11;
            // 
            // texapellidoes
            // 
            this.texapellidoes.BackColor = System.Drawing.SystemColors.Info;
            this.texapellidoes.Location = new System.Drawing.Point(528, 227);
            this.texapellidoes.Name = "texapellidoes";
            this.texapellidoes.Size = new System.Drawing.Size(273, 30);
            this.texapellidoes.TabIndex = 15;
            this.texapellidoes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texapellidoes_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(657, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "APELLIDO";
            // 
            // txtcodigoes
            // 
            this.txtcodigoes.BackColor = System.Drawing.SystemColors.Info;
            this.txtcodigoes.Enabled = false;
            this.txtcodigoes.Location = new System.Drawing.Point(54, 146);
            this.txtcodigoes.Name = "txtcodigoes";
            this.txtcodigoes.Size = new System.Drawing.Size(177, 30);
            this.txtcodigoes.TabIndex = 17;
            this.txtcodigoes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigoes_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(90, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "CODIGO";
            // 
            // btnguardares
            // 
            this.btnguardares.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnguardares.Image = ((System.Drawing.Image)(resources.GetObject("btnguardares.Image")));
            this.btnguardares.Location = new System.Drawing.Point(54, 396);
            this.btnguardares.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnguardares.Name = "btnguardares";
            this.btnguardares.Size = new System.Drawing.Size(154, 77);
            this.btnguardares.TabIndex = 59;
            this.btnguardares.Text = "GUARDAR";
            this.btnguardares.UseVisualStyleBackColor = false;
            this.btnguardares.Click += new System.EventHandler(this.btnguardares_Click_1);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnactualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.Image")));
            this.btnactualizar.Location = new System.Drawing.Point(490, 417);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(173, 56);
            this.btnactualizar.TabIndex = 60;
            this.btnactualizar.Text = "ACTUALIZAR LISTA";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEditar.Location = new System.Drawing.Point(276, 417);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(118, 56);
            this.btnEditar.TabIndex = 61;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // txtfecha
            // 
            this.txtfecha.BackColor = System.Drawing.SystemColors.Info;
            this.txtfecha.Location = new System.Drawing.Point(822, 227);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(273, 30);
            this.txtfecha.TabIndex = 62;
            this.txtfecha.Visible = false;
            // 
            // gbPeridPro
            // 
            this.gbPeridPro.Controls.Add(this.checper01Pr);
            this.gbPeridPro.Controls.Add(this.checper02Pro);
            this.gbPeridPro.Location = new System.Drawing.Point(757, 282);
            this.gbPeridPro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbPeridPro.Name = "gbPeridPro";
            this.gbPeridPro.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbPeridPro.Size = new System.Drawing.Size(142, 86);
            this.gbPeridPro.TabIndex = 64;
            this.gbPeridPro.TabStop = false;
            this.gbPeridPro.Text = "PERIODO";
            // 
            // checper01Pr
            // 
            this.checper01Pr.AutoSize = true;
            this.checper01Pr.Location = new System.Drawing.Point(8, 33);
            this.checper01Pr.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checper01Pr.Name = "checper01Pr";
            this.checper01Pr.Size = new System.Drawing.Size(50, 27);
            this.checper01Pr.TabIndex = 13;
            this.checper01Pr.Text = "01";
            this.checper01Pr.UseVisualStyleBackColor = true;
            // 
            // checper02Pro
            // 
            this.checper02Pro.AutoSize = true;
            this.checper02Pro.Location = new System.Drawing.Point(74, 33);
            this.checper02Pro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checper02Pro.Name = "checper02Pro";
            this.checper02Pro.Size = new System.Drawing.Size(50, 27);
            this.checper02Pro.TabIndex = 12;
            this.checper02Pro.Text = "02";
            this.checper02Pro.UseVisualStyleBackColor = true;
            // 
            // gbvincuPro
            // 
            this.gbvincuPro.Controls.Add(this.checSIPro);
            this.gbvincuPro.Controls.Add(this.checNOPro);
            this.gbvincuPro.Location = new System.Drawing.Point(609, 282);
            this.gbvincuPro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbvincuPro.Name = "gbvincuPro";
            this.gbvincuPro.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbvincuPro.Size = new System.Drawing.Size(142, 86);
            this.gbvincuPro.TabIndex = 63;
            this.gbvincuPro.TabStop = false;
            this.gbvincuPro.Text = "MATRICULADO";
            // 
            // checSIPro
            // 
            this.checSIPro.AutoSize = true;
            this.checSIPro.Location = new System.Drawing.Point(8, 33);
            this.checSIPro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checSIPro.Name = "checSIPro";
            this.checSIPro.Size = new System.Drawing.Size(46, 27);
            this.checSIPro.TabIndex = 13;
            this.checSIPro.Text = "SI";
            this.checSIPro.UseVisualStyleBackColor = true;
            // 
            // checNOPro
            // 
            this.checNOPro.AutoSize = true;
            this.checNOPro.Location = new System.Drawing.Point(74, 33);
            this.checNOPro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checNOPro.Name = "checNOPro";
            this.checNOPro.Size = new System.Drawing.Size(58, 27);
            this.checNOPro.TabIndex = 12;
            this.checNOPro.Text = "NO";
            this.checNOPro.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(519, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "GESTION DE ESTUDIANTES";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 71);
            this.panel1.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(955, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // frmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 822);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbPeridPro);
            this.Controls.Add(this.gbvincuPro);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.dataGridEstudiantere);
            this.Controls.Add(this.btnguardares);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtcodigoes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.texapellidoes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbmunicipoes);
            this.Controls.Add(this.cmbcarreraes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textnombrees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdocumentoes);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frmEstudiantes";
            this.Load += new System.EventHandler(this.frmEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstudiantere)).EndInit();
            this.gbPeridPro.ResumeLayout(false);
            this.gbPeridPro.PerformLayout();
            this.gbvincuPro.ResumeLayout(false);
            this.gbvincuPro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdocumentoes;
        private System.Windows.Forms.TextBox textnombrees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridEstudiantere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbcarreraes;
        private System.Windows.Forms.ComboBox cmbmunicipoes;
        private System.Windows.Forms.TextBox texapellidoes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcodigoes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnguardares;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.GroupBox gbPeridPro;
        private System.Windows.Forms.CheckBox checper01Pr;
        private System.Windows.Forms.CheckBox checper02Pro;
        private System.Windows.Forms.GroupBox gbvincuPro;
        private System.Windows.Forms.CheckBox checSIPro;
        private System.Windows.Forms.CheckBox checNOPro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}