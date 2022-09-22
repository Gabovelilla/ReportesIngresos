
namespace IngresoEstudiantes
{
    partial class frmRepProfesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepProfesores));
            this.dataGridRepProf = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.timeprofe = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerProf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRepProf)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRepProf
            // 
            this.dataGridRepProf.AllowUserToDeleteRows = false;
            this.dataGridRepProf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridRepProf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRepProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRepProf.Location = new System.Drawing.Point(22, 217);
            this.dataGridRepProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridRepProf.Name = "dataGridRepProf";
            this.dataGridRepProf.ReadOnly = true;
            this.dataGridRepProf.RowHeadersWidth = 51;
            this.dataGridRepProf.RowTemplate.Height = 25;
            this.dataGridRepProf.Size = new System.Drawing.Size(872, 361);
            this.dataGridRepProf.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(93, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "SELECCIONE FECHA";
            // 
            // timeprofe
            // 
            this.timeprofe.CalendarForeColor = System.Drawing.Color.Red;
            this.timeprofe.Location = new System.Drawing.Point(304, 137);
            this.timeprofe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeprofe.Name = "timeprofe";
            this.timeprofe.Size = new System.Drawing.Size(269, 27);
            this.timeprofe.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(347, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "REPORTE PROFESORES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnVerProf
            // 
            this.btnVerProf.BackColor = System.Drawing.Color.Red;
            this.btnVerProf.Image = ((System.Drawing.Image)(resources.GetObject("btnVerProf.Image")));
            this.btnVerProf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerProf.Location = new System.Drawing.Point(619, 116);
            this.btnVerProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerProf.Name = "btnVerProf";
            this.btnVerProf.Size = new System.Drawing.Size(137, 65);
            this.btnVerProf.TabIndex = 59;
            this.btnVerProf.Text = "VER";
            this.btnVerProf.UseVisualStyleBackColor = false;
            this.btnVerProf.Click += new System.EventHandler(this.btnVerProf_Click);
            // 
            // frmRepProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnVerProf);
            this.Controls.Add(this.dataGridRepProf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeprofe);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRepProfesores";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRepProfesores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRepProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridRepProf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker timeprofe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerProf;
    }
}