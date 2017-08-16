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
using Telerik.WinControls.UI;
using System.Globalization;

namespace CapaPresentacion
{
    public partial class FrmMovimientoCaja : Telerik.WinControls.UI.RadForm
    {
        DocumentoBL DocBL = new DocumentoBL();
        ConceptoBL ConBL = new ConceptoBL();
        MovimientoBL MovBL = new MovimientoBL();
        MovimientoEN MovEN = new MovimientoEN();
        CajaCierre CajCEN = new CajaCierre();
        private decimal _ingreso, _egreso;
        private decimal _saldoIncial = 0;
        private decimal _saldoFinal = 0;
        private string idCajaInicio = string.Empty;

        public FrmMovimientoCaja()
        {
            InitializeComponent();
        }

        private void FrmMovimientoCaja_Load(object sender, EventArgs e)
        {
            cargarDatosAlFormulario();
            dropDownListLimitAutocomplete();
            cargarcboDocumento();
            cargarcboConcepto();

        }
        private void dropDownListLimitAutocomplete()
        {
            cboDocumento.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            cboConcepto.DropDownListElement.AutoCompleteAppend.LimitToList = true;
        }
        private void cargarDatosAlFormulario()
        {
            DateTime FechaActual = DateTime.Today;

            lblEmpresa.Text = EmpresaEN.RazonSocial;
            lblFecha.Text = FechaActual.ToShortDateString();
            DataTable dts = MovBL.cargarDatosDeSaldoInicial(EmpresaEN.idEmpresa);

            MCCboCodigo.ValueMember = "ID";
            MCCboCodigo.DisplayMember = "CodigoFecha";
            MCCboCodigo.SelectedIndex = -1;
            MCCboCodigo.DataSource = dts;
        }

        private void restablecerControlesDeEntrada()
        {
            cboDocumento.SelectedIndex = -1;
            cboConcepto.SelectedIndex = -1;
            RbtIngreso.Checked = true;
        }
        private void limpiarControlesDeEntrada()
        {
            TxtSerie.Clear();
            TxtNumero.Clear();
            TxtMonto.Clear();
            TxtObservacion.Clear();
        }

