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
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaPresentacion
{
    public partial class FrmReporteMovimiento : Telerik.WinControls.UI.RadForm
    {
        private string iDCaja;
        MovimientoBL MovBL = new MovimientoBL();
        private ReportClass RptM;

        public FrmReporteMovimiento()
        {
            InitializeComponent();
        }

        public FrmReporteMovimiento(string iDCaja)
        {
            InitializeComponent();
            this.iDCaja = iDCaja;
        }

        private void FrmReporteMovimiento_Load(object sender, EventArgs e)
        {
            //DataSet Movimiento
            DtsMovimiento DtsMC = new DtsMovimiento();
            string nameTblCabecera = "USP_Movimiento_REPORTE_CABECERA";
            string nameTblDetalle = "USP_Movimiento_REPORTE_DETALLE";
            RptM = new RptMovimiento();
            DataTable dtCabecera = MovBL.cargarDatosDeCabecera_Reporte(iDCaja);
            DataTable dtDetalle = MovBL.cargarDatosDeDetalle_Reporte(iDCaja);
            DtsMC.Tables[nameTblCabecera].Merge(dtCabecera);
            DtsMC.Tables[nameTblDetalle].Merge(dtDetalle);

            RptM.SetDataSource(DtsMC);
            //RptM.SetDataSource(DtsMC.Tables[nameTblDetalle]);
            CrvMovimiento.ReportSource = RptM;
            CrvMovimiento.Refresh();

        }
    }
}
