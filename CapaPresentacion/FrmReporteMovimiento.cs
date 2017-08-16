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
            string nameTable = "USP_Movimiento_REPORTE_CABECERA";
            RptM = new RptMovimiento();
            DataTable dt = MovBL.cargarDatosDeCabecera_Reporte(iDCaja);
            DtsMC.Tables[nameTable].Merge(dt);
            
            RptM.SetDataSource(DtsMC.Tables[nameTable]); 
            
            CrvMovimiento.ReportSource = RptM;
            CrvMovimiento.Refresh();
            
        }
    }
}
