namespace TPLaboratorio.Presentacion
{
    partial class Form1
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
            this.dgvDir = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDirectores = new System.Windows.Forms.ComboBox();
            this.dtpLim = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cboGeneros = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ColApe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRecaudacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDir)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDir
            // 
            this.dgvDir.AllowUserToAddRows = false;
            this.dgvDir.AllowUserToDeleteRows = false;
            this.dgvDir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColApe,
            this.ColEmpleado,
            this.ColPersonas,
            this.ColRecaudacion,
            this.ColGen});
            this.dgvDir.Location = new System.Drawing.Point(71, 246);
            this.dgvDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDir.Name = "dgvDir";
            this.dgvDir.ReadOnly = true;
            this.dgvDir.RowHeadersWidth = 51;
            this.dgvDir.Size = new System.Drawing.Size(725, 236);
            this.dgvDir.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Director:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Genero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha Desde:";
            // 
            // cboDirectores
            // 
            this.cboDirectores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDirectores.FormattingEnabled = true;
            this.cboDirectores.Location = new System.Drawing.Point(243, 42);
            this.cboDirectores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDirectores.Name = "cboDirectores";
            this.cboDirectores.Size = new System.Drawing.Size(160, 33);
            this.cboDirectores.TabIndex = 12;
            // 
            // dtpLim
            // 
            this.dtpLim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLim.Location = new System.Drawing.Point(243, 167);
            this.dtpLim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpLim.Name = "dtpLim";
            this.dtpLim.Size = new System.Drawing.Size(265, 30);
            this.dtpLim.TabIndex = 13;
            // 
            // cboGeneros
            // 
            this.cboGeneros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGeneros.FormattingEnabled = true;
            this.cboGeneros.Location = new System.Drawing.Point(243, 103);
            this.cboGeneros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboGeneros.Name = "cboGeneros";
            this.cboGeneros.Size = new System.Drawing.Size(160, 33);
            this.cboGeneros.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(649, 159);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 52);
            this.button1.TabIndex = 15;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColApe
            // 
            this.ColApe.HeaderText = "Nombre Director";
            this.ColApe.MinimumWidth = 6;
            this.ColApe.Name = "ColApe";
            this.ColApe.ReadOnly = true;
            this.ColApe.Width = 125;
            // 
            // ColEmpleado
            // 
            this.ColEmpleado.HeaderText = "Apellido Director";
            this.ColEmpleado.MinimumWidth = 6;
            this.ColEmpleado.Name = "ColEmpleado";
            this.ColEmpleado.ReadOnly = true;
            this.ColEmpleado.Width = 125;
            // 
            // ColPersonas
            // 
            this.ColPersonas.HeaderText = "Cantidad Personas";
            this.ColPersonas.MinimumWidth = 6;
            this.ColPersonas.Name = "ColPersonas";
            this.ColPersonas.ReadOnly = true;
            this.ColPersonas.Width = 125;
            // 
            // ColRecaudacion
            // 
            this.ColRecaudacion.HeaderText = "Recaudacion";
            this.ColRecaudacion.MinimumWidth = 6;
            this.ColRecaudacion.Name = "ColRecaudacion";
            this.ColRecaudacion.ReadOnly = true;
            this.ColRecaudacion.Width = 125;
            // 
            // ColGen
            // 
            this.ColGen.HeaderText = "Genero";
            this.ColGen.MinimumWidth = 6;
            this.ColGen.Name = "ColGen";
            this.ColGen.ReadOnly = true;
            this.ColGen.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboGeneros);
            this.Controls.Add(this.dtpLim);
            this.Controls.Add(this.cboDirectores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDir);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDirectores;
        private System.Windows.Forms.DateTimePicker dtpLim;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cboGeneros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRecaudacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGen;
    }
}