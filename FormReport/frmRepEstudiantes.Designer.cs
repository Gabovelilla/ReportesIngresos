
namespace IngresoEstudiantes
{
    partial class frmRepEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepEstudiantes));
            this.dataGridRepES = new System.Windows.Forms.DataGridView();
            this.btnVerES = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeEstu = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRepES)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRepES
            // 
            this.dataGridRepES.AllowUserToDeleteRows = false;
            this.dataGridRepES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridRepES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRepES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRepES.Location = new System.Drawing.Point(14, 207);
            this.dataGridRepES.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridRepES.Name = "dataGridRepES";
            this.dataGridRepES.ReadOnly = true;
            this.dataGridRepES.RowHeadersWidth = 51;
            this.dataGridRepES.RowTemplate.Height = 25;
            this.dataGridRepES.Size = new System.Drawing.Size(872, 361);
            this.dataGridRepES.TabIndex = 40;
            this.dataGridRepES.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRepES_CellContentClick);
            // 
            // btnVerES
            // 
            this.btnVerES.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVerES.Image = ((System.Drawing.Image)(resources.GetObject("btnVerES.Image")));
            this.btnVerES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerES.Location = new System.Drawing.Point(641, 119);
            this.btnVerES.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerES.Name = "btnVerES";
            this.btnVerES.Size = new System.Drawing.Size(137, 67);
            this.btnVerES.TabIndex = 63;
            this.btnVerES.Text = "VER";
            this.btnVerES.UseVisualStyleBackColor = false;
            this.btnVerES.Click += new System.EventHandler(this.btnVerES_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(114, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 23);
            this.label2.TabIndex = 62;
            this.label2.Text = "SELECCIONE FECHA";
            // 
            // dateTimeEstu
            // 
            this.dateTimeEstu.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dateTimeEstu.CalendarForeColor = System.Drawing.Color.Red;
            this.dateTimeEstu.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimeEstu.CalendarTitleForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimeEstu.Location = new System.Drawing.Point(326, 141);
            this.dateTimeEstu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeEstu.Name = "dateTimeEstu";
            this.dateTimeEstu.Size = new System.Drawing.Size(269, 27);
            this.dateTimeEstu.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(361, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 23);
            this.label1.TabIndex = 60;
            this.label1.Text = "REPORTE ESTUDIANTES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmRepEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnVerES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeEstu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridRepES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRepEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRepEstudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRepES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridRepES;
        private System.Windows.Forms.Button btnVerES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeEstu;
        private System.Windows.Forms.Label label1;
    }
}