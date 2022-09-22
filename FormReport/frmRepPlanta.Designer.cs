
namespace IngresoEstudiantes
{
    partial class frmRepPlanta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepPlanta));
            this.dataGridRePlant = new System.Windows.Forms.DataGridView();
            this.btnVerPla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePlant = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRePlant)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRePlant
            // 
            this.dataGridRePlant.AllowUserToDeleteRows = false;
            this.dataGridRePlant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridRePlant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRePlant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRePlant.Location = new System.Drawing.Point(22, 217);
            this.dataGridRePlant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridRePlant.Name = "dataGridRePlant";
            this.dataGridRePlant.ReadOnly = true;
            this.dataGridRePlant.RowHeadersWidth = 51;
            this.dataGridRePlant.RowTemplate.Height = 25;
            this.dataGridRePlant.Size = new System.Drawing.Size(872, 361);
            this.dataGridRePlant.TabIndex = 50;
            // 
            // btnVerPla
            // 
            this.btnVerPla.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVerPla.Image = ((System.Drawing.Image)(resources.GetObject("btnVerPla.Image")));
            this.btnVerPla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerPla.Location = new System.Drawing.Point(641, 103);
            this.btnVerPla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerPla.Name = "btnVerPla";
            this.btnVerPla.Size = new System.Drawing.Size(137, 68);
            this.btnVerPla.TabIndex = 63;
            this.btnVerPla.Text = "VER";
            this.btnVerPla.UseVisualStyleBackColor = false;
            this.btnVerPla.Click += new System.EventHandler(this.btnVerPla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(114, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 23);
            this.label2.TabIndex = 62;
            this.label2.Text = "SELECCIONE FECHA";
            // 
            // dateTimePlant
            // 
            this.dateTimePlant.CalendarForeColor = System.Drawing.Color.Red;
            this.dateTimePlant.Location = new System.Drawing.Point(326, 127);
            this.dateTimePlant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePlant.Name = "dateTimePlant";
            this.dateTimePlant.Size = new System.Drawing.Size(269, 27);
            this.dateTimePlant.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(373, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 60;
            this.label1.Text = "REPORTE PLANTA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmRepPlanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnVerPla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePlant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridRePlant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRepPlanta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRepPlanta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRePlant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridRePlant;
        private System.Windows.Forms.Button btnVerPla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePlant;
        private System.Windows.Forms.Label label1;
    }
}