using CapaPresentacion.DataSet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Capa_Negocio;

namespace CapaPresentacion
{
    public partial class FrmReporteCajaIncio : Telerik.WinControls.UI.RadForm
    {
        private string idEmpresa;
        CajaInicioBL CajIniBL = new CajaInicioBL();
        public FrmReporteCajaIncio()
        {
            InitializeComponent();
        }

        public FrmReporteCajaIncio(string idEmpresa)
        {
            InitializeComponent();
            this.idEmpresa = idEmpresa;
        }

        private void FrmReporteCajaIncio_Load(object sender, EventArgs e)
        {
            //DataSet Movimiento
            DtsCajaInicio DtsCI = new DtsCajaInicio();
            string nameTblDetalle = "USP_CajaInicio_REPORTE_DETALLE";
            RptSaldosIniciales RptSI = new RptSaldosIniciales();
            DataTable dtDetalle = CajIniBL.cargarDatosDeDetalle_Reporte(idEmpresa);

            DtsCI.Tables[nameTblDetalle].Merge(dtDetalle);

            RptSI.SetDataSource(DtsCI);
            CrvSaldosIniciales.ReportSource = RptSI;
            CrvSaldosIniciales.Refresh();
        }
    }
}
