﻿using System;
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
    public partial class FrmConsultaNro2 : Form
    {
        IServicioConsultas servicio;
        public FrmConsultaNro2()
        {
            servicio = new ServicioConsultasImpl();
        }

        //Suerte...

    }
}