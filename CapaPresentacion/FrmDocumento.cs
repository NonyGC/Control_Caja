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

namespace CapaPresentacion
{
    public partial class FrmDocumento : Telerik.WinControls.UI.RadForm
    {
        DocumentoBL DocBL = new DocumentoBL();
        DocumentoEN DocEN = new DocumentoEN();
        public FrmDocumento()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("VisualStudio2012Light");
        }

        private void FrmDocumento_Load(object sender, EventArgs e)
        {
            cargarGrillaDocumentos();
        }
        void cargarGrillaDocumentos()
        {
            grvListadaComprobante.DataSource = DocBL.ObtenerTipoDocumentoBL();
        }
        void limpiarControlesEditables()
        {
            txtID.Clear();
            txtDescripcionComprobante.Clear();
            txtNumeroComprobante.Clear();
        }

        private void btnGuardarActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcionComprobante.Text))
                return;


            bool EstadoEjecucion = false;
            if (btnGuardar.Text == "GUARDAR")
            {
                asignarValorEntidadGuardar();
                EstadoEjecucion = DocBL.RegistrarNuevoDocumento(DocEN);
                if (EstadoEjecucion)
                {
                    RadMessageBox.Show("SE REGISTRO CORRECTAMENTE", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Info);
                    cargarGrillaDocumentos();
                    limpiarControlesEditables();
                }
            }
            if (btnGuardar.Text == "ACTUALIZAR")
            {
                if (string.IsNullOrEmpty(txtID.Text))
                    return;

                asignarValorEntidadActualizar();
                EstadoEjecucion = DocBL.ActualizarDocumento(DocEN);
                if (EstadoEjecucion)
                { 
                    RadMessageBox.Show("SE ACTUALIZO CORRECTAMENTE", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Info);
                    cargarGrillaDocumentos();
                    limpiarControlesEditables();
                }

            }
            
        }

        private void asignarValorEntidadGuardar()
        {
            DocEN.NroComprobante = txtNumeroComprobante.Text;
            DocEN.DescripcionComprobante = txtDescripcionComprobante.Text;
        }
        private void asignarValorEntidadActualizar()
        {
            asignarValorEntidadGuardar();
            DocEN.ID = txtID.Text;
        }

        private void txtNumeroComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared.validarSoloNumeros(e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            pasarDatosGrillaAControlEdit();
        }

        private void pasarDatosGrillaAControlEdit()
        {
            var grvCurrentRow = grvListadaComprobante.CurrentRow;
            txtNumeroComprobante.Text = grvCurrentRow.Cells["NDOC"].Value.ToString();
            txtDescripcionComprobante.Text = grvCurrentRow.Cells["DESCRIPCION"].Value.ToString();
            txtID.Text = grvCurrentRow.Cells["ID"].Value.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            prepararControlesDeIngreso();
            btnGuardar.Text = "GUARDAR";
        }

        private void prepararControlesDeIngreso()
        {
            limpiarControlesEditables();
            grpBxGestionarCompr.Enabled = true;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
        }

        private void grvListadaComprobante_CellClick(object sender, GridViewCellEventArgs e)
        {
            prepararControlesDeIngreso();
            btnGuardar.Text = "ACTUALIZAR";
            btnEliminar.Enabled = true;
            pasarDatosGrillaAControlEdit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
                return;
            if(RadMessageBox.Show("¿REALMENTE DESEA ELIMINAR?", "MBCORP",MessageBoxButtons.YesNo,RadMessageIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                DocEN.ID = txtID.Text;
                bool EstadoEjecucion = DocBL.EliminarDocumento(DocEN);
                if (EstadoEjecucion)
                {
                    RadMessageBox.Show("SE ELIMINO CORRECTAMENTE", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Info);
                    cargarGrillaDocumentos();
                    limpiarControlesEditables();
                }
            }
        }
    }
}
