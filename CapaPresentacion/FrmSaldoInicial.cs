﻿using System;
using System.Windows.Forms;
using Capa_Negocio;
using Telerik.WinControls.UI;
using Capa_Entidad;
using Telerik.WinControls;
using System.Data;

namespace CapaPresentacion
{
    public partial class FrmSaldoInicial : Telerik.WinControls.UI.RadForm
    {
        CajaInicioBL CajaIniBL = new CajaInicioBL();
        DocumentoBL DocBL = new DocumentoBL();
        CajaInicioEN CajaIniEN = new CajaInicioEN();
        DateTime FechaActual = DateTime.Today;
        public FrmSaldoInicial()
        {
            InitializeComponent();
        }

        private void Frm_SaldoInicial_Load(object sender, EventArgs e)
        {
            cargarDatosAlFormulario();
            cargarGrillaCajaInicio();
            lblEmpresa.Text = EmpresaEN.RazonSocialStatic;
            

        }
        void cargarDatosAlFormulario()
        {
            txtCodigo.Text = CajaIniBL.ObtenerCodigo();

            lblFecha.Text = FechaActual.ToShortDateString();
            dtpFecha.Value = FechaActual;
            cargarCboDocumento();
            dropDownListLimitAutocomplete();
        }
        private void cargarCboDocumento()
        {
            cboDocumento.DataSource = DocBL.ObtenerTipoDocumentoBL();
            cboDocumento.DisplayMember = "Descripcion";
            cboDocumento.ValueMember = "Id";
            cboDocumento.SelectedIndex = -1;
        }
        private void dropDownListLimitAutocomplete()
        {
            cboDocumento.DropDownListElement.AutoCompleteAppend.LimitToList = true;
        }
        void cargarGrillaCajaInicio()
        {
            DataTable dtCajaIni = CajaIniBL.ObtenerListadoCajaInicio(EmpresaEN.idEmpresaStatic);
            dtgSaldoInicial.DataSource = dtCajaIni;
            decimal Importe = 0;
            foreach (DataRow row in dtCajaIni.Rows)
            {
                Importe += Convert.ToDecimal(row["Importe"]);
            }
            txtImporteTotal.Text = Importe.ToString("C");
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            FrmDocumento Frm = new FrmDocumento();
            Frm.ShowDialog();
            Frm.Dispose();
        }

        private void TxtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            RadTextBox TextBox = (RadTextBox)sender;
            Shared.validadarDosDecimales(e, TextBox.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtImporte.Text))
                return;
            if (cboDocumento.SelectedValue == null)
                return;
            if (Shared.CheckDate(dtpFecha.Text) == false)
                return;

