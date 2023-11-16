using System;
using System.Data;
using System.Windows.Forms;
using TPLaboratorio.Dominio;
using TPLaboratorio.Servicio.Implementacion;
using TPLaboratorio.Servicio.Interfaz;

namespace TPLaboratorio.Presentacion
{
    public partial class Form1 : Form
    {

        IServicioConsultas servicio;
        public Form1()
        {
            InitializeComponent();
            servicio = new ServicioConsultasImpl();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarComboDirectores();
            cargarComboGeneros();
        }

        private void cargarComboDirectores()
        {
            cboDirectores.DataSource = servicio.ObtenerDirectores();
            cboDirectores.ValueMember = "id";
            cboDirectores.DisplayMember = "Nombre";
        }

        private void cargarComboGeneros()
        {
            cboGeneros.DataSource = servicio.ObtenerGeneros();
            cboGeneros.ValueMember = "id";
            cboGeneros.DisplayMember = "Nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Director d = (Director)cboDirectores.SelectedItem;
            TipoPelicula t = (TipoPelicula)cboGeneros.SelectedItem;
            DataTable tabla = servicio.TraerDirector(dtpLim.Value, d.id, t.id);
            dgvDir.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                dgvDir.Rows.Add(new object[] {
                    fila["nombre"].ToString(),
                     fila["apellido"].ToString(),
                    fila["personas"].ToString(),
                    fila["recaudacion"].ToString(),
                    t.Nombre.ToString()
                });


            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desesa salir?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
