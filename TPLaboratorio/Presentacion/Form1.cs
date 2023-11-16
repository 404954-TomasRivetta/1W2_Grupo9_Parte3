using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            cargarComboDirectores(cboDirectores, "SP_CONSULTAR_DIRECTORES");
            cargarComboGeneros(cboGeneros, "SP_CONSULTAR_GENEROS");
        }

        private void cargarComboDirectores(ComboBox combo, string nombreSP)
        {
            combo.DataSource = servicio.ObtenerDirectores();
            combo.ValueMember = "id";
            combo.DisplayMember = "Nombre";
        }

        private void cargarComboGeneros(ComboBox combo, string nombreSP)
        {
            combo.DataSource = servicio.ObtenerGeneros();
            combo.ValueMember = "id";
            combo.DisplayMember = "Nombre";
        }

    }
}
