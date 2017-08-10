using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Capa_Negocio;
using Capa_Entidad;
namespace CapaPresentacion
{
    public partial class FrmSaldosFinales : Telerik.WinControls.UI.RadForm
    {
        CajaCierreBL CCiereBL= new CajaCierreBL();
        public FrmSaldosFinales()
        {
            InitializeComponent();
        }

        private void FrmSaldosFinales_Load(object sender, EventArgs e)
        {
            DataTable dt = CCiereBL.obtenerListadoCajaCerrado(EmpresaEN.idEmpresa);
            GrvSaldosFinales.DataSource = dt;
            lblEmpresa.Text = EmpresaEN.RazonSocial;
            DateTime FechaActual = DateTime.Today;
            lblFecha.Text = FechaActual.ToShortDateString();
        }
    }
}
