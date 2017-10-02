namespace CapaPresentacion
{
    partial class FrmReporteMovimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteMovimiento));
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.CrvMovimiento = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // CrvMovimiento
            // 
            this.CrvMovimiento.ActiveViewIndex = -1;
            this.CrvMovimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvMovimiento.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrvMovimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrvMovimiento.Location = new System.Drawing.Point(0, 0);
            this.CrvMovimiento.Name = "CrvMovimiento";
            this.CrvMovimiento.Size = new System.Drawing.Size(905, 689);
            this.CrvMovimiento.TabIndex = 0;
            this.CrvMovimiento.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmReporteMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(905, 689);
            this.Controls.Add(this.CrvMovimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteMovimiento";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MBCORP";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmReporteMovimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvMovimiento;
    }
}
