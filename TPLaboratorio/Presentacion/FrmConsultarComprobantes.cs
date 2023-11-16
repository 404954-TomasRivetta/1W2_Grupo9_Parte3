using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TPLaboratorio.Dominio;
using TPLaboratorio.Servicio.Implementacion;
using TPLaboratorio.Servicio.Interfaz;

namespace TPLaboratorio.Presentacion
{
    public partial class FrmConsultarComprobantes : Form
    {
        bool filtrarPorNombreCliente = false;
        bool filtrarPorNombreFormaPago = false;
        bool filtrarPorNombreEmpleado = false;

        //Rodri
        IServicioConsultas servicio;
        public FrmConsultarComprobantes()
        {
            InitializeComponent();
            servicio = new ServicioConsultasImpl();
        }
        private void FrmConsultaFunciones_Load(object sender, EventArgs e)
        {
            cboClientes.Visible = false;
            cboEmpleado.Visible = false;
            cboFormaPago.Visible = false;
            CargarClientes();
            CargarEmpleados();
            CargarFormasPago();
            LimpiarSeleccionBoxs();
        }
        private void LimpiarSeleccionBoxs()
        {
            cboClientes.SelectedIndex = -1;
            cboEmpleado.SelectedIndex = -1;
            cboFormaPago.SelectedIndex = -1;
        }
        private void CargarClientes()
        {
            List<Cliente> lClientes = servicio.TraerClientes();
            cboClientes.DataSource = lClientes.Select(c => new
            {
                NombreCompleto = $"{c.Nombre} {c.Apellido}",
                CodCliente = c.CodCliente
            }).ToList();

            cboClientes.DisplayMember = "NombreCompleto";
            cboClientes.ValueMember = "CodCliente";
            cboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarEmpleados()
        {
            List<Empleado> lEmpleados = servicio.TraerEmpleados();
            cboEmpleado.DataSource = lEmpleados.Select(e => new
            {
                NombreCompleto = $"{e.Nombre} {e.Apellido}",
                CodEmpleado = e.CodEmpleado
            }).ToList();
            cboEmpleado.DisplayMember = "NombreCompleto";
            cboEmpleado.ValueMember = "CodEmpleado";
            cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarFormasPago()
        {
            cboFormaPago.DataSource = servicio.TraerFormaPago();
            cboFormaPago.ValueMember = "IdFormaPago";
            cboFormaPago.DisplayMember = "Descripcion";
            cboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            //cboClientes.SelectedIndex = -1;
            //cboEmpleado.SelectedIndex = -1;
            //cboFormaPago.SelectedIndex = -1;
            
            dgvComprobantes.Rows.Clear();
            TraerComprobantes();
        }
        public bool ValidarDatos()
        {
            if (!string.IsNullOrEmpty(txtComprobante.Text) && !int.TryParse(txtComprobante.Text, out _))
            {
                MessageBox.Show("Debe ingresar un comprobante valido..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!string.IsNullOrEmpty(txtCliente.Text) && !int.TryParse(txtCliente.Text, out _) && cboClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un cliente valido..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!string.IsNullOrEmpty(txtEmpleado.Text) && !int.TryParse(txtEmpleado.Text, out _) && cboEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un empleado valido..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!string.IsNullOrEmpty(txtFormaPago.Text) && !int.TryParse(txtFormaPago.Text, out _) && cboFormaPago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar una forma de pago valida..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!string.IsNullOrEmpty(txtDesde.Text) && !int.TryParse(txtDesde.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad de entradas valida..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!string.IsNullOrEmpty(txtHasta.Text) && !int.TryParse(txtHasta.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad de entradas valida..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!string.IsNullOrEmpty(txtDesdeImporte.Text) && !decimal.TryParse(txtDesdeImporte.Text, out _))
            {
                MessageBox.Show("Debe ingresar un importe valido..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!string.IsNullOrEmpty(txtHastaImporte.Text) && !decimal.TryParse(txtHastaImporte.Text, out _))
            {
                MessageBox.Show("Debe ingresar un importe valido..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            //if(filtrarPorNombreCliente&&cboClientes.SelectedIndex==-1)
            //{
            //    MessageBox.Show("Debe seleccionar un cliente..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return false;
            //}
            //if (filtrarPorNombreEmpleado && cboEmpleado.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Debe seleccionar un empleado..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return false;
            //}
            //if (filtrarPorNombreFormaPago && cboFormaPago.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Debe seleccionar una forma de pago..", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return false;
            //}
            return true;
        }
        public void TraerComprobantes()
        {
            if (ValidarDatos())
            {
                try
                {
                    int idComp, idCli, idFormaPago, idEmpleado, cantDesde, cantHasta;
                    decimal importeDesde, importeHasta;

                    if (!int.TryParse(txtComprobante.Text, out idComp))
                    {
                        idComp = 0;
                    }

                    if (!int.TryParse(txtCliente.Text, out idCli) && !filtrarPorNombreCliente || (filtrarPorNombreCliente&&cboClientes.SelectedIndex==-1))
                    {
                        idCli = 0;
                    }
                    else if (filtrarPorNombreCliente)
                    {
                        idCli = (int)cboClientes.SelectedValue;
                    }
                    if (!int.TryParse(txtFormaPago.Text, out idFormaPago) && !filtrarPorNombreFormaPago || (filtrarPorNombreFormaPago&&cboFormaPago.SelectedIndex==-1))
                    {
                        idFormaPago = 0;
                    }
                    else if (filtrarPorNombreFormaPago)
                    {
                        idFormaPago = (int)cboFormaPago.SelectedValue;
                    }

                    if (!int.TryParse(txtEmpleado.Text, out idEmpleado) && !filtrarPorNombreEmpleado || (filtrarPorNombreEmpleado&&cboEmpleado.SelectedIndex==-1))
                    {
                        idEmpleado = 0;
                    }
                    else if (filtrarPorNombreEmpleado)
                    {
                        idEmpleado = (int)cboEmpleado.SelectedValue;
                    }
                    if (!int.TryParse(txtDesde.Text, out cantDesde))
                    {
                        cantDesde = 0;
                    }

                    if (!int.TryParse(txtHasta.Text, out cantHasta))
                    {
                        cantHasta = 0;
                    }

                    if (!decimal.TryParse(txtDesdeImporte.Text, out importeDesde))
                    {
                        importeDesde = 0;
                    }

                    if (!decimal.TryParse(txtHastaImporte.Text, out importeHasta))
                    {
                        importeHasta = 0;
                    }

                    Comprobante c = new Comprobante(idCli, idFormaPago, idEmpleado, cantDesde, cantHasta, idComp, importeDesde, importeHasta);
                    List<Comprobante> lComprobantes = servicio.TraerComprobantesFiltrados(c);

                    foreach (Comprobante co in lComprobantes)
                    {
                        dgvComprobantes.Rows.Add(new object[] { co.IdComprobante, co.NombreCliente, co.NombreEmpleado, co.FormaPago, co.CantEntradas, co.Importe });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al traer comprobantes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNombreCliente_Click(object sender, EventArgs e)
        {
            filtrarPorNombreCliente = !filtrarPorNombreCliente;
            if (filtrarPorNombreCliente)
            {
                cboClientes.Visible = true;
                txtCliente.Enabled = false;
                btnNombreCliente.Text = "Filtrar por ID";
            }
            else
            {
                cboClientes.Visible = false;
                txtCliente.Enabled = true;
                btnNombreCliente.Text = "Filtrar por nombre";
            }
        }

        private void btnNombreEmpleado_Click(object sender, EventArgs e)
        {
            filtrarPorNombreEmpleado = !filtrarPorNombreEmpleado;
            if (filtrarPorNombreEmpleado)
            {
                cboEmpleado.Visible = true;
                txtEmpleado.Enabled = false;
                btnNombreEmpleado.Text = "Filtrar por ID";
            }
            else
            {
                cboEmpleado.Visible = false;
                txtEmpleado.Enabled = true;
                btnNombreEmpleado.Text = "Filtrar por nombre";
            }
        }
        private void btnNombreFormaPago_Click(object sender, EventArgs e)
        {
            filtrarPorNombreFormaPago = !filtrarPorNombreFormaPago;
            if (filtrarPorNombreFormaPago)
            {
                cboFormaPago.Visible = true;
                txtFormaPago.Enabled = false;
                btnNombreFormaPago.Text = "Filtrar por ID";
            }
            else
            {
                cboFormaPago.Visible = false;
                txtFormaPago.Enabled = true;
                btnNombreFormaPago.Text = "Filtrar por nombre";
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
