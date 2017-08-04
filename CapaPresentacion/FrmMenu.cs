using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Capa_Entidad;

namespace CapaPresentacion
{
    public partial class FrmMenu : Telerik.WinControls.UI.RadForm
    {

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            lblEmpresa.Text = EmpresaEN.RazonSocial;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            FrmSaldoInicial Frm = new FrmSaldoInicial();
            Frm.Show();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            FrmMovimientoCaja Frm = new FrmMovimientoCaja();
            Frm.Show();
        }
    }
}
