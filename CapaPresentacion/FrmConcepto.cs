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
    public partial class FrmConcepto : Telerik.WinControls.UI.RadForm
    {
        ConceptoBL ConBL = new ConceptoBL();
        ConceptoEN ConEN = new ConceptoEN();
        public FrmConcepto()
        {
            InitializeComponent();
        }


        private void FrmConcepto_Load(object sender, EventArgs e)
        {
            cargarGrillaConcept();
        }

        private void cargarGrillaConcept()
        {
            DataTable dt = new DataTable();
            dt = ConBL.ObtenerConceptoBL();
            grvConcepto.DataSource = dt;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
            txtID.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtDescripcion.Text))
                return;

            bool EstadoEjecucion = false;
            if (btnGuardar.Text == "GUARDAR")
            {
                ConEN.Descripcion = txtDescripcion.Text;

                EstadoEjecucion = ConBL.RegistrarNuevoConcepto(ConEN);
                if (EstadoEjecucion)
                {
                    RadMessageBox.Show("SE REGISTRO CORRECTAMENTE", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Info);
                    cargarGrillaConcept();
                    //limpiarControlesEditables();
                }
            }
            if (btnGuardar.Text == "ACTUALIZAR")
            {
                if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
                    return;

                ConEN.ID = txtID.Text;
                ConEN.Descripcion = txtDescripcion.Text;

                EstadoEjecucion = ConBL.ActualizarConcepto(ConEN);
                if (EstadoEjecucion)
                {
                    RadMessageBox.Show("SE ACTUALIZO CORRECTAMENTE", "MBCORP", MessageBoxButtons.OK, RadMessageIcon.Info);
                    cargarGrillaConcept();
                    //limpiarControlesEditables();
                }

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var CurrntRow = grvConcepto.CurrentRow;
            txtID.Text=CurrntRow.Cells["ID"].ToString();
            txtDescripcion.Text= CurrntRow.Cells["Descripcion"].ToString();
        }
    }
}
