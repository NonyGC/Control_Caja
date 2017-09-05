namespace CapaPresentacion
{
    partial class FrmReporteCajaIncio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CrvSaldosIniciales = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // CrvSaldosIniciales
            // 
            this.CrvSaldosIniciales.ActiveViewIndex = -1;
            this.CrvSaldosIniciales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvSaldosIniciales.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrvSaldosIniciales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrvSaldosIniciales.Location = new System.Drawing.Point(0, 0);
            this.CrvSaldosIniciales.Name = "CrvSaldosIniciales";
            this.CrvSaldosIniciales.ShowLogo = false;
            this.CrvSaldosIniciales.Size = new System.Drawing.Size(905, 563);
            this.CrvSaldosIniciales.TabIndex = 0;
            this.CrvSaldosIniciales.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmReporteCajaIncio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 563);
            this.Controls.Add(this.CrvSaldosIniciales);
            this.Name = "FrmReporteCajaIncio";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MBCORP";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmReporteCajaIncio_Load);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvSaldosIniciales;
    }
}
