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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            personalizarDiseño();
        }
        private void personalizarDiseño() { 
        
            panelSubMenuConsultas.Visible = false;
            panelAcercaDe.Visible = false;
        }

        private void ocultarSubMenu() {
            if (panelSubMenuConsultas.Visible)
            {
                panelSubMenuConsultas.Visible = false;
            }
            if (panelAcercaDe.Visible)
            {
                panelAcercaDe.Visible = false;
            }
        }

        private void mostrarSubmenu(Panel subMenu) {

            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelSubMenuConsultas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFormularioHijo(new Form1());
            ocultarSubMenu();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            openFormularioHijo(new FrmConsultarReservas());
            ocultarSubMenu();

        }

        private void btnComprobantes_Click(object sender, EventArgs e)
        {
            openFormularioHijo(new FrmConsultarComprobantes());
            ocultarSubMenu();

        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            openFormularioHijo(new FrmConsultaF());
            ocultarSubMenu();

        }

        private void btnIntegrantes_Click(object sender, EventArgs e)
        {
            openFormularioHijo(new FrmAcercaDe());
            ocultarSubMenu();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            if (MessageBox.Show("Seguro desesa salir?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelAcercaDe);
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }


        private Form activeForm = null;
        private void openFormularioHijo(Form formHijo) {

            if (activeForm!=null)
            {
                activeForm.Close();
            }
            activeForm = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Controls.Add(formHijo);
            panelFormularioHijo.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
    }
}
