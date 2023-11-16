namespace TPLaboratorio.Presentacion
{
    partial class FrmConsultarReservas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreReserva = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.ColNomReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPeliReservada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaPeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHoraPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la reserva";
            // 
            // txtNombreReserva
            // 
            this.txtNombreReserva.Location = new System.Drawing.Point(146, 24);
            this.txtNombreReserva.Name = "txtNombreReserva";
            this.txtNombreReserva.Size = new System.Drawing.Size(100, 20);
            this.txtNombreReserva.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFechaReserva);
            this.groupBox1.Controls.Add(this.txtNombreReserva);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 112);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Location = new System.Drawing.Point(373, 24);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaReserva.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha reserva";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(457, 62);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(116, 32);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNomReserva,
            this.ColCliente,
            this.ColFechaReserva,
            this.ColPeliReservada,
            this.ColFechaPeli,
            this.ColHoraPelicula});
            this.dgvReservas.Location = new System.Drawing.Point(12, 130);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.Size = new System.Drawing.Size(598, 150);
            this.dgvReservas.TabIndex = 3;
            // 
            // ColNomReserva
            // 
            this.ColNomReserva.HeaderText = "Nombre de la reserva";
            this.ColNomReserva.Name = "ColNomReserva";
            this.ColNomReserva.ReadOnly = true;
            // 
            // ColCliente
            // 
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.ReadOnly = true;
            // 
            // ColFechaReserva
            // 
            this.ColFechaReserva.HeaderText = "Fecha de la reserva";
            this.ColFechaReserva.Name = "ColFechaReserva";
            this.ColFechaReserva.ReadOnly = true;
            // 
            // ColPeliReservada
            // 
            this.ColPeliReservada.HeaderText = "Pelicula reservada";
            this.ColPeliReservada.Name = "ColPeliReservada";
            this.ColPeliReservada.ReadOnly = true;
            // 
            // ColFechaPeli
            // 
            this.ColFechaPeli.HeaderText = "Fecha de la pelicula";
            this.ColFechaPeli.Name = "ColFechaPeli";
            this.ColFechaPeli.ReadOnly = true;
            // 
            // ColHoraPelicula
            // 
            this.ColHoraPelicula.HeaderText = "Hora de la pelicula";
            this.ColHoraPelicula.Name = "ColHoraPelicula";
            this.ColHoraPelicula.ReadOnly = true;
            // 
            // FrmConsultarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 334);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsultarReservas";
            this.Text = "FrmConsultarReservas";
            this.Load += new System.EventHandler(this.FrmConsultarReservas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreReserva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNomReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPeliReservada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaPeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHoraPelicula;
    }
}