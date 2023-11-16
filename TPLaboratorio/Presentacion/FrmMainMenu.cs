using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPLaboratorio.Presentacion
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void directoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarReservas frmReservas = new FrmConsultarReservas();
            frmReservas.ShowDialog();
        }

        private void comprobantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarComprobantes frmComprobantes = new FrmConsultarComprobantes();
            frmComprobantes.ShowDialog();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaF frmConsultaF = new FrmConsultaF();
            frmConsultaF.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desesa salir?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void integrantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAcerca = new FrmAcercaDe();
            frmAcerca.ShowDialog();
        }
    }
}