            bool EstadoEjecucion = false;
            if (BtnGuardar.Text == "GUARDAR")
            {
                AsignarValorCajaInicioEN_GUARDAR();
                EstadoEjecucion = CajaIniBL.GuardarNuevaCajaInicio(CajaIniEN);
                if (EstadoEjecucion)
                {
                    RadMessageBox.Show("SE REGISTRO CORRECTAMENTE", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Info);
                    cargarDatosAlFormulario();
                    cargarGrillaCajaInicio();
                    restablecerControlesDeEntrada();
                }
            }
            if (BtnGuardar.Text == "ACTUALIZAR")
            {
                AsignarValorCajaInicioEN_ACTUALIZAR();
                EstadoEjecucion = CajaIniBL.ActualizarCajaInicio(CajaIniEN);
                if (EstadoEjecucion)
                {
                    RadMessageBox.Show("SE ACTUALIZO CORRECTAMENTE", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Info);
                    cargarDatosAlFormulario();
                    cargarGrillaCajaInicio();
                    restablecerControlesDeEntrada();
                }
            }

        }
        private void restablecerControlesDeEntrada()
        {
            TxtImporte.Clear();
            txtNumeroDoc.Clear();
            txtSerieDoc.Clear();
            cboDocumento.SelectedIndex = -1;
            dtpFecha.Value = FechaActual;
            BtnGuardar.Text = "GUARDAR";
        }

        private void AsignarValorCajaInicioEN_GUARDAR()
        {
            CajaIniEN.ID = txtCodigo.Text;
            CajaIniEN.Fecha = dtpFecha.Value;
            CajaIniEN.IDEmpresa = EmpresaEN.idEmpresaStatic;
            CajaIniEN.IDDocumento = int.Parse(cboDocumento.SelectedValue.ToString());
            CajaIniEN.Serie = txtSerieDoc.Text;
            CajaIniEN.Numero = txtNumeroDoc.Text;
            CajaIniEN.Importe = decimal.Parse(TxtImporte.Text);
            CajaIniEN.Estado = 0;

        }
        private void AsignarValorCajaInicioEN_ACTUALIZAR()
        {
            CajaIniEN.ID = txtCodigo.Text;
            CajaIniEN.Fecha = dtpFecha.Value;
            CajaIniEN.IDDocumento = int.Parse(cboDocumento.SelectedValue.ToString());
            CajaIniEN.Serie = txtSerieDoc.Text;
            CajaIniEN.Numero = txtNumeroDoc.Text;
            CajaIniEN.Importe = decimal.Parse(TxtImporte.Text);
        }

        private void txtNumeroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            RadTextBox TextBox = (RadTextBox)sender;
            Shared.validarSoloNumeros(e);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            pasarDatosGrillaAControlEdit();
        }
        private void pasarDatosGrillaAControlEdit()
        {
            var grvCurrentRow = dtgSaldoInicial.CurrentRow;
            int estadoCaja = Convert.ToInt16(grvCurrentRow.Cells["Estado"].Value);
            if (estadoCaja == 0)
            {
                txtCodigo.Text = grvCurrentRow.Cells["Codigo"].Value.ToString();
                txtNumeroDoc.Text = grvCurrentRow.Cells["Numero"].Value.ToString();
                txtSerieDoc.Text = grvCurrentRow.Cells["Serie"].Value.ToString();
                TxtImporte.Text = grvCurrentRow.Cells["Importe"].Value.ToString();
                dtpFecha.Value = Convert.ToDateTime(grvCurrentRow.Cells["Fecha"].Value);
                cboDocumento.SelectedValue = grvCurrentRow.Cells["IDDocumento"].Value;
                BtnGuardar.Text = "ACTUALIZAR";
            }
            else
            {
                RadMessageBox.Show("LA CAJA ESTA CERRADA", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            restablecerControlesDeEntrada();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var codigo = dtgSaldoInicial.CurrentRow.Cells["Codigo"].Value.ToString();
            if (string.IsNullOrEmpty(codigo))
                return;
            int estadoCaja = Convert.ToInt16(dtgSaldoInicial.CurrentRow.Cells["Estado"].Value);
            if (estadoCaja == 0)
            {
                if (RadMessageBox.Show("¿REALMENTE DESEA ELIMINAR?\n Todos los datos pertenecientes a este saldo inicial seran eliminado", "MBCORP", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    CajaIniEN.ID = codigo;
                    bool EstadoEjecucion = CajaIniBL.EliminarCajaInicio(CajaIniEN, EmpresaEN.idEmpresaStatic);
                    if (EstadoEjecucion)
                    {
                        RadMessageBox.Show("SE ELIMINO CORRECTAMENTE", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Info);
                        cargarGrillaCajaInicio();
                    }
                }
            }
            
        }

        private void cboDocumento_Enter(object sender, EventArgs e)
        {
            cargarCboDocumento();
        }

        private void BtnSaldosFinales_Click(object sender, EventArgs e)
        {
            FrmSaldosFinales frm = new FrmSaldosFinales();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            FrmReporteCajaIncio frm = new FrmReporteCajaIncio(EmpresaEN.idEmpresaStatic);
            frm.ShowDialog();
            frm.Dispose();
        }

    }
}
