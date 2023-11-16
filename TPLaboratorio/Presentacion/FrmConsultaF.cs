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
    public partial class FrmConsultaF : Form
    {
        IServicioConsultas servicio;

        public FrmConsultaF()
        {
            InitializeComponent();
            servicio = new ServicioConsultasImpl();
        }

        private void FrmConsultaF_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now;
            dtpHasta.Value = DateTime.Now.AddDays(7);
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }




        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataTable tabla = servicio.TraerPeliculaFiltrada(dtpDesde.Value, dtpHasta.Value);
            DgvPelis.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                DgvPelis.Rows.Add(new object[] {
                    fila["nombre"].ToString(),
                     fila["total"].ToString(),
                    fila["cantidad"].ToString(),
                    fila["funciones"].ToString()
                });


            }
        }
    }
}
