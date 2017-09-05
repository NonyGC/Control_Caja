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
using System.Collections;
using Capa_Entidad;

namespace CapaPresentacion
{
    public partial class FrmReporteMovimiento : Telerik.WinControls.UI.RadForm
    {
        private string iDCaja;
        MovimientoBL MovBL = new MovimientoBL();
        private ReportClass RptM;
        private CajaCierre cajCEN;

        public FrmReporteMovimiento()
        {
            InitializeComponent();
        }

        public FrmReporteMovimiento(string iDCaja, CajaCierre cajCEN)
        {
            InitializeComponent();
            this.iDCaja = iDCaja;
            this.cajCEN = cajCEN;
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
            AsignarCampoDeParametroCrystal();
            CrvMovimiento.ReportSource = RptM;
            CrvMovimiento.Refresh();
        }
        private void AsignarCampoDeParametroCrystal()
        {
            RptM.SetParameterValue("PrmTotalIngreso",cajCEN.TotalIngreso);
            RptM.SetParameterValue("PrmTotalEgreso", cajCEN.TotalEgreso);
            RptM.SetParameterValue("PrmSaldoInicial", cajCEN.SaldoIncial);
            RptM.SetParameterValue("PrmSaldoFinal", cajCEN.SaldoFinal);
        }

    }
}
