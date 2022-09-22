
namespace IngresoEstudiantes
{
    partial class frmProfesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfesores));
            this.dataGridEstudiantes = new System.Windows.Forms.DataGridView();
            this.gbPeridPro = new System.Windows.Forms.GroupBox();
            this.checper01Pr = new System.Windows.Forms.CheckBox();
            this.checper02Pro = new System.Windows.Forms.CheckBox();
            this.gbvincuPro = new System.Windows.Forms.GroupBox();
            this.checSIPro = new System.Windows.Forms.CheckBox();
            this.checNOPro = new System.Windows.Forms.CheckBox();
            this.txtCodPro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApellPro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbmunicipoes = new System.Windows.Forms.ComboBox();
            this.cmbCarrerPro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombPro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocProfeso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnguardarPro = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstudiantes)).BeginInit();
            this.gbPeridPro.SuspendLayout();
            this.gbvincuPro.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEstudiantes
            // 
            this.dataGridEstudiantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstudiantes.Location = new System.Drawing.Point(21, 511);
            this.dataGridEstudiantes.Name = "dataGridEstudiantes";
            this.dataGridEstudiantes.RowHeadersWidth = 51;
            this.dataGridEstudiantes.RowTemplate.Height = 29;
            this.dataGridEstudiantes.Size = new System.Drawing.Size(1376, 259);
            this.dataGridEstudiantes.TabIndex = 19;
            this.dataGridEstudiantes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEstudiantes_CellDoubleClick);
            // 
            // gbPeridPro
            // 
            this.gbPeridPro.Controls.Add(this.checper01Pr);
            this.gbPeridPro.Controls.Add(this.checper02Pro);
            this.gbPeridPro.Location = new System.Drawing.Point(694, 305);
            this.gbPeridPro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbPeridPro.Name = "gbPeridPro";
            this.gbPeridPro.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbPeridPro.Size = new System.Drawing.Size(142, 86);
            this.gbPeridPro.TabIndex = 40;
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
            this.gbvincuPro.Location = new System.Drawing.Point(546, 305);
            this.gbvincuPro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbvincuPro.Name = "gbvincuPro";
            this.gbvincuPro.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbvincuPro.Size = new System.Drawing.Size(142, 86);
            this.gbvincuPro.TabIndex = 39;
            this.gbvincuPro.TabStop = false;
            this.gbvincuPro.Text = "VINCULADO";
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
            // txtCodPro
            // 
            this.txtCodPro.BackColor = System.Drawing.SystemColors.Info;
            this.txtCodPro.Location = new System.Drawing.Point(21, 148);
            this.txtCodPro.Name = "txtCodPro";
            this.txtCodPro.Size = new System.Drawing.Size(177, 30);
            this.txtCodPro.TabIndex = 38;
            this.txtCodPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(52, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "CODIGO";
            // 
            // txtApellPro
            // 
            this.txtApellPro.BackColor = System.Drawing.SystemColors.Info;
            this.txtApellPro.Location = new System.Drawing.Point(495, 233);
            this.txtApellPro.Name = "txtApellPro";
            this.txtApellPro.Size = new System.Drawing.Size(273, 30);
            this.txtApellPro.TabIndex = 36;
            this.txtApellPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texapellido_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(624, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "APELLIDO";
            // 
            // cmbmunicipoes
            // 
            this.cmbmunicipoes.BackColor = System.Drawing.SystemColors.Info;
            this.cmbmunicipoes.FormattingEnabled = true;
            this.cmbmunicipoes.Location = new System.Drawing.Point(271, 332);
            this.cmbmunicipoes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbmunicipoes.Name = "cmbmunicipoes";
            this.cmbmunicipoes.Size = new System.Drawing.Size(237, 31);
            this.cmbmunicipoes.TabIndex = 34;
            // 
            // cmbCarrerPro
            // 
            this.cmbCarrerPro.BackColor = System.Drawing.SystemColors.Info;
            this.cmbCarrerPro.FormattingEnabled = true;
            this.cmbCarrerPro.Location = new System.Drawing.Point(21, 332);
            this.cmbCarrerPro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbCarrerPro.Name = "cmbCarrerPro";
            this.cmbCarrerPro.Size = new System.Drawing.Size(237, 31);
            this.cmbCarrerPro.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(303, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "MUNICIPIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(52, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "ASIGNATURAS";
            // 
            // txtNombPro
            // 
            this.txtNombPro.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombPro.Location = new System.Drawing.Point(214, 233);
            this.txtNombPro.Name = "txtNombPro";
            this.txtNombPro.Size = new System.Drawing.Size(273, 30);
            this.txtNombPro.TabIndex = 29;
            this.txtNombPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textnombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(303, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "NOMBRE ";
            // 
            // txtDocProfeso
            // 
            this.txtDocProfeso.BackColor = System.Drawing.SystemColors.Info;
            this.txtDocProfeso.Location = new System.Drawing.Point(21, 233);
            this.txtDocProfeso.Name = "txtDocProfeso";
            this.txtDocProfeso.Size = new System.Drawing.Size(183, 30);
            this.txtDocProfeso.TabIndex = 27;
            this.txtDocProfeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdocumento_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(52, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "DOCUMENTO ";
            // 
            // btnguardarPro
            // 
            this.btnguardarPro.BackColor = System.Drawing.Color.Red;
            this.btnguardarPro.Image = ((System.Drawing.Image)(resources.GetObject("btnguardarPro.Image")));
            this.btnguardarPro.Location = new System.Drawing.Point(21, 423);
            this.btnguardarPro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnguardarPro.Name = "btnguardarPro";
            this.btnguardarPro.Size = new System.Drawing.Size(154, 68);
            this.btnguardarPro.TabIndex = 59;
            this.btnguardarPro.Text = "GUARDAR";
            this.btnguardarPro.UseVisualStyleBackColor = false;
            this.btnguardarPro.Click += new System.EventHandler(this.btnguardarPro_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Red;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEditar.Location = new System.Drawing.Point(220, 428);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(118, 56);
            this.btnEditar.TabIndex = 63;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.Red;
            this.btnactualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.Image")));
            this.btnactualizar.Location = new System.Drawing.Point(388, 428);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(173, 56);
            this.btnactualizar.TabIndex = 62;
            this.btnactualizar.Text = "ACTUALIZAR LISTA";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(792, 233);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(128, 30);
            this.txtfecha.TabIndex = 64;
            this.txtfecha.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(647, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "GESTION DE PROFESORES\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1416, 62);
            this.panel1.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(919, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // frmProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1413, 788);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnguardarPro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbPeridPro);
            this.Controls.Add(this.gbvincuPro);
            this.Controls.Add(this.txtCodPro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtApellPro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbmunicipoes);
            this.Controls.Add(this.cmbCarrerPro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombPro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDocProfeso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridEstudiantes);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmProfesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Profesores";
            this.Load += new System.EventHandler(this.frmProfesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstudiantes)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridEstudiantes;
        private System.Windows.Forms.GroupBox gbPeridPro;
        private System.Windows.Forms.CheckBox checper01Pr;
        private System.Windows.Forms.CheckBox checper02Pro;
        private System.Windows.Forms.GroupBox gbvincuPro;
        private System.Windows.Forms.CheckBox checSIPro;
        private System.Windows.Forms.CheckBox checNOPro;
        private System.Windows.Forms.TextBox txtCodPro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApellPro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbmunicipoes;
        private System.Windows.Forms.ComboBox cmbCarrerPro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocProfeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnguardarPro;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}