        private void cargarGrillaMovimiento()
        {
            if (MCCboCodigo.SelectedValue == null)
                return;
            DataTable dtMovimiento = MovBL.ObtenerListadoMoviento(MCCboCodigo.SelectedValue.ToString());
            grvMovimiento.DataSource = dtMovimiento;

            obtenerMontoMovimiento(dtMovimiento);
            calcularTotalMovimiento();
        }
        private void obtenerMontoMovimiento(DataTable dt)
        {
            _ingreso = 0; _egreso = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row["TipoMovimiento"].ToString() == "INGRESO")
                    _ingreso += Convert.ToDecimal(row["Monto"]);
                if (row["TipoMovimiento"].ToString() == "EGRESO")
                    _egreso += Convert.ToDecimal(row["Monto"]);
            }
        }
        private void calcularTotalMovimiento()
        {
            TxtTotIngreso.Text = _ingreso.ToString("C");
            TxtTotEgreso.Text = _egreso.ToString("C");
            _saldoFinal = (_saldoIncial + _ingreso - _egreso);
            TxtSaldoFinal.Text = _saldoFinal.ToString("C");
        }

        private void BtnNuevoDocumento_Click(object sender, EventArgs e)
        {
            FrmDocumento Frm = new FrmDocumento();
            Frm.ShowDialog();
            Frm.Dispose();
        }

        private void TxtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            RadTextBox TextBox = (RadTextBox)sender;
            Shared.validadarDosDecimales(e, TextBox.Text);
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared.validarSoloNumeros(e);
        }


        private void MCCboCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }



        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (MCCboCodigo.SelectedValue == null)
                return;
            // Validar estado de caja(Cerrado/Abierto)(0=false)(1=true)
            if (obtenerValMCCboCodigoSeleccionado("Estado") == "True")
            {
                RadMessageBox.Show("CAJA ESTA CERRADO", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(TxtMonto.Text))
                return;
            if (cboDocumento.SelectedValue == null)
                return;
            if (cboConcepto.SelectedValue == null)
                return;
            if (RbtEgreso.Checked == true)
                if (validarEgresoMovimiento() == false)
                {
                    RadMessageBox.Show("VALOR DE EGRESO EXCEDE EL MONTO EXISTENTE", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Error);
                    return;
                }

            bool EstadoEjecucion = false;
            if (BtnAgregar.Text == "AGREGAR")
            {
                AsignarValorMovimientoEN();
                EstadoEjecucion = MovBL.AgregarNuevoMovimiento(MovEN);
                if (EstadoEjecucion)
                {
                    RadMessageBox.Show("SE REGISTRO CORRECTAMENTE", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Info);
                    restablecerControlesDeEntrada();
                    limpiarControlesDeEntrada();
                    cargarGrillaMovimiento();
                }
            }
            if (BtnAgregar.Text == "ACTUALIZAR")
            {
                MovEN.IdMov = TxtNumMov.Text;
                AsignarValorMovimientoEN();

                EstadoEjecucion = MovBL.actualizarMovimiento(MovEN);
                if (EstadoEjecucion)
                {
                    RadMessageBox.Show("SE ACTUALIZO CORRECTAMENTE", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Info);
                    restablecerControlesDeEntrada();
                    limpiarControlesDeEntrada();
                    cargarGrillaMovimiento();
                }
            }
        }
        private bool validarEgresoMovimiento()
        {
            var resto = (_saldoFinal - Convert.ToDecimal(TxtMonto.Text));
            return (resto < 0) ? false : true;
        }


        private void MCCboCodigo_Leave(object sender, EventArgs e)
        {
            if (MCCboCodigo.SelectedValue == null)
                return;

            string Fecha = obtenerValMCCboCodigoSeleccionado("Fecha");

            string Codigo = MCCboCodigo.SelectedValue.ToString();

            _saldoIncial = MovBL.obtenerSaldoInicial(EmpresaEN.idEmpresa, Codigo, Fecha);
            TxtSaldoInicial.Text = _saldoIncial.ToString("C");
            cargarGrillaMovimiento();
        }
        private string obtenerValMCCboCodigoSeleccionado(string Columna)
        {
            GridViewDataRowInfo MultCbo = (GridViewDataRowInfo)MCCboCodigo.SelectedItem;
            var result = MultCbo.Cells[Columna].Value.ToString();
            return result;
        }

        private void BtnCerarCaja_Click(object sender, EventArgs e)
        {
            if (MCCboCodigo.SelectedValue == null)
                return;
            if (obtenerValMCCboCodigoSeleccionado("Estado") == "True")
            {
                RadMessageBox.Show("CAJA ESTA CERRADO", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            var InputBoxObs = RadInputBox.Show("[Cierre de Caja] Ingrese observación :", "MBCORP");
            if (string.IsNullOrEmpty(InputBoxObs))
                return;
            idCajaInicio = MCCboCodigo.SelectedValue.ToString();
            if (string.IsNullOrEmpty(idCajaInicio))
                return;

            CajCEN.id = idCajaInicio;
            CajCEN.Empresa = EmpresaEN.idEmpresa;
            CajCEN.SaldoIncial = _saldoIncial;
            CajCEN.TotalIngreso = _ingreso;
            CajCEN.TotalEgreso = _egreso;
            CajCEN.SaldoFinal = _saldoFinal;
            CajCEN.Observacion = InputBoxObs;

            bool EstadoEjecucion = false;
            {

                EstadoEjecucion = MovBL.AgregarNuevoCajaCierre(CajCEN);
                if (EstadoEjecucion)
                {
                    bool estado = MovBL.ActualizarEtadoCaja(idCajaInicio);
                    if (estado)
                    {
                        RadMessageBox.Show("SE CERRO CORRECTAMENTE LA CAJA", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Info);
                        cargarDatosAlFormulario();
                        restablecerControlesDeEntrada();
                        limpiarControlesDeEntrada();
                        LimpiargrvMovimiento();
                        LimpiarCajaDeSaldos();
                    }

                }
            }

        }

        private void LimpiarCajaDeSaldos()
        {
            TxtSaldoInicial.Clear();
            TxtSaldoFinal.Clear();
            TxtTotEgreso.Clear();
            TxtTotIngreso.Clear();
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            FrmConcepto frm = new FrmConcepto();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MCCboCodigo.SelectedValue == null)
                return;
            if (obtenerValMCCboCodigoSeleccionado("Estado") == "True")
            {
                RadMessageBox.Show("CAJA ESTA CERRADO", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }

            if (RadMessageBox.Show("¿REALMENTE DESEA ELIMINAR?", "MBCORP", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                var grvCurrent = grvMovimiento.CurrentRow;
                MovEN.IdMov = grvCurrent.Cells["ID"].Value.ToString();
                MovEN.IDCaja = MCCboCodigo.SelectedValue.ToString();

                bool EstadoEjecucion = MovBL.EliminarMovimento(MovEN);
                if (EstadoEjecucion)
                {
                    RadMessageBox.Show("SE ELIMINO CORRECTAMENTE", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Info);
                    cargarGrillaMovimiento();
                }
            }

        }

        private void cboConcepto_Enter(object sender, EventArgs e)
        {
            cargarcboConcepto();
        }
        private void cboDocumento_Enter(object sender, EventArgs e)
        {
            cargarcboDocumento();
        }
        private void cargarcboDocumento()
        {
            cboDocumento.DataSource = DocBL.ObtenerTipoDocumentoBL();
            cboDocumento.DisplayMember = "Descripcion";
            cboDocumento.ValueMember = "Id";
            cboDocumento.SelectedIndex = -1;
        }

        private void cargarcboConcepto()
        {
            cboConcepto.DataSource = ConBL.ObtenerConceptoBL();
            cboConcepto.DisplayMember = "Descripcion";
            cboConcepto.ValueMember = "ID";
            cboConcepto.SelectedIndex = -1;
        }
        private void RbtModificar_Click(object sender, EventArgs e)
        {
            if (MCCboCodigo.SelectedValue == null)
                return;

            if (obtenerValMCCboCodigoSeleccionado("Estado") == "True")
            {
                RadMessageBox.Show("CAJA ESTA CERRADO", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            limpiarControlesDeEntrada();
            pasarDatosGrillaAControlEdit();
            BtnAgregar.Text = "ACTUALIZAR";
        }

        private void pasarDatosGrillaAControlEdit()
        {
            var RowCurrent = grvMovimiento.CurrentRow;
            TxtNumMov.Text = RowCurrent.Cells["ID"].Value.ToString();
            TxtSerie.Text = RowCurrent.Cells["Serie"].Value.ToString();
            TxtNumero.Text = RowCurrent.Cells["Numero"].Value.ToString();
            var Movimiento = RowCurrent.Cells["Movimiento"].Value.ToString();
            if (Movimiento == "INGRESO")
                RbtIngreso.Checked = true;
            if (Movimiento == "EGRESO")
                RbtEgreso.Checked = true;

            cboDocumento.SelectedValue = RowCurrent.Cells["IDDocumento"].Value;
            var montogrid = RowCurrent.Cells["Monto"].Value.ToString();
            decimal monto = decimal.Parse(montogrid, NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands);
            TxtMonto.Text = monto.ToString();

            TxtObservacion.Text = RowCurrent.Cells["Observacion"].Value.ToString();
            cboConcepto.SelectedValue = RowCurrent.Cells["Concepto"].Value;
        }

        private void MCCboCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarControlesDeEntrada();
            restablecerControlesDeEntrada();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpiarControlesDeEntrada();
            restablecerControlesDeEntrada();
        }

        private void LimpiargrvMovimiento()
        {
            grvMovimiento.DataSource = null;
            InitializeComponentRadGridView();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (MCCboCodigo.SelectedValue == null)
                return;
            var IDCaja= MCCboCodigo.SelectedValue.ToString();
            FrmReporteMovimiento frm = new FrmReporteMovimiento(IDCaja);
            frm.Show();
            //frm.Dispose();
        }

        private void AsignarValorMovimientoEN()
        {
            MovEN.IDCaja = MCCboCodigo.SelectedValue.ToString();
            MovEN.Concepto = cboConcepto.SelectedValue.ToString();
            MovEN.Observacion = TxtObservacion.Text;
            MovEN.IDDocumento = cboDocumento.SelectedValue.ToString();
            MovEN.Serie = TxtSerie.Text;
            MovEN.Numero = TxtNumero.Text;
            MovEN.TipoMovimiento = RbtIngreso.Checked == true ? "INGRESO" : "EGRESO";
            MovEN.Monto = TxtMonto.Text;
        }

    }


}
