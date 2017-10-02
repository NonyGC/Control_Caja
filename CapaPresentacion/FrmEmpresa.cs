using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Capa_Entidad;
using Capa_Negocio;

namespace CapaPresentacion
{
    public partial class FrmEmpresa : Telerik.WinControls.UI.RadForm
    {
        EmpresaEN EmpEN = new EmpresaEN();
        EmpresaBL EmpBL = new EmpresaBL();
        private string idEmpresa;
        public FrmEmpresa()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mssg = "";
            if (TxtRuc.Text == string.Empty)
            {
                mssg = "Ingresar RUC\n";
                RadMessageBox.Show(mssg, "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }

            if (TxtRazonSocial.Text == string.Empty)
            {
                mssg += "Ingresar Razón Social\n";
                RadMessageBox.Show(mssg, "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
           


            bool EstadoEjecucion = false;
            if (BtnGuardar.Text == "GUARDAR")
            {
                pasarDatos_EmpresaEN_G();
                EstadoEjecucion = EmpBL.RegistrarEmpresa(EmpEN);
                if (EstadoEjecucion)
                {
                    RadMessageBox.Show("SE REGISTRO CORRECTAMENTE", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Info);
                    cargarGrillaEmpresa();
                    limpiarControlesEditables();
                }
            }
            if (BtnGuardar.Text == "ACTUALIZAR")
            {
                pasarDatos_EmpresaEN_A();
                EstadoEjecucion = EmpBL.ActualizarEmpresa(EmpEN);
                if (EstadoEjecucion)
                {
                    RadMessageBox.Show("SE ACTUALIZO CORRECTAMENTE", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Info);
                    cargarGrillaEmpresa();
                    limpiarControlesEditables();
                    BtnGuardar.Text = "GUARDAR";
                }

            }

        }
        private void pasarDatos_EmpresaEN_G()
        {
            EmpEN.ruc = TxtRuc.Text;
            EmpEN.RazonSocial = TxtRazonSocial.Text;
            EmpEN.Direccion = TxtDireccion.Text;
        }

        private void pasarDatos_EmpresaEN_A()
        {
            EmpEN.idEmpresa = idEmpresa;
            pasarDatos_EmpresaEN_G();
        }
        private void pasarDatosGrillaAControl()
        {
            var RowEmpresa = GrvEmpresa.CurrentRow;
            idEmpresa = RowEmpresa.Cells["ID"].Value.ToString();
            TxtRuc.Text = RowEmpresa.Cells["Ruc"].Value.ToString();
            TxtRazonSocial.Text = RowEmpresa.Cells["RazonSocial"].Value.ToString();
            TxtDireccion.Text = RowEmpresa.Cells["Direccion"].Value.ToString();
        }

        private void limpiarControlesEditables()
        {
            TxtRuc.Clear();
            TxtRazonSocial.Clear();
            TxtDireccion.Clear();
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            cargarGrillaEmpresa();
        }
        private void cargarGrillaEmpresa()
        {
            GrvEmpresa.DataSource = EmpBL.obtenerEmpresa();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            limpiarControlesEditables();
            pasarDatosGrillaAControl();
            BtnGuardar.Text = "ACTUALIZAR";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            cargarGrillaEmpresa();
            limpiarControlesEditables();
            BtnGuardar.Text = "GUARDAR";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string id = GrvEmpresa.CurrentRow.Cells["ID"].Value.ToString();
            if (string.IsNullOrEmpty(id))
                return;
            if (RadMessageBox.Show("¿REALMENTE DESEA ELIMINAR?", "MBCORP", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                bool EstadoEjecucion = EmpBL.EliminarEmpresa(id);
                if (EstadoEjecucion)
                {
                    RadMessageBox.Show("SE ELIMINO CORRECTAMENTE", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Info);
                    cargarGrillaEmpresa();
                }
            }
        }

        private void TxtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared.validarSoloNumeros(e);
        }
    }
}